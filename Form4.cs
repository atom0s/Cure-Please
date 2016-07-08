using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurePlease
{

    using EliteMMO.API;
    using static Form1;

    public partial class Form4 : Form
    {

        private Form1 f1;

        public Form4(Form1 f)
        {
            InitializeComponent();

            f1 = f;

            if (f1.setinstance2.Enabled == true)
            {
                _ELITEAPIPL = new EliteAPI((int)f1.processids.SelectedItem);
                chatlog_box.Text = "Chatlog for character: " + _ELITEAPIPL.Player.Name;


            }

            else
            {
                chatlog_box.Text = "No character was selected as the power leveler, close this window and select one.";
            }

        }

        private void CloseChatLog_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
