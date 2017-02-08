using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using Sharp7;

namespace lasetCtrl
{
    public class lsqElement
    {
        public int offset;
        public int type;
        public Byte[] data = new Byte[4];
        public int DBnum;
        public UInt16 len;
    }


    class Memory
    {
       public  Byte [] m_mRegion = new Byte[1000];


        public Byte getMByte(UInt16 offset)
        {
            return m_mRegion[offset];
        }

        public bool getMBit(UInt16 offset, UInt16 bitOffset)
        {
            return (m_mRegion[offset] & (1 << bitOffset)) != 0; 
        }

        public UInt16 getMUInt16(UInt16 offset)
        {
            return (UInt16)((((UInt16)m_mRegion[offset + 1]) << 8) | ((UInt16)m_mRegion[offset]));
        }

        public UInt32 getMUInt32(UInt16 offset)
        {
            return (UInt32)((((UInt32)m_mRegion[offset + 3]) << 8 * 3) | (((UInt32)m_mRegion[offset + 2]) << 8 * 2) | (((UInt32)m_mRegion[offset + 1]) << 8 * 1) | ((UInt16)m_mRegion[offset]));
        }

        public float getMFloat(UInt16 offset)
        { 
            Byte[] d = new Byte[4];
            d[0] = m_mRegion[offset + 3];
            d[1] = m_mRegion[offset + 2];
            d[2] = m_mRegion[offset + 1];
            d[3] = m_mRegion[offset + 0];
            return BitConverter.ToSingle(d, 0);
        }

     


        public void setMUInt16( UInt16 offset,  UInt16 val) 
        {
            lsqElement el = new lsqElement();
            el.offset = offset;
            el.type = S7Consts.S7AreaMK;
            var tmp = BitConverter.GetBytes(val);
            el.data[0] = BitConverter.GetBytes(val)[1];
            el.data[1] = BitConverter.GetBytes(val)[0];
            el.len = 2;

            cq.Enqueue(el);
        }

        public void setMUInt32(UInt16 offset, UInt32 val)
        {
            lsqElement el = new lsqElement();
            el.offset = offset;
            el.type = S7Consts.S7AreaMK;
            var tmp = BitConverter.GetBytes(val);
            el.data[0] = BitConverter.GetBytes(val)[3];
            el.data[1] = BitConverter.GetBytes(val)[2];
            el.data[2] = BitConverter.GetBytes(val)[1];
            el.data[3] = BitConverter.GetBytes(val)[0];
            el.len = 4;

            cq.Enqueue(el);
        }

        public void setMFloat( UInt16 offset, float val)
        {
            lsqElement el = new lsqElement();
            el.offset = offset;
            el.type = S7Consts.S7AreaMK;
            var tmp = BitConverter.GetBytes(val);
            el.data[0] = BitConverter.GetBytes(val)[3];
            el.data[1] = BitConverter.GetBytes(val)[2];
            el.data[2] = BitConverter.GetBytes(val)[1];
            el.data[3] = BitConverter.GetBytes(val)[0];
            el.len = 4;

            cq.Enqueue(el);
        }

        public void setMBit( UInt16 offset, UInt16 bitOffset, bool val)
        {
            lsqElement el = new lsqElement();
            el.offset = offset;
            el.type = S7Consts.S7AreaMK;
            var tmp = BitConverter.GetBytes(val);
            el.data[0] = val ? (byte)(m_mRegion[offset]  | ((1 << bitOffset) )) : (byte)  (m_mRegion[offset] & ~(1 << bitOffset));
            
            el.len = 1;

            cq.Enqueue(el);
        }

        public bool  getStoreElement(ref lsqElement el)
        {
            return cq.TryDequeue(out el);
        }

        ConcurrentQueue<lsqElement> cq = new ConcurrentQueue<lsqElement>();
    }
}
