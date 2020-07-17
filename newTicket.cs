using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticktr
{
    public partial class newTicket : Form
    {
        public newTicket()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength !=0 && richTextBox1.TextLength !=0)
            {
            }
            else
            {
                MessageBox.Show("Both title and content must have a length greater than 0.", "Length error.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void newTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text != "" || richTextBox1.Text !="")
            {

                if (MessageBox.Show("You have a unsaved ticket, are you sure you would like to exit ticktr?","Are you sure?", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    publicItems.newOpen = false;
                    GC.Collect();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                publicItems.newOpen = false;
                GC.Collect();
            }
        }
    }
}
