using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal class agentsManager
    {
        private agent theAgent = null;


        public static Type[] allAgents =
        {
            typeof(juniorAgent)
        };


        public agent NewAgent(int type)
        {
            agent newAgent = Activator.CreateInstance(allAgents[type]) as agent;
            Dictionary<Type, int> WeaknessesDictionary = this.CreateWeaknessesDictionary(newAgent.GetSensorsCapacity());
            newAgent.SetWeaknesses(WeaknessesDictionary);
            return newAgent;
        }



        private Dictionary<Type, int> CreateWeaknessesDictionary(int agentSensorsCapacity)
        {
            Dictionary<Type, int> WeaknessesDictionary = new Dictionary<Type, int>();

            while (agentSensorsCapacity > 0)
            {
                int SensorIndex = gameManager.ran.Next(0, SensorsFactory.HowManyTypes);
                int sensorTypeCounts = gameManager.ran.Next(1 ,agentSensorsCapacity + 1);
                Type sensorType = SensorsFactory.allSensors[SensorIndex];

                WeaknessesDictionary.Add(sensorType, sensorTypeCounts);
                agentSensorsCapacity -= sensorTypeCounts;
            }
            return WeaknessesDictionary;
        }
    }
}
