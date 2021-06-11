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
    public partial class F_Choix : Form
    {
        public F_Choix()
        {
            InitializeComponent();
        }

        private void CbStagiaire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_Choix_Load(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source=localhost;Initial Catalog=Stagiaires;Integrated Security=SSPI";
            try
            {
                // Connexion à la base
                SqlConnection maConnexion = new SqlConnection(chaineDeConnexion);
                maConnexion.Open();
                //MessageBox.Show("MaConnexion ouverte.");

                SqlCommand commande = new SqlCommand();
                string SqlQuery = "SELECT Id_Stagiaire,NomStagiaire FROM TStagiaire";

                commande.Connection = maConnexion;
                commande.CommandText = SqlQuery;
                SqlDataReader reader = commande.ExecuteReader();
                while (reader.Read())
                {
                    CbStagiaire.Items.Add(reader["Id_Stagiaire"] + " | " + reader["NomStagiaire"]);
                }

                maConnexion.Close();
            }
            catch (Exception d) // d = variable qui va stocker l'exception renvoyée
            {
                MessageBox.Show("Erreur recontrée : " + d.Message);
            }
        }
    }
}
