using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace SQL_connection
{
    internal class AgentDAL
    {
        private string connStr = "server=localhost;user=root;password=;database=eagleeyedb";
        private MySqlConnection _conn;

        public AgentDAL()
        {
            try
            {
                OpenConection();
                ColseConnection();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySql exeption {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"general exeption {ex.Message}");
            }
        }
        public MySqlConnection OpenConection()
        {
            if (this._conn == null)
            {
                this._conn = new MySqlConnection(this.connStr);
            }
            if (this._conn.State != System.Data.ConnectionState.Open)
            {
                this._conn.Open();
                Console.WriteLine("connected successful");
            }
            return this._conn;
        }
        public void ColseConnection()
        {
            if (this._conn != null && this._conn.State == System.Data.ConnectionState.Open)
            {
                this._conn.Close();
                this._conn = null;
            }
        }
        public List<Agent> GetAllAgents(string WHERE = "")
        {
            List<Agent> agents = new List<Agent>();
            try
            {
                OpenConection();
                string query = "SELECT * FROM agents ";
                query += WHERE;
                using (var cmd = new MySqlCommand(query, this._conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = reader.GetInt32("id");
                        string CodeName = reader.GetString("codeName");
                        string RealName = reader.GetString("realName");
                        string Location = reader.GetString("location");
                        string Status = reader.GetString("status");
                        int MissionComplited = reader.GetInt32("missionsCompleted");
                        Agent agent = new Agent(Id, CodeName, RealName, Location, Status, MissionComplited);

                        agents.Add(agent);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: exeption-- {ex.Message}");
            }
            finally
            {
                ColseConnection();
            }
            return agents;

        }
        public void PrintAgentList(List<Agent> agents)
        {
            foreach (Agent agent in agents)
            {
                Console.WriteLine(agent);
            }
        }
        public void AddAgent(string codeName, string realName, string location, string status, int missionsCompleted)
        {
            try
            {
                OpenConection();
                string query = $"INSERT INTO agents (codeName, realName, location, status, missionsCompleted) " +
                    $"VALUES(@codeName, @realName, @location, @status, @missionsCompleted)";

                using (var cmd = new MySqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@codeName", codeName);
                    cmd.Parameters.AddWithValue("@realName", realName);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@missionsCompleted", missionsCompleted);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("insert succedded");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Sql exeption: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"somethig went wrong {ex.Message}");
            }
            finally
            {
                ColseConnection();
            }
        }
        public void DeleteAgent(int id)
        {
            try
            {
                OpenConection();
                string query = "DELETE FROM agents WHERE id = @id";
                using (var cmd = new MySqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySqlException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                ColseConnection();
            }
        }
        public void UpdateAgentLocation(int id, string location)
        {
            try
            {
                OpenConection();
                string query = "UPDATE agents SET location = @location WHERE id = @id";
                using (var cmd = new MySqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("location", location);
                    int effected = cmd.ExecuteNonQuery();
                    if (effected > 0)
                    {
                        Console.WriteLine("update succedded");
                    }
                    else
                    {
                        Console.WriteLine("update faild");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySqlException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                ColseConnection();
            }
        }
        public List<Agent> SearchAgentsByCode(string partialCode)
        {
            return GetAllAgents($"WHERE codeName LIKE '%{partialCode}%'");
        }
        public Dictionary<string, int> CountAgentsByStatus()
        {
            Dictionary<string, int> statusN = new Dictionary<string, int>();
            try
            {
                OpenConection();
                string query = "SELECT agents.status, COUNT(*) AS count FROM agents GROUP BY status";
                using (var cmd = new MySqlCommand(query, _conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader.GetString(0);
                        int count = reader.GetInt32(1);
                        statusN[status] = count;
                        //Console.WriteLine($"{status}: {count}");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySqlException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                ColseConnection();
            }
            return statusN;
        }
        public void printDictionary(Dictionary<string, int> statusN)
        {
            foreach (var statusAndNum in statusN)
            {
                Console.WriteLine($"{statusAndNum.Key}: {statusAndNum.Value}");
            }
        }
        public void AddMissionCount(int agentId, int missionsToAdd)
        {
            try
            {
                OpenConection();
                string query = "SELECT missionsCompleted FROM agents WHERE id = @id";
                using (var cmd = new MySqlCommand(query, _conn))
                using (var reader = cmd.ExecuteReader())
                {
                    cmd.Parameters.AddWithValue("id", agentId);
                    int effected = cmd.ExecuteNonQuery();
                    int amountBefor = reader.GetInt32("missionsCompleted");

                    query = "UPDATE agents SET missionsCompleted = @missionsCompleted WHERE id = @id";
                    using (var cmd2 = new MySqlCommand(query, _conn))
                    {
                        cmd2.Parameters.AddWithValue("id", agentId);
                        cmd2.Parameters.AddWithValue("missionsCompleted", missionsToAdd + amountBefor);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySqlException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                ColseConnection();
            }
        }
        public int GetMissionsCompleted(int agentId)
        {
            int missionsCompleted;
            try
            {
                OpenConection();
                string query = "SELECT missionsCompleted FROM agents WHERE id = @id";
                using (var cmd = new MySqlCommand(query, _conn))
                using (var reader = cmd.ExecuteReader())
                {
                    cmd.Parameters.AddWithValue("id", agentId);
                    int effected = cmd.ExecuteNonQuery();
                    missionsCompleted = reader.GetInt32("missionsCompleted");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySqlException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                ColseConnection();
            }
            return missionsCompleted;
        }
    }
}
