using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal static class SensorsFactory
    {
        public static Type[] allSensors =
        {
            typeof(AudioSensor),
            typeof(PulseSensor)
        };

        public static int HowManyTypes = allSensors.Length;

        public static void menuTypesSensors()
        {
            // צריך לחזור לזה בהמשך
            Console.WriteLine("");
        }

        public static sensor NewSensor(Type type)
        {
            return Activator.CreateInstance(type) as sensor;
        }

        public static Type GetSensorType(int index)
        {
            return allSensors[index];
        }


    }
}

