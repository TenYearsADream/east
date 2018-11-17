using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;
using System.Threading;


namespace laserScada
{
    class plc
    {
        public plc() {

            client = new S7Client();
            m_mem = new Memory();
            tags = new Tags(m_mem);
            Thread.VolatileWrite(ref isThereadActive, 1);
            m_Thread = new Thread(plcStep);
            m_Thread.IsBackground = true;
            m_Thread.Start();
        
        }

        ~plc()
        {
         
            Thread.VolatileWrite(ref isThereadActive, 0);
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
        public void disconnect()
        {
             client.Disconnect();
            
        }


        private void plcStep()
        {
           int res = 0;

            lsqElement el = new lsqElement();

            while (Thread.VolatileRead(ref isThereadActive) != 0)
            {
                if (isConnect)
                {

                    res = client.ReadArea(S7Consts.S7AreaMK, 0, 0, 800, S7Consts.S7WLByte, m_mem.m_mRegion);
                    isConnect = res == 0;
                    while (isConnect && m_mem.getStoreElement(ref el))
                    {
                        client.WriteArea(el.type, el.DBnum, el.offset, el.len, S7Consts.S7WLByte, el.data);
                    }
                }
                else
                {
                    disconnect();
                    Thread.Sleep(300);
                    connect();
                    
                }

                Thread.Sleep(100);
            }

        }

        public Memory m_mem;
        public Tags tags;
        S7Client client;
        Thread m_Thread;

        bool isConnect = false;
        int isThereadActive = 0;
        
    }
}
