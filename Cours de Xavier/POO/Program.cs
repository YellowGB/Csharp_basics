using System;

namespace POO
{
    public class Animal
    {
        // propriétés
        private string couleur;
        private int poids;
        private static int s_compteur;

        // constructeur
        public Animal(string couleurAniaml, int poidsAnimal)
        {
            couleur = couleurAniaml;
            poids = poidsAnimal;
            s_compteur++;
        }

        // accesseur
        public static int Compteur
        {
            get { return s_compteur; }
        }
        public int Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        // methodes
        public void Manger(Animal animalMange)
        {
            poids += animalMange.poids;
            animalMange.poids = 0;
            animalMange.couleur = "";
            Console.WriteLine("RIP snif");
        }
        public void SeDeplacer(int km)
        {
            Console.WriteLine($"L'animal se déplace de {km}km !");
            poids -= km;
        }
    }
    
    // création d'une classe dérivée de Animal
    public class Poisson : Animal
    {
        private bool vivant_en_mer;

        // constructeur (d'une classe dérivée)
        public Poisson(string couleur, int poids, bool Vivant_en_mer) : base(couleur, poids)
        {
            vivant_en_mer = Vivant_en_mer;
        }

        // accesseurs
        public bool Vivant_En_Mer
        {
            get { return vivant_en_mer; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Animal poisson;
            poisson = new Animal();
            poisson.Poids = 10;
            poisson.Couleur = "Bleu";
            */

            Animal poisson1;
            Animal chat1;
            poisson1 = new Animal("bleu", 8);
            chat1 = new Animal("Noir", 13);
            Console.WriteLine("Mon poisson est  : " + poisson1.Couleur);
            Console.WriteLine("Nombre d'animaux créés : " + Animal.Compteur);
            //poisson1.SeDeplacer();
            Console.WriteLine("Le poids du chat est : " + chat1.Poids);
            chat1.Manger(poisson1);
            Console.WriteLine("Le chat a bien mangé !");
            Console.WriteLine($"Le poids du poisson est maintenant : {poisson1.Poids}kg, c'est pas beaucoup...");
            Console.WriteLine($"Le poids du chat est maintenant : {chat1.Poids}kg.\nQuel gros !");

            //Le chat se déplace et perd 2 kg
            chat1.SeDeplacer(18);
            //chat1.Poids -= 2;
            if (chat1.Poids > 13)
            {
                Console.WriteLine($"Le chat pèse maintenant : {chat1.Poids}kg, bon va falloir se bouger encore un peu...");
            }
            else
            {
                Console.WriteLine($"Le chat pèse maintenant: {chat1.Poids}kg, il est temps de manger un autre poisson !");
            }
            

            // declaration des instances de classes
            Poisson poisson2;
            Animal chat2;
            poisson2 = new Poisson("bleu", 8, true);
            Console.WriteLine(poisson2.Couleur);
            Console.WriteLine(poisson2.Poids);
            Console.WriteLine(poisson2.Vivant_En_Mer);
        }
    }
}
