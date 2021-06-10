using System;

/*
    Trois rois, Melik, Casik et Balik, sont assis autour d'une table, débattant de qui a le meilleur royaume
    d'entre les trois. Chaque roi a un assortiment de provinces, de duchés et de domaines. Ensemble, ils se
    sont mis d'accord sur un système à points pour les aider à juger lequel est le plus grand : chaque domaine
    rapporte 1 point, chaque duché 3 points et chaque province vaut 6 points.
    Il ne leur reste plus qu'à trouver un programme qui leur permettra d'entrer leurs possessions actuelles et
    de calculer le nombre total de points.

    Objectifs :
    - Créer un programme qui permette à l'utilisateur d'entrer combien de provinces, de duchés et de domaines il possède.
    - Faire la somme des points pour obtenir le score total, en donnant 1 point  par domaine, 3 par duché et 6 par province.
    - Afficher le nombre total de points de l'utilisateur.
*/

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            int provinces, duches, domaines, score;

            Console.Write("Merci d'entrer le nombre de provinces que vous possédez : ");
            provinces = Convert.ToInt32(Console.ReadLine());

            Console.Write("Merci d'entrer le nombre de duchés que vous possédez : ");
            duches = Convert.ToInt32(Console.ReadLine());

            Console.Write("Merci d'entrer le nombre de domaines que vous possédez : ");
            domaines = Convert.ToInt32(Console.ReadLine());

            score = provinces * 6 + duches * 3 + domaines;

            Console.WriteLine($"Votre score total est {score}.");
        }
    }
}