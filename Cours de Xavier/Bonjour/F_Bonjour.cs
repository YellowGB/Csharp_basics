using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonjour
{
    public partial class F_Bonjour : Form
    {
        public F_Bonjour()
        {
            InitializeComponent();
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        public void Bonjour(string langue)
        {
            timer1.Stop();
            switch (langue)
            {
                case "fr":
                    LblBonjour.Text = "Bonjour";
                    break;
                case "en":
                    LblBonjour.Text = "Hello";
                    break;
                case "de":
                    LblBonjour.Text = "Guten Tag";
                    break;
            }
            timer1.Start();
        }

        private void CmdFr_Click(object sender, EventArgs e)
        {
            Bonjour("fr");
        }

        private void CmdEn_Click(object sender, EventArgs e)
        {
            Bonjour("en");
        }

        private void CmdDe_Click(object sender, EventArgs e)
        {
            Bonjour("de");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblBonjour.Text = "";
            timer1.Stop();
        }
    }
}
