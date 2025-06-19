using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal class PulseSensor : sensor
    {
        private int _BreakCount = 3;

        public override bool ActivateThisSensor()
        {
            if (this._BreakCount > 0)
            {
                Type myType = this.GetType();
                this._BreakCount -= 1;
                return _myAgent.Comparison(myType);
            }
            Console.WriteLine("PulseSensor is broken");
            throw new InvalidOperationException("PulseSensor is broken");
        }
    }
}
