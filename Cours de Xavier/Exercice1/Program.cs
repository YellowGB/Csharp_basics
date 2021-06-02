using System;
using System.Linq;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICE 1
            /*
                Créer un tableau contenant les chiffres de 1 à 10 et un autre tableau contenant les nombres de 11 à 20.
                Ensuite, créer un autre tableau contenant la somme des deux premiers tableaux et afficher ses valeurs.
                Il faut utiliser les boucles pour créer ces tableaux.
             */
            int[] tableau1 = new int[10];
            int[] tableau2 = new int[10];
            int[] tableau3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tableau1[i] = i + 1;
                Console.Write(tableau1[i] + "|");

                tableau2[i] = i + 11;
                Console.Write(tableau2[i] +"|");

                tableau3[i] = tableau1[i] + tableau2[i];
                Console.WriteLine(tableau3[i]);
            }

            // EXERCICE 2
            /*
                Voici deux tableaux:
                - le tableau1 est composé des éléments 6,25,35 et 61
                - le tableau2 est composé des éléments 12,24 et 46
                Ecrire le code (boucles) permettant de calculer une valeur représentative
                de ces deux tableaux notée S. La valeur se calcule en multiplinat chaque valeur
                du tableau1 par celle du tableau2 et en additionnant le tout.
             */
            int[] tableau4 = new int[] { 6, 25, 35, 61 };
            int[] tableau5 = new int[] { 12,24,46 };
            int S, ii, j;
            S = ii = j = 0;

            while (ii < tableau4.Length)
            {
                while(j < tableau5.Length)
                {
                    S += tableau4[ii] * tableau5[j];
                    j++;
                }
                j = 0;
                ii++;
            }
            Console.WriteLine("-----------------");
            Console.WriteLine($"La valeur S calculée est : {S}");

            // Methode alternative
            S = 0;
            foreach (int i1 in tableau4)
                foreach (int i2 in tableau5)
                    S +=i1 * i2;

            Console.WriteLine("-----------------");
            Console.WriteLine($"La valeur S calculée est : {S}");

            // Methode avec un SUM (aucun intérêt, juste pour le challenge)
            S = 0;
            int i5 = 0;
            int[] tableau6 = new int[tableau4.Length*tableau5.Length];
            foreach (int i3 in tableau4)
                foreach (int i4 in tableau5)
                {
                    tableau6[i5] = i3 * i4;
                    i5++;
                }

            int resultat = tableau6.Sum();
            Console.WriteLine("-----------------");
            Console.WriteLine($"La valeur S calculée est : {resultat}");

        }
    }
}
