using System;

namespace Vehicules
{
    class Program
    {
            public class Vehicule
        {
            // propriétés
            protected string couleur;
            protected int poids;

            // constructeur
            public Vehicule(string couleurVehicule, int poidsVehicule)
            {
                couleur = couleurVehicule;
                poids = poidsVehicule;
            }

            // accesseurs
            public string Couleur
            {
                get { return couleur; }
                set { couleur = value; }
            }

            public int Poids
            {
                get { return poids; }
                set { poids = value; }
            }

            // méthodes
            public void Rouler()
            {
                Console.WriteLine("Le véhicule roule.");
            }
            // si on ajoute plusieurs personnes du même poids, paramètre optionnel
            public void AjouterPersonne(int poidsPersonne, byte nombrePersonnes = 1)
            {
                poids += poidsPersonne * nombrePersonnes;
            }
        }
        public class DeuxRoues : Vehicule
        {
            // propriétés
            private int cylindree;

            // constructeur
            public DeuxRoues(string couleur, int poids, int cylindreeVehicule) : base(couleur, poids)
            {
                cylindree = cylindreeVehicule;
            }

            // accesseur
            public int Cylindree
            {
                get { return cylindree; }
                set { cylindree = value; }
            }

            // méthode
            public void MettreEssence(int quantiteLitre)
            {
                poids += quantiteLitre;
            }
        }
        public class QuatreRoues:Vehicule
        {
            // propriétés
            private byte nombrePortes;

            // constructeur
            public QuatreRoues(string couleur, int poids, byte nombrePortesVehicule = 5) : base(couleur, poids)
            {
                nombrePortes = nombrePortesVehicule;
            }
            
            // accesseur
            public byte NombrePortes
            {
                get { return nombrePortes; }
                set { nombrePortes = value; }
            }

            // méthode
            public void Repeindre(string couleurPeinture)
            {
                couleur = couleurPeinture;
                Console.WriteLine($"Véhicule repeint en {couleurPeinture}.");
            }
        }
        public class Voiture : QuatreRoues
        {
            // propriétés
            private byte pneusNeige;

            // constructeur
            public Voiture(string couleur, int poids, byte nombrePortes = 5, byte nombrePneusNeige = 0):base(couleur, poids, nombrePortes)
            {
                pneusNeige = nombrePneusNeige;
            }

            // accesseur
            public byte PneusNeige
            {
                get { return pneusNeige; }
                set { pneusNeige = value; }
            }

            // méthodes
            public void AjouterPneuNeige(byte nombre)
            {
                pneusNeige += nombre;
                Math.Clamp(pneusNeige, (byte)0, (byte)4);
            }
            public void EnleverPneuNeige(byte nombre)
            {
                pneusNeige -= nombre;
                Math.Clamp(pneusNeige, (byte)0, (byte)4);
            }
        }
        public class Camion : QuatreRoues
        {
            // propriétés
            int longueur;

            // constructeur
            public Camion(string couleur, int poids, byte nombrePortes, int longueurCamion) : base(couleur, poids, nombrePortes)
            {
                longueur = longueurCamion;
            }

            // accesseur
            public int Longueur
            {
                get { return longueur; }
            }

            // méthode
            public void AjouterRemorque(int longueurRemorque)
            {
                longueur += longueurRemorque;
            }
        }
    
        static void Main(string[] args)
        {
            Vehicule vehicule1 = new Vehicule("noir",1500);
            Console.WriteLine($"Le véhicule {vehicule1.Couleur} pèse {vehicule1.Poids}kg.");
            vehicule1.Rouler();
            vehicule1.AjouterPersonne(70);
            Console.WriteLine($"Le véhicule {vehicule1.Couleur} pèse désormais {vehicule1.Poids}kg.");

            // Créer une voiture verte de 1400 kg.
            Voiture voiture1 = new Voiture("verte", 1400);
            // Ajouter deux personnes de 65 kg chacune.
            // Afficher dans la console sa couleur et son nouveau poids.
            voiture1.AjouterPersonne(65, 2);
            Console.WriteLine($"La voiture {voiture1.Couleur} pèse {voiture1.Poids}kg.");
            // Repeindre la voiture en rouge et ajouter deux pneus neige.
            voiture1.Repeindre("rouge");
            voiture1.AjouterPneuNeige(2);
            // Afficher dans la console sa couleur et son nombre de pneus neige.
            Console.WriteLine($"La voiture repeinte en {voiture1.Couleur} possède {voiture1.PneusNeige} pneus neige.");

            // Créer un objet Deux_roues noir de 120 kg.
            DeuxRoues moto = new DeuxRoues("noir",120,2);
            // Ajouter une personne de 80 kg.
            moto.AjouterPersonne(80);
            // Mettre 20 litres d’essence.
            moto.MettreEssence(20);
            // Afficher dans la console la couleur et le poids du deux roues.
            Console.WriteLine($"La moto de couleur {moto.Couleur} pèse {moto.Poids}kg.");

            // Créer un camion bleu de 10000 kg d’une longueur de 10 mètres avec 2 portes.
            Camion camion1 = new Camion("bleu", 10000, 2, 10);
            // Lui ajouter une remorque de 5 mètres et une personne de 80 kg.
            camion1.AjouterRemorque(5);
            camion1.AjouterPersonne(80);
            // Afficher dans la console sa couleur, son poids, sa longueur et son nombre de portes.
            Console.WriteLine($"Le camion {camion1.Couleur}, pesant {camion1.Poids}kg et mesurant {camion1.Longueur}m de long a {camion1.NombrePortes} portes.");
        }
    }
}
