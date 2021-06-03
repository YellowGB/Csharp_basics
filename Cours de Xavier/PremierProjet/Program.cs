﻿using System;

namespace PremierProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // opérateur ternaire
            //<(expression booleene)>?<retour si true>:<retour si false>;

            // pattern
            object x = 6;
            // Motifs constants
            if (x is 4) Console.WriteLine("x is 4");
            if (x is 6) Console.WriteLine("x is 6");
            // Motifs de type
            if (x is string s) Console.WriteLine("x is string s");
            if (x is int i) Console.WriteLine("x is int i");
            // Motifs d'assignation
            if (x is var v) Console.WriteLine("x is var v");

            // Fonction
            /*<modificateur d'accès><type retour><NomFonction>([paramètre1],[paramètre2],...)
             * si on met une valeur par défaut à un paramètre, elle devient facultative lors de l'appel
             * par exemple [paramètre2=0.2], par défaut la méthode utilisera cette valeur, et elle changera uniquement
             * si l'utilisateur rentre quelque chose dans ce paramètre
                {
                    traitements
                    return <valeur>;
                }
             */
            Console.WriteLine("Le capitaine a " + AgeDuCapitaine());

            // Classe random
            Random aleatoire = new Random();
            int monTirage = aleatoire.Next(1, 30);
            Console.WriteLine(monTirage);

            // Fonctions de chaînes de caractères (string, char), classe String
            string maChaine = "Bonjour les gars.";
            // longueur de la chaîne
            int longueurChaine = maChaine.Length;
            Console.WriteLine("La longueur de la chaîne est : " + longueurChaine);
            // extraction dans la chaîne
            string extrait1 = maChaine.Substring(12);
            string extrait2 = maChaine.Substring(0, 4);
            Console.WriteLine(extrait1);
            Console.WriteLine(extrait2);
            // recherche d'index de chaîne
            int monIndex1 = maChaine.IndexOf("gars");
            int monIndex2 = maChaine.LastIndexOf("r");
            Console.WriteLine(monIndex1);
            Console.WriteLine(monIndex2);
            Console.WriteLine(maChaine.ToUpper());
            Console.WriteLine(maChaine.ToLower());
            // enlever des caractères
            maChaine = "              Salut les GARS              ";
            Console.WriteLine(maChaine);
            Console.WriteLine(maChaine.Trim());
            maChaine = "Salut les gars!!!!!!!!!";
            Console.WriteLine(maChaine);
            Console.WriteLine(maChaine.TrimEnd('!'));
            maChaine = "Salut";
            Console.WriteLine(maChaine.PadRight(20, 'x'));
            string maChaine2 = " à tous";
            Console.WriteLine(maChaine + maChaine2);
            // vérifier un contenu dans la chaîne
            if (maChaine.Contains("al"))
                Console.WriteLine("oui");
            else Console.WriteLine("non");
            // transformation d'une chaîne en tableau sur séparateur
            string maListe = "Eric,Thierry,Coralie,Paul,Chantale";
            string[] tabPrenom = maListe.Split(',');
            Console.WriteLine(tabPrenom[3]);

            // Fonctions de la classe Array
            int longueur = tabPrenom.Length;
            Console.WriteLine(longueur);

            int nbDimensions = tabPrenom.Rank;
            // dans le cas d'un tableau multidimensionnel :
            long nbElementTotalDim = tabPrenom.LongLength; // retourne nécessairement un long
            // synchro
            lock (tabPrenom.SyncRoot) ;

            // Quelques méthodes Array
            int premier = tabPrenom.GetLowerBound(0); // 0 car le tableau tabPrenom n'a qu'une seule dimension,
            int dernier = tabPrenom.GetUpperBound(0); // donc index de ligne N° 0
            Console.WriteLine($"Elements contenus de l'index : {premier} à {dernier}");

            // Array.SetValue(index,index,....)
            // monTableau[1][2]
            string[,,] monTableau = new string[5, 5, 5]; // tableau à 3 dimensions
            monTableau.SetValue("MaValeur",2,3,4);
            Console.WriteLine("MaValeur = {0}", monTableau.GetValue(2,3,4));
            // fonction de tri
            Array.Sort(tabPrenom);
            for(int index = 0;index<tabPrenom.Length;index++)
            {
                Console.WriteLine(tabPrenom[index]);
            }

            // Array.Clear(leTableau,int32,int32)
            // syntaxe : static void Clear(tabPrenom)
            Array.Clear(tabPrenom, 2, 2);
            Console.WriteLine(tabPrenom[2]);
            Console.WriteLine(tabPrenom[1]);
        }
        public static int AgeDuCapitaine()
        {
            int ageCapitaine = 25;
            return ageCapitaine;
        }
    }
}
