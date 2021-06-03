using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercice 1
            /*
                Créer un tableau de 10 valeurs au hasard entre 1 et 100.
                Trier ce tableau du plus petit au plus grand
                puis mettre toutes les valeurs dans une chaîne de caractères
                séparées par des ; et afficher la chaîne.
             */
            int[] tableauRandom = new int[10];
            Random aleatoire = new Random();
            string chaineRandom = "";

            for (int i=0;i<tableauRandom.Length;i++)
                tableauRandom[i] = aleatoire.Next(1, 100);

            Array.Sort(tableauRandom);

            foreach (int i in tableauRandom)
                chaineRandom += i.ToString() + ";";

            Console.WriteLine(chaineRandom);

            // Exercice 2
            /*
                Écrire une fonction qui permet de calculer la factorielle d’un
                nombre de manière récursive.
                Par exemple la factorielle de 7 est : 1*2*3*4*5*6*7
                Afficher alors la factorielle de 20 (2.4329020081766E+18).
             */
            Console.Write("Entrer un nombre entier : ");
            int nbUtilisateur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La factorielle de {nbUtilisateur} est " + Factorielle(nbUtilisateur));
            Console.WriteLine($"La factorielle de {nbUtilisateur} est " + FactorielleAlt(nbUtilisateur));

            static long Factorielle(int nombre)
            {
                if (nombre == 1) return 1;
                return nombre * Factorielle(nombre - 1);
            }

            // Autre méthode <(expression booleene)>?<retour si true>:<retour si false>;
            static long FactorielleAlt(int nombre)
            {
                return (nombre > 1) ? nombre * Factorielle(nombre - 1): 1;
            }
        }
    }
}
