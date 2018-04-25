using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss6_Evenements
{
    public class StepEventArgs : EventArgs
    {
        public int FightValue;

        public Robot Fighter;
        public Robot Defender;
    }
}
