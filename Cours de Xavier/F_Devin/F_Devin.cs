using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Devin
{
    public partial class F_Devin : Form
    {
        public int monTirage;
        public int nbTour = 0;
        public F_Devin()
        {
            InitializeComponent();
        }

        private void F_Devin_Load(object sender, EventArgs e)
        {
            monTirage = RandomNumber(1, 9999);
            LblRandom.Text = monTirage.ToString();
        }

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        string Resultat(string monNombre)
        {
            int monNombre2 = int.Parse(monNombre);
            string maChaine = "";

            if(monNombre2 < monTirage)
            {
                maChaine = monNombre + " est inférieur au tirage";
            } else if(monNombre2 > monTirage)
            {
                maChaine = monNombre + " est supérieur au tirage";
            } else
            {
                maChaine = "Gagné, vous avez trouvé !";
                // il n'est plus nécessaire de cliquer sur ok puisque c'est gagné
                CmdOk.Enabled = false;
                // possibilité de rejouer
                CmdInit.Enabled = true;
            }
            return maChaine;
        }
        private void CmdOk_Click(object sender, EventArgs e)
        {
            // pour le TryParse
            int n;
            // Contrôle de saisie
            if(TxtSaisie.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nombre entre 1 et 9999 !");
                TxtSaisie.Focus();
                return;
            }
            else if (!Int32.TryParse(TxtSaisie.Text, out n))
            {
                MessageBox.Show("Vous devez saisir un nombre entre 1 et 9999 !");
                TxtSaisie.Text = "";
                TxtSaisie.Focus();
                return;
            }
            // pas besoin du OR car la propriété MaxLength de TxtSaisie est de 4 chiffres
            else if (Convert.ToInt32(TxtSaisie.Text) < 1 /*|| Convert.ToInt32(TxtSaisie.Text) > 9999*/)
            {
                MessageBox.Show("Vous devez saisir un nombre entre 1 et 9999 !");
                TxtSaisie.Text = "";
                TxtSaisie.Focus();
                return;
            }

            // pas la meilleure solution pour comparer des nombres en string
            // car en comparaison de string 1120 est inférieur à 120 par exemple
            // (11 est inférieur à 12)
            //label1.Text = TxtSaisie.Text == LblRandom.Text ? "Gagné !" : "Perdu";

            nbTour++;
            switch (nbTour)
            {
                case 1:
                    label1.Text = Resultat(TxtSaisie.Text);
                    break;
                case 2:
                    label2.Text = Resultat(TxtSaisie.Text);
                    break;
                case 3:
                    label3.Text = Resultat(TxtSaisie.Text);
                    break;
                case 4:
                    label4.Text = Resultat(TxtSaisie.Text);
                    break;
                case 5:
                    label5.Text = Resultat(TxtSaisie.Text);
                    break;
                case 6:
                    label6.Text = Resultat(TxtSaisie.Text);
                    break;
                case 7:
                    label7.Text = Resultat(TxtSaisie.Text);
                    break;
                case 8:
                    label8.Text = Resultat(TxtSaisie.Text);
                    break;
                case 9:
                    label9.Text = Resultat(TxtSaisie.Text);
                    break;
                case 10:
                    label10.Text = Resultat(TxtSaisie.Text);
                    break;
                case 11:
                    label11.Text = Resultat(TxtSaisie.Text);
                    break;
                case 12:
                    label12.Text = Resultat(TxtSaisie.Text);
                    if (label12.Text != "Gagné, vous avez trouvé !")
                        label12.Text = $"Perdu, c'était {monTirage}, utilise la dychotomie !";
                    break;
            }
            TxtSaisie.Text = "";
        }

        private void CmdInit_Click(object sender, EventArgs e)
        {
            monTirage = RandomNumber(1, 9999);
            LblRandom.Text = monTirage.ToString();

            CmdInit.Enabled = false;
            CmdOk.Enabled = true;

            nbTour = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
        }
    }
}