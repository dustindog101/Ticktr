using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
namespace Ticktr
{
    class ticket
    {
        private static Dictionary<string, string> tickethashes = new Dictionary<string, string>(); // subjecthash:bodyhash
        public string subject { get; set; }
        public string subjectHash { get; set; }
        public string body { get; set; }
        public string bodyHash { get; set; }
        public static void createTicket(ticket t)
        {
            AesManaged aes = new AesManaged();
            aes.GenerateIV();
            aes.GenerateKey();
            string path = fileLocations.ticketFolder + @"\" + t.subjectHash + fileLocations.fileExtention;
            byte[] contents = cryptography.Encrypt(($"{t.subject}-{t.body}") , aes.Key , aes.IV);
            Directory.CreateDirectory(fileLocations.ticketFolder);
            Directory.CreateDirectory(fileLocations.encryptedFolder);
            tickethashes.Add(t.subjectHash, t.bodyHash);
            File.Create(path).Close();
            try
            {
                File.WriteAllBytes(path, contents);

                System.Windows.Forms.MessageBox.Show($"Ticket {t.subject} created!", "New ticket",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error creating ticket, log file created.{ex.Message}", "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public static ticket readTicket(ticket t)//to read decrypt using the key and iv then split the decrypted text by subject-body then do whatever with that
        {
            if (tickethashes.ContainsKey(t.subjectHash))
            {
                if (Directory.Exists(fileLocations.ticketFolder) && File.Exists(fileLocations.ticketFolder+@"\"+t.subjectHash+fileLocations.fileExtention))
                {
                    string[] filesplit = Encoding.UTF8.GetString(File.ReadAllBytes(fileLocations.ticketFolder + @"\" + t.subjectHash + fileLocations.fileExtention)).Split('-');
                    ticket newticket = new ticket();
                    newticket.subject = filesplit[0];
                    newticket.subjectHash = t.subjectHash;
                    newticket.body = filesplit[1];
                    return newticket;
                }
            }
            throw new Exception("Error");

        }
    }
}
