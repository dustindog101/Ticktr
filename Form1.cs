using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Ticktr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!publicItems.newOpen)
            {
                var newTicket = new newTicket();
                newTicket.Show();
                publicItems.newOpen = true;
            }
            else
            {
                MessageBox.Show("New ticket form already open, please close before opening a new form.");
            }
        }
    }
}
