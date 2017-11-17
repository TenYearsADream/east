using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   // DLL support
using System.Windows.Forms;
using System.Security;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Diagnostics;


namespace SpIceControllerLib
{
    public static class SpIceController
    {
        static SpIceController()
        {
            m_mainThreadPermission = true;
            m_mainThread = new Thread(mainThreadHandler);
            m_mainThread.Start();
            laserCount = 1;
        }

        public static void mainThreadHandler()
        {
            while (m_mainThreadPermission)
            {
                m_mut.WaitOne();
                processSignals();
                m_mut.ReleaseMutex();
                Thread.Sleep(10);
            }
        }

        public static IntSignals m_inputSignals = IntSignals.Empty;
       
        public static bool test;
        static public IntState m_state = IntState.Wait;
        static public UInt32 m_layerNumber = 0;
        static public bool m_layersFinishid = false;
        static private bool m_mainThreadPermission = false;
        static Thread m_mainThread;
        static Thread m_controllFormThread;
        static bool dbg = false;

        static public int laserCount
        { get; set; }

        static ListNumber m_runningLIst = ListNumber.Undefine;
        internal static Mutex m_mut = new Mutex();

        static Stopwatch m_stopWatch = new Stopwatch();
        static TimeSpan m_timeExecutinLayer;

        static private bool m_dirtyRunSignal = false;
        static private bool m_dirtyResetSignal = false;

        static private string m_workSpacePath = "";
        static public string workStacePath
        {
            get { return (m_workSpacePath); }
        }

       static bool m_isIntiialize = false;     // status of card inicialization
        static public bool isIntiialize
        {
            get { return (m_isIntiialize); }
        }

        static private cardStatus[]  m_cardStatus = new cardStatus[4];
        static public cardStatus getCardStatus(int number)
        {
             return (m_cardStatus[number]); 
        }

        static private Int32 m_currenlList = 0;



        private static void initCard(object sender, CardEventArgs e)
        {
            fileLoader.m_mut.WaitOne();
            m_mut.WaitOne();

            fileLoader.m_cs = e.cs;
            NativeMethods.debugInit();
            fileLoader.debugInit();

            bool rLoad = false  , rInit = false, rSetAct =false, setGain  = false, rSetMode = false, rOsc = false;

            string result = "";
            m_isIntiialize = true;
            //start with number 1
            for (ushort cardNumber = 1; cardNumber < laserCount + 1; cardNumber++)
            {

                rInit = NativeMethods.PCI_Init_Scan_Card_Ex(cardNumber);
                rLoad = NativeMethods.PCI_Load_Corr_N(e.cs.corrFilePatch, (short)cardNumber);
                rSetAct = NativeMethods.PCI_Set_Active_Card((UInt16)cardNumber);
                setGain = NativeMethods.PCI_Set_Gain(e.cs.gainX, e.cs.gainY, 0, 0, (UInt16)e.cs.num);
                rSetMode = NativeMethods.PCI_Set_Mode(e.cs.mode);
                NativeMethods.PCI_Stop_Execution();
                rOsc = NativeMethods.PCI_Write_Port_List(0xC, 0x00);
                result += string.Format("\n {0} ... {1, -15}\n {2} ... {3, -15}\n {4} ... {5, -15}\n {6} ... {7, -15}\n {8} ... {9, -15}  \n {10} ... {11, -15} \n",
                 
                 "Initializing card ", cardNumber,   
                 "Init ", rInit ? "Ok" : "Fail",
                 "Set mode ", rSetMode ? "Ok" : "Fail",
                 "Set active card ", rSetAct ? "Ok":"Fail" ,
                 "Oscillator on ", rOsc ? "Ok" : "Fail",
                 "Set gain ", setGain ? "Ok" : "Fail");

                m_isIntiialize =  m_isIntiialize && rInit && rSetAct && rSetMode && rOsc;

            }

            dbg = e.cs.debug;
            


            bool openScript = fileLoader.openJobfile(e.cs.scriptPath);
            PrefetchList.resetList();
            m_state = IntState.Wait ;

            result += string.Format("\n\n{0} ... {1, -10} \n", "Open script ", openScript.ToString(), e.cs.scriptPath);
            result += string.Format("{0} ... {2, -10}   ({1}) \n   ",
                 "Load correction ", e.cs.corrFilePatch, rLoad.ToString());

            m_isIntiialize  = m_isIntiialize &&   openScript;



            MessageBox.Show(result,
                 (m_isIntiialize ? "Инициализация прошла успешно!" : "Ошибка при инициализации"),
                 MessageBoxButtons.OK,
                 m_isIntiialize ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1,
                 (MessageBoxOptions)0x40000);

            m_layersFinishid = false;

            fileLoader.m_mut.ReleaseMutex();
            m_mut.ReleaseMutex();
        }

        public static void ThreadProc()
        {
            var frm = new Form1();

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;

            frm.Text = "SP-ICE initialization, ver - " + version;

            frm.cardSetting += initCard;
            frm.ShowDialog();
        //    frm.Dispose(); ////
        }


