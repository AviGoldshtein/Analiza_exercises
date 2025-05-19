using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent_tirgul
{
    static class IntelTools
    {
        static public string EncryptMessage(string msg)
        {
            string reversedMsg = "";
            foreach (char c in msg)
            {
                reversedMsg = c + reversedMsg;
            }
            return reversedMsg;
        }
        
        static public void LogTransmission(string agentName, string message)
        {
            Console.WriteLine($"{agentName} sent encrypted message: {message}");
        }



    }
}
