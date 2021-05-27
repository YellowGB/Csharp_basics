using System;

namespace Exercice2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicule v1 = new Voiture();
            v1.Afficher();

            Vehicule v2 = new Camion();
            v2.Afficher();
        }
    }    
    public class Vehicule
    {
        public int nombreRoues = 0;
        public void Afficher()
        {
            Console.WriteLine($"Ceci est un véhicule à {nombreRoues} roues !");
        }
    }
}