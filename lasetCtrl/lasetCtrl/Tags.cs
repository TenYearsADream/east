using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;
namespace lasetCtrl
{
    partial class Tags
    {

        public Tags(Memory val)
        {
            m_plc = val;

        }

        public UInt16 getInc()
        {
            return m_plc.getMWord(760);
        }

        public  void setInc(UInt16 val)
        {
            m_plc.setWord(S7Consts.S7AreaMK, 766, val);
        }

        Memory m_plc;

    }
}
