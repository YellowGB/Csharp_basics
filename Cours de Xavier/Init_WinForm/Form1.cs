using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Init_WinForm
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Horloge();
        }

        private void CmdFermer_Click(object sender, EventArgs e)
        {
            // ActiveForm = Le formulaire actuellement affiché (si c'est le seul formulaire, ferme aussi le programme)
            Form.ActiveForm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Horloge();
        }

        public void Horloge()
        {
            // ceci est une méthode/fonction sans retour, autrement appelée une procédure
            string monHeure = DateTime.Now.ToString("HH:mm:ss");
            LblTime.Text = monHeure;
        }
    }
}
