using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;
using System.Threading;


namespace lasetCtrl
{
    class plc
    {
        public plc() {

            client = new S7Client();
            m_mem = new Memory();
            tags = new Tags(m_mem);
            isThereadActive = true;
            m_Thread = new Thread(plcStep);
            m_Thread.IsBackground = true;
            m_Thread.Start();
        
        }

        ~plc()
        {
            isThereadActive = false;
            isConnect = false;
            m_Thread.Join();
            client.Disconnect();
        }

        public bool connect(string ip = "192.168.100.2")
        {
            int connectResult = client.ConnectTo(ip, 0, 0);
            isConnect = connectResult == 0;
            return isConnect;
        }



        private void plcStep()
        {
           int res = 0;
            lsqElement el = new lsqElement();

            while (isThereadActive)
            {
                if (isConnect)
                {

                    res = client.ReadArea(S7Consts.S7AreaMK, 0, 0, 800, S7Consts.S7WLByte, m_mem.m_mRegion);

                    if (m_mem.getStoreElement(ref el))
                    {
                        client.WriteArea(el.type, el.DBnum, el.offset, el.len, S7Consts.S7WLByte, el.data);
                    }
                }

                Thread.Sleep(100);
            }

        }

        public Memory m_mem;
        public Tags tags;
        S7Client client;
        Thread m_Thread;

        bool isConnect = false;
        bool isThereadActive = false;
    }
}
