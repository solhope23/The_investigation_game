using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal class interrogationRoom
    {
        private player[] _players;
        private agent[] _agents;
        private sensor[][] _playerSensorChoices;

        public player GetPlayer(int PlayerNumber)
        {
            return this._players[PlayerNumber];
        }



        public void SetAgents(agent Agent, int Index)
        {
            this._agents[Index] = Agent;
        }
    }








}
