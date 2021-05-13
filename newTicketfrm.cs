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
    public partial class newTicketfrm : Form
    {
        public newTicketfrm()
        {
            InitializeComponent();
            this.AcceptButton = createBtn;
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            if (subjecttxt.TextLength !=0 && bodytxt.TextLength !=0)
            {
                ticket t = new ticket();
                t.subject = subjecttxt.Text;
                t.body = bodytxt.Text;
                t.subjectHash = cryptography.hash(subjecttxt.Text);
                t.bodyHash = cryptography.hash(bodytxt.Text);
                //
                ticket.createTicket(t);
            }
            else
            {
                MessageBox.Show("Both title and content must have a length greater than 0.", "Length error.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void newTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (subjecttxt.Text != "" || bodytxt.Text !="")
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
