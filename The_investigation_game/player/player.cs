using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal class player
    {
        private string _username;
        private int _playerLevel;

        public player(string username, int playerLevel)
        {
            this._username = username;
            this._playerLevel = playerLevel;
        }

        public int GetPlayerLevel()
        {
            return this._playerLevel;
        }




    }
}
