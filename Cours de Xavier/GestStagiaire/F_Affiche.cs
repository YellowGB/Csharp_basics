using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestStagiaire
{
    public partial class F_Affiche : Form
    {
        public F_Affiche()
        {
            InitializeComponent();
        }

        private void F_Affiche_Load(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source=localhost;Initial Catalog=Stagiaires;Integrated Security=SSPI";
            try
            {
                // Connexion à la base
                SqlConnection maConnexion = new SqlConnection(chaineDeConnexion);
                maConnexion.Open();
                //MessageBox.Show("MaConnexion ouverte.");

                SqlCommand commande = new SqlCommand();
                string SqlQuery = "SELECT * FROM TStagiaire WHERE Id_Stagiaire=16477";

                commande.Connection = maConnexion;
                commande.CommandText = SqlQuery;
                SqlDataReader reader = commande.ExecuteReader();
                reader.Read(); // lire la ligne en cours et passer à la suivante

                TxtId.Text = Convert.ToString(reader["Id_Stagiaire"]);
                TxtNom.Text = (string)reader["NomStagiaire"];
                TxtPrenom.Text = (string)reader["PrenomStagiaire"];
                TxtSection.Text = (string)reader["Section"];
                DtPNaissance.Value = (DateTime)reader["DateNaissance"]; // un dtp n'a pas de Text mais une Value

                maConnexion.Close();
            }
            catch (Exception d) // d = variable qui va stocker l'exception renvoyée
            {
                MessageBox.Show("Erreur recontrée : " + d.Message);
            }
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}