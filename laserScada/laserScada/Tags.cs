using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;
namespace laserScada
{
    partial class Tags
    {

        public Tags(Memory val)
        {
            m_mem = val;

        }

        Memory m_mem;

    }
}
