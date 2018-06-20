using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpIceControllerLib
{
    public enum ListStateFill{ prolog = 0x01, epilog = 0x02, body = 0x04, free = 0x10, ready = 0x20 };
    public struct exeTask
    {
        public ListNumber exeListNumber;
        public int cardNumber;

    }
    public struct listState
    {
        public ListStateFill filling;
        public ListNumber number;
        public int cardNumber;
        public long exeListNumber;
        public Int64 size;
        public bool finished;
        public UInt64 layerNumber;

        public listState(ListNumber num, int cardNum)
        {
            filling = ListStateFill.free;
            number = num;
            exeListNumber = 0;
            size = 0;
            finished = false;
            layerNumber = 0;
            cardNumber = cardNum;
        }

        public void reset()
        {
            filling = ListStateFill.free;
            exeListNumber = 0;
            size = 0;
            finished = false;
            layerNumber = 0;
        }
    }

    internal static class PrefetchList
    {
        const long LIST_SIZE = 1000000;
        //const long LIST_SIZE = 10000;
        static listState m_curListState;
        static StreamWriter m_logFile;
        static ListNumber m_currentList;
        static int m_currentCardNumber;
        static int m_nextCardNumber;
        static Int64 m_layerNumber;
        static public  bool m_lastListReady = false;
        static Queue<listState> m_sheldule = new Queue<listState>();
        static int maxCardNumber = SpIceController.laserCount;
       static styles  m_lastedStyle;
       static bool m_isNeedRestoreStyleOnProlog = false;
        

        static PrefetchList()
        {
 



            m_currentList = ListNumber.Undefine;
            m_logFile = new StreamWriter("prefetchLog.txt", false);

            //if (AppDomain.CurrentDomain.IsDefaultAppDomain())
            //    AppDomain.CurrentDomain.ProcessExit += terminate;
            //else
            //    AppDomain.CurrentDomain.DomainUnload += terminate;

            m_lastedStyle.lPower = long.MaxValue;
            m_lastedStyle.lMarkSize = long.MaxValue;
            m_sheldule.Clear();
            m_currentCardNumber = 1;
            m_nextCardNumber = 1;
           
        }

        static internal void terminate() //(object sender, EventArgs e)
        {
            m_logFile.Close();
        }

        static public void resetList()
        {
            m_layerNumber = 0;
            m_currentList = ListNumber.Undefine;
            m_lastListReady = false;
            m_lastedStyle.lPower = long.MaxValue;
            m_lastedStyle.lMarkSize = long.MaxValue;
            m_sheldule.Clear();
            m_currentCardNumber = 1;
            m_nextCardNumber = 1;
        }

        public static void stepExecution()
        {
            m_lastListReady = !fileLoader.isAviableNExt() && (fileLoader.isValidFile == 0);

            if (m_lastListReady)
            {
                m_curListState.filling = ListStateFill.free;
                return;
            }

            if (m_currentList == ListNumber.Undefine)
            {
                //                m_currentList = getNextFreeList();
                m_currentList = findFreeExeList(m_currentCardNumber);
                m_curListState.filling = ListStateFill.free;
                if (m_currentList == ListNumber.Undefine) return;
            }


            switch (m_curListState.filling)
            {
                case ListStateFill.free:
                    openList();
                    break;
                case ListStateFill.prolog:
                    fillProlog();
                    break;
                case ListStateFill.body:
                    bobyStartList();
                    break;
                case ListStateFill.epilog:
                    fillEpilog();
                    break;
                case ListStateFill.ready:
                    m_sheldule.Enqueue(m_curListState);
                    m_currentList = ListNumber.Undefine;
                    break;
                default:
                    break;
            }
        
        }

        private static void openList()
        {
            m_curListState.cardNumber = m_currentCardNumber;
            m_curListState.number = m_currentList;

            if (!fileLoader.m_isPreambuleFinish) return;
            NativeMethods.PCI_Set_Active_Card((ushort)m_currentCardNumber);
            if (m_currentList == ListNumber.list1)
                NativeMethods.PCI_Set_Start_List_1();
            else
                NativeMethods.PCI_Set_Start_List_2();

            styles st1 = m_curListState.cardNumber == 1 ? fileLoader.m_cs.style1: fileLoader.m_cs.style2;

            st1.lMarkSize = fileLoader.m_globalStyle.lMarkSize;
            st1.lPower = fileLoader.m_globalStyle.lPower;

            //if (m_isNeedRestoreStyleOnProlog)
            {
                if (m_lastedStyle.lPower != long.MaxValue) st1.lPower = m_lastedStyle.lPower;
                if (m_lastedStyle.lMarkSize != long.MaxValue) st1.lMarkSize = m_lastedStyle.lMarkSize; 
            }


           
                NativeMethods.PCI_Set_Delays((UInt16)st1.lStep, (UInt16)st1.lJampDelay, (UInt16)st1.lMarkDelay, (UInt16)st1.lPolygon, (UInt16)st1.lLaserOff, (UInt16)st1.lLaserOn, (UInt16)st1.lQt1, (UInt16)st1.lQt2, 0);
                NativeMethods.PCI_Set_Mark_Parameters_List((UInt16)st1.lStep, (UInt16)st1.lMarkSize);
                NativeMethods.PCI_Long_Delay(10);
                NativeMethods.PCI_Write_DA_List((UInt16)st1.lPower);
                NativeMethods.PCI_Write_Port_List(0xC, 0x010);
          
            
            m_layerNumber++;

            m_curListState.exeListNumber = m_layerNumber;
            m_curListState.filling = ListStateFill.prolog;
            
            m_curListState.size = 0;
            m_curListState.finished = false;
        }

        private static void fillProlog()
        {
            m_curListState.filling = ListStateFill.body;
        }

        private static void bobyStartList()
        {
           // writeLog("body start list");
            bool isEnd = false;
            while( fileLoader.isAviableNExt()){

                isEnd = decodeCommand(m_curListState.size > LIST_SIZE);
                if (isEnd) break;
                
            }

            if (isEnd)
            {
                m_curListState.filling = ListStateFill.epilog;

            }
        }


        private static bool decodeCommand(bool finishOnNearest = false) //return false if its last command in list
        {
            bool result = false;
            bool skipIncrement = false;
            Int64 iterator = fileLoader.getStartPos();
            NativeMethods.PCI_Set_Active_Card((ushort)m_currentCardNumber);
            switch (fileLoader.m_listJob[iterator].cmd)
            {
                case Command.EndF:
                    result = true;
                    break;
                case Command.StarLayer:
                    m_curListState.layerNumber = (UInt64)(fileLoader.m_listJob[iterator].x);
                    break;
                case Command.EndLayer:
                    m_curListState.finished = true;
                    result = true;
                    break;
                case Command.Jamp:
                    NativeMethods.PCI_Jump_Abs(fileLoader.m_listJob[iterator].x, fileLoader.m_listJob[iterator].y);
                    m_curListState.size++;
                    skipIncrement = finishOnNearest;
                    result = finishOnNearest;
                    break;
                case Command.Mark:
                    NativeMethods.PCI_Mark_Abs(fileLoader.m_listJob[iterator].x, fileLoader.m_listJob[iterator].y);
                    m_curListState.size++;
                    break;
                case Command.PolA_Abs:
                    NativeMethods.PCI_PolA_Abs(fileLoader.m_listJob[iterator].x, fileLoader.m_listJob[iterator].y);
                    m_curListState.size++;
                    break;
                case Command.PolB_Abs:
                    NativeMethods.PCI_PolB_Abs(fileLoader.m_listJob[iterator].x, fileLoader.m_listJob[iterator].y);
                    m_curListState.size++;
                    break;
                case Command.PolC_Abs:
                    NativeMethods.PCI_PolC_Abs(fileLoader.m_listJob[iterator].x, fileLoader.m_listJob[iterator].y);
                    m_curListState.size++;
                    result = finishOnNearest;
                    break;
                case Command.Power:
                    NativeMethods.PCI_Write_DA_List((UInt16)fileLoader.m_listJob[iterator].x);
                    m_curListState.size++;
                    m_lastedStyle.lPower = (UInt16)fileLoader.m_listJob[iterator].x;
                    break;
                case Command.MarkSize:
                    NativeMethods.PCI_Set_Mark_Parameters_List((UInt16)fileLoader.m_listJob[iterator].x, (UInt16)fileLoader.m_listJob[iterator].y);
                    m_curListState.size++;
                    m_lastedStyle.lStep= (UInt16)fileLoader.m_listJob[iterator].x;
                    m_lastedStyle.lMarkSize = (UInt16)fileLoader.m_listJob[iterator].y;
                    break;
                case Command.LaserActive:
                    if (fileLoader.m_listJob[iterator].x != m_currentCardNumber)
                    {
                       // m_curListState.finished = true;
                        m_nextCardNumber = fileLoader.m_listJob[iterator].x;
                        result = true;
                    }
                    break;

            }

            if (!skipIncrement)
            fileLoader.incrementStart();

            return result;
        
        }

        private static void fillEpilog()
        {
            NativeMethods.PCI_Set_Active_Card((ushort)m_currentCardNumber);
           // NativeMethods.PCI_Write_Port_List(0xC, 0x000);
            NativeMethods.PCI_Set_End_Of_List();
           // if(m_curListState.size>0)
            m_curListState.filling = ListStateFill.ready;
         //   else
          //      m_curListState.filling = ListStateFill.free;

            m_isNeedRestoreStyleOnProlog = !m_curListState.finished;
            m_currentCardNumber = m_nextCardNumber;
        }



        private static ListNumber findFreeExeList(int cardNumber)
        {
            bool list1IsFree = true;
            bool list2IsFree = true;
            foreach (var i in m_sheldule.ToList())
            {
                if (i.cardNumber == cardNumber)
                {
                    if (i.number == ListNumber.list1) list1IsFree = false;
                    else if (i.number == ListNumber.list2) list2IsFree = false;
                }
            }
            return list1IsFree ? ListNumber.list1 : list2IsFree ? ListNumber.list2 : ListNumber.Undefine;
        }

        public static ListNumber getTopListNumber()
        {
            return m_sheldule.Count > 0 ? m_sheldule.First().number : ListNumber.Undefine;
        }
        public static int getTopCardNumber()
        {
            return m_sheldule.Count > 0 ? m_sheldule.First().cardNumber : 0;
        }

        public static void setFree(ListNumber list)
        {
            m_sheldule.Dequeue();
        }

        internal static bool getTopFinished(ListNumber list)
        {
            return m_sheldule.Count > 0 ? m_sheldule.First().finished : true;
        }

        public static UInt64 getTopLayerNumber(ListNumber list)
        {
            return m_sheldule.Count > 0 ? m_sheldule.First().layerNumber : 0;
        }

        public static string getListState(ListNumber list)
        {
            if (list == ListNumber.Undefine) return "Undefine list..";
            string res = "";

            res = string.Format("{0, 6} ({5, 6}): {1, -7} size: {2, 6} fin [{3}], layer: {4, -5}", 
                list.ToString(), 
                m_curListState.filling.ToString(), 
                m_curListState.size.ToString("D6"), 
                m_curListState.finished.toX(),
                m_curListState.layerNumber, m_curListState.exeListNumber.ToString("D6"));//
            return res;
        }

        public static string getListStateDebug(ListNumber list)
        {
            if (list == ListNumber.Undefine) return "Undefine list..";
            string res = "";

            return res;
            //res = string.Format(", eXList: {0, -6}",
            //    m_l[(Int32)list].exeListNumber.ToString("D6"));//
            //return res;
        }

    }



}