        public static void initForm()
        {
            m_controllFormThread = new Thread(new ThreadStart(ThreadProc));
            m_controllFormThread.SetApartmentState(ApartmentState.STA);
            m_controllFormThread.Start();
        }

        public static void processSignals()
        {
            for(int i =0; i <= laserCount; i++)
           NativeMethods.readStatus(ref m_cardStatus[i], i);

            if (m_isIntiialize)
                PrefetchList.stepExecution();

            IntSignals s = m_inputSignals;
            switch (m_state)
            {
                case IntState.Wait:
                    WaitState();
                    if ((s & IntSignals.Run) != 0)
                    {
                        m_inputSignals &= ~IntSignals.Run;
                        m_state = IntState.WaitListReady;
                    }
                    break;

                case IntState.WaitListReady:

                    fillList();

                    if ((s & (IntSignals.Reset)) != 0)
                        processStopRequest();

                    break;

                case IntState.Work:

                    WorkState();

                    if ((s & (IntSignals.Reset)) != 0)
                        processStopRequest();

                    break;
            }
        }

        private static void processStopRequest()
        {
            NativeMethods.PCI_Stop_Execution();
            NativeMethods.PCI_Write_Port(0xC, 0x000);
            fileLoader.m_mut.WaitOne();    //lock file loader thread
            fileLoader.resetFile();
            PrefetchList.resetList();
            m_runningLIst = ListNumber.Undefine;
            fileLoader.m_mut.ReleaseMutex();
            m_inputSignals &= ~(IntSignals.Reset);
            m_state = IntState.Wait;      // after reset always to wait State.
        }

        private static void fillList()
        {
            //wait list ready
            m_runningLIst = PrefetchList.getTopListNumber();
          
            if (m_runningLIst == ListNumber.Undefine)
            {
                m_layersFinishid = PrefetchList.m_lastListReady;
                if (m_layersFinishid) m_state = IntState.Wait;
                return;
            }

            m_layersFinishid = false;

            m_stopWatch.Restart();

            NativeMethods.PCI_Set_Active_Card((ushort)PrefetchList.getTopCardNumber());
            if (m_runningLIst == ListNumber.list1)
                NativeMethods.PCI_Execute_List_1();
            else
                NativeMethods.PCI_Execute_List_2();

            m_currenlList = (Int32) PrefetchList.getTopLayerNumber(m_runningLIst);
                ;
            m_state = IntState.Work;
        }

        private static void WorkState()
        {
            int num = PrefetchList.getTopCardNumber();


            if (m_cardStatus[PrefetchList.getTopCardNumber()].scanComlete) //wait until escan comlete
            {
                bool finish = PrefetchList.getTopFinished(m_runningLIst);
                PrefetchList.setFree(m_runningLIst);
                m_state = finish ? IntState.Wait : IntState.WaitListReady;
                m_stopWatch.Stop();
                m_timeExecutinLayer = m_stopWatch.Elapsed;
            }

            if (PrefetchList.getTopListNumber() == ListNumber.Undefine)
            {
                m_layersFinishid = PrefetchList.m_lastListReady;
            }
        }

        private static void WaitState()
        {
            //nothing to do
        }
        public static void deinitialize()
        {
            try
            {
                m_mainThreadPermission = false;
                m_mainThread.Join();

                fileLoader.stopfillJobList();
                PrefetchList.terminate();
            }
            catch
            {
            }
        }

        public static void StartLayer(bool val)
        {
            if (m_state == IntState.Wait)
            {
                if (val && !m_dirtyRunSignal)
                {
                    m_inputSignals |= IntSignals.Run;
                }

            }
            m_dirtyRunSignal = val;
        }

        public static void StartLayer_(bool val)
        {
            if (m_state == IntState.Wait)
            {
               // if (val && !m_dirtyRunSignal)
                {
                    m_inputSignals |= IntSignals.Run;
                }

            }
            m_dirtyRunSignal = val;
        }
        public static void ResetSignal(bool val)
        {
            if (m_state != IntState.Wait)
            {
                if (val && !m_dirtyResetSignal)
                {
                    m_inputSignals |= IntSignals.Reset;
                }

            }
            m_dirtyResetSignal = val;
        }


        public static bool isBusy()
        {
            return (m_state & (IntState.WaitListReady | IntState.Work)) != 0;
        }

        public static bool isWait()
        {
            return (m_state == IntState.Wait);
        }

        public static bool isFinish()
        {
            return m_layersFinishid;
        }

        public static Int32 getCurrentLayer()
        {
            return m_currenlList;
        }

        public static String getScripFileName()
        {
            return fileLoader.m_cs.scriptPath;
        }
        public static string getStateString()
        {
            return string.Format("Controller: {0, -20} isFinished: [{1}] TimeExecution: {2, 10}, Layer: {3, 6}", 
                m_state.ToString(),
                m_layersFinishid.toX(), 
                m_timeExecutinLayer,
                getCurrentLayer());
        }

        public static string getStateStringDebug()
        {
            return string.Format("List: {0, -10}",
                m_runningLIst);
        }

    }
}
