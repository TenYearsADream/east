using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;
using log4netSample.Logging;

namespace laserScada
{
    partial class Tags
    {

        public Tags(Memory val)
        {
            m_mem = val;

        }

        public bool get_avar_doz()
        { return (bool)m_mem.getMBit(527, 4); }

        public void set_avar_doz(bool val)
        {
            m_mem.setMBit(527, 4, (bool)val);
            Log.Write(LogLevel.Info, "set avar doz " + val.ToString());
        }

        public bool get_avar_m3()
        { return (bool)m_mem.getMBit(527, 5); }

        public void set_avar_m3(bool val)
        {
            m_mem.setMBit(527, 5, (bool)val);
            Log.Write(LogLevel.Info, "set avar doz " + val.ToString());
        }

        public enum activeType {
            command,
            led,
            dataField,
            invalid,
        };

        public activeType getActiveType(gTags tag)
        {

            if (group_com.Contains(tag)) return activeType.command;
            if (group_outD.Contains(tag)) return activeType.led;
            if (group_usta.Contains(tag)) return activeType.dataField;
            if (group_am.Contains(tag)) return activeType.dataField;
            return activeType.invalid;
        }
        Memory m_mem;

    }
}
