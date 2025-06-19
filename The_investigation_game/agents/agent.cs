using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal abstract class agent
    {
        protected int _SensorsCapacity;

        protected Dictionary<Type, int> _weaknesses;

        protected sensor[] _attached;

        protected Dictionary<Type, int> _NewWeaknessesDictionary;


        public agent(int sensorsCapacity)
        {
            this._SensorsCapacity = sensorsCapacity;
            this._attached = new sensor[this._SensorsCapacity];
           
        }

        public bool Comparison(Type SensorType)
        {
            if ((this._NewWeaknessesDictionary.ContainsKey(SensorType) && (this._NewWeaknessesDictionary[SensorType] > 0)))
            {
                this._NewWeaknessesDictionary[SensorType] -= 1;
                return true;
            }
            return false;
        }

        public int GetSensorsCapacity()
        {
            return this._SensorsCapacity;
        }

        public void SetWeaknesses(Dictionary<Type, int> WeaknessesDictionary)
        {
            this._weaknesses = WeaknessesDictionary;
            this._NewWeaknessesDictionary = new Dictionary<Type, int>(this._weaknesses);
        }
    }
}
