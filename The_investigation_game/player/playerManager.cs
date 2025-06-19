using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace The_investigation_game
{
    internal class playerManager
    {
        private DAL DAL = new DAL();

        public player NewPlayer(string username)
        {
            try
            {
                string[] playerData = this.DAL.GetPlayerByUserName(username);
                return new player(playerData[0], int.Parse(playerData[1]));
            }
            catch (MySqlException)
            {
                return this.OfflineGame();
            }
            catch (InvalidOperationException)
            {
                try
                {
                    this.DAL.InsertNewPlayers(username);
                    return new player(username, 0);
                }
                catch (MySqlException)
                {
                    return this.OfflineGame();
                }
            }
        }


        private player OfflineGame()
        {
            ConsoleWriter.DalConnectionProblem();
            return new player(null, 0);
        }
    }
}
