using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.CRUD;

namespace The_investigation_game
{
    internal class DAL
    {
        private string connStr;
        private MySqlConnection DataBase;

        public DAL(string server = "localhost", string username = "root", string password = "")
        {
            connStr = $"server={server};username={username};password={password};database=the_investigation_game";

            this.DataBase = new MySqlConnection(connStr);
        }


        private MySqlDataReader queryForGetPlayerByUserName(string userName)
        {
            try
            {
                string query = "SELECT * " +
                               "FROM `players` " +
                               "WHERE userName = @userName";

                MySqlCommand cmd = new MySqlCommand(query, this.DataBase);

                cmd.Parameters.AddWithValue("@userName", userName);

                MySqlDataReader Reader = cmd.ExecuteReader();

                return Reader;
            }
            catch (MySqlException ConnectionProblems)
            {
                Console.WriteLine($"err: {ConnectionProblems.Message}");
                throw;
            }
        }


        public string[] GetPlayerByUserName(string userName)
        {
            try
            {
                string[] playerDataList = new string[2];

                this.DataBase.Open();

                MySqlDataReader playerData = this.queryForGetPlayerByUserName(userName);

                playerData.Read();
                playerDataList[0] = playerData.GetString("userName");
                playerDataList[1] = playerData.GetInt32("level").ToString();

                return playerDataList;
            }
            catch (MySqlException ConnectionProblems)
            {
                Console.WriteLine($"err: {ConnectionProblems.Message}");
                throw;
            }
            catch (InvalidOperationException NotExist)
            {
                Console.WriteLine($"err: {NotExist.Message}");
                throw;
            }
            finally
            {
                this.DataBase.Close();
            }
        }

        public void InsertNewPlayers(string userName)
        {
            try
            {
                this.DataBase.Open();

                string query = "INSERT INTO players (userName) " +
                                           "VALUES (@userName)";

                MySqlCommand cmd = new MySqlCommand(query, this.DataBase);

                cmd.Parameters.AddWithValue("@userName", userName);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"err: {e.Message}");
                throw;    
            }
            finally
            {
                this.DataBase.Close();
            }
        }

        public void UpdatePlayersLevel(string userName)
        {
            try
            {
                this.DataBase.Open();

                string query = "UPDATE players " +
                               "SET level = level + 1 " +
                               "WHERE userName = @userName";

                MySqlCommand cmd = new MySqlCommand(query, this.DataBase);

                cmd.Parameters.AddWithValue("@userName", userName);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"err: {e.Message}");
                throw;
            }
            finally
            {
                this.DataBase.Close();
            }
        }
    }
}