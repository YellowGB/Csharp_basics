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
    public partial class FCreationStag : Form
    {
        public FCreationStag()
        {
            InitializeComponent();
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdValid_Click(object sender, EventArgs e)
        {
            /*
                Besoin de plusieurs éléments pour se connecter à une DB:
                - chaîne de connexion, propre à chaque DB (https://www.connectionstrings.com/)
                - gestion des exceptions
            */
            string chaineDeConnexion = "Data Source=localhost;Initial Catalog=Stagiaires;Integrated Security=SSPI";
            // pour un utilisateur avec des droits il faudrait ajouter : User Id=sa;Pwd=123456";
            try
            {
                // Connexion à la base
                SqlConnection maConnexion = new SqlConnection(chaineDeConnexion);
                maConnexion.Open();
                //MessageBox.Show("MaConnexion ouverte.");

                // Insertion des données avec une requête préparée (ou paramétrée)
                SqlCommand commande = maConnexion.CreateCommand();
                // Requête paramétrée (espace avant VALUES important pour que la requête fonctionne)
                // @ -> ce sont des variables/paramètres qu'on déclare
                commande.CommandText = "INSERT INTO TStagiaire(Id_Stagiaire,NomStagiaire,PrenomStagiaire,Section,DateNaissance)"+
                    " VALUES(@id,@nom,@prenom,@section,@ddn)";

                // BINDING DE PARAMETRES
                // paramètre @id
                // binding paramètre déclaré avec le champ cconcerné
                SqlParameter paramId = new SqlParameter("@id",TxtId.Text);
                // input ou output ?
                paramId.Direction = ParameterDirection.Input;
                // quel type de donnée ?
                paramId.DbType = DbType.Int32;

                // paramètre @nom
                SqlParameter paramNom = new SqlParameter("@nom", TxtNom.Text);
                paramNom.Direction = ParameterDirection.Input;
                paramNom.DbType = DbType.String;
                paramNom.Size = 30; // car varchar(30)

                // paramètre @prenom
                SqlParameter paramPrenom = new SqlParameter("@prenom", TxtPrenom.Text);
                paramPrenom.Direction = ParameterDirection.Input;
                paramPrenom.DbType = DbType.String;
                paramPrenom.Size = 20;

                // paramètre @section
                SqlParameter paramSection = new SqlParameter("@section", TxtSection.Text);
                paramSection.Direction = ParameterDirection.Input;
                paramSection.DbType = DbType.String;
                paramSection.Size = 5;

                // paramètre @section
                DateTime maDate = Convert.ToDateTime(DtPNaissance.Value);
                SqlParameter paramNaissance = new SqlParameter("@ddn", maDate);
                paramNaissance.Direction = ParameterDirection.Input;
                paramNaissance.DbType = DbType.DateTime;

                // Envoyer les paramètres dans la requête
                commande.Parameters.Add(paramId);
                commande.Parameters.Add(paramNom);
                commande.Parameters.Add(paramPrenom);
                commande.Parameters.Add(paramSection);
                commande.Parameters.Add(paramNaissance);

                // Execution de la requête paramétrée
                commande.ExecuteNonQuery(); // car nous passons par des paramètres et non une requête directe
                
                // Fermeture de la connexion SQL Server
                maConnexion.Close();
            }
            catch(Exception d) // d = variable qui va stocker l'exception renvoyée
            {
                MessageBox.Show("Erreur recontrée : " + d.Message);
            }
        }
    }
}
