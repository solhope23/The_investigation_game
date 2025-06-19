using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal static class Menu
    {
        public static string GetUsername()
        {
            string username = "";

            ConsoleWriter.GetUsername();
            while (username == "")
            {
                username = Console.ReadLine();
            }
            return username;
        }

        public static string PlayerChoice()
        {
            string Choice;

            ConsoleWriter.AllSensorSelectionOptions();
            while (true)
            {
                Choice = Console.ReadLine();
                if (int.TryParse(Choice, out int number) && (number >= 0) && (number < SensorsFactory.allSensors.Length))
                {
                    break;
                }
                else if (Choice == "Exit")
                {
                    break;
                }
            }
            return Choice;
        }
    }
}
