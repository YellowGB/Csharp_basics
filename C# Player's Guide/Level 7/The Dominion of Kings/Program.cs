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

























Console.WriteLine("Combien de provinces possédez-vous ?");
int province = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Combien de duchés possédez-vous ?");
int duchy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Combien de domaines possédez-vous ?");
int estate = Convert.ToInt32(Console.ReadLine());

// La solution la plus simple reste celle ci-dessous
// int score = province * 6 + duchy * 3 + estate;

// Mais pour varier un peu on peut aussi faire ce qui suit
province    *= 6;
duchy       *= 3;

int score = estate;
score += province;
score += duchy;

Console.WriteLine("Vous avez obtenu " + score + " points !");