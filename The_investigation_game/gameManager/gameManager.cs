using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace The_investigation_game
{
    internal class gameManager
    {
        private playerManager PlayerManager = new playerManager();
        private interrogationRoom InterrogationRoom = new interrogationRoom();
        private agentsManager AgentsManager = new agentsManager();

        public static Random ran = new Random();



        private void StartPlayer(int numberPlayer = 0)
        {
            string username = Menu.GetUsername();
            this.PlayerManager.NewPlayer(username);
        }

       







    }
}




 
