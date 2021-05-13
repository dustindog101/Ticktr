using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
namespace Ticktr
{
    class ticketCreation
    {

        public static void createTicket(string title, string content)
        {
            using (var SW = new StreamWriter(fileLocations.ticketFolder+title))
            {
                SW.AutoFlush = true;
                SW.WriteLine(content);
                SW.Close();
            }
        }
        public static void createTicket(string title, string content, string key,string IV)
        {

        }
    }
}
