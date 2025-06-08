using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_connection
{
    internal class Agent
    {
        private int Id;
        private string CodeName;
        private string RealName;
        private string Location;
        private string Status;
        private int MissionComplited;

        public Agent(int id, string CN, string RN, string location, string status, int missionComplited)
        {
            this.Id = id;
            this.CodeName = CN;
            this.RealName = RN;
            this.Location = location;
            this.Status = status;
            this.MissionComplited = missionComplited;
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                $"CodeName: {CodeName}\n" +
                $"RealName: {RealName}\n" +
                $"Location: {Location}\n" +
                $"Status: {Status}\n" +
                $"MissionComplited: {MissionComplited}\n";
        }

    }
}
