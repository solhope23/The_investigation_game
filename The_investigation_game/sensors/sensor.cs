using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal abstract class sensor
    {
        protected agent _myAgent;


        public virtual bool ActivateThisSensor()
        {
            Type myType = this.GetType();

            return _myAgent.Comparison(myType);
        }

        public void SetMyAgent(agent MyAgent)
        {
            this._myAgent = MyAgent;
        }

    }
}


