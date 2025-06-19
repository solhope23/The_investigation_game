using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Datatypes.Scalar.Types;

namespace The_investigation_game
{
    internal static class ConsoleWriter
    {
        public static void GetUsername()
        {
            Console.WriteLine("Welcome.\n" +
                              "Please enter a username.\n" +
                              "Or enter Exit to return.");
        }

        public static void AllSensorSelectionOptions()
        {
            Console.WriteLine("These are the selectable sensors.");

            for (int i = 0; i < SensorsFactory.allSensors.Length; i++)
            {
                Console.WriteLine($"For Sensor - {SensorsFactory.allSensors[i].Name} Enter {i}");
            }
        }

        public static void HowManyScored(int some, int of)
        {
            Console.WriteLine($"You scored {some}/{of}.");
        }

        public static void DalConnectionProblem()
        {
            Console.WriteLine("There was a connection problem.You can play without saving data.");
        }
    }
}

