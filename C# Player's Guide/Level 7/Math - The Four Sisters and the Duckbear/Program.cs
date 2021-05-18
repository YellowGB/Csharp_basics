using System;
/*
    Quatre soeurs possèdent une ferme de chocolat et récoltent chaque jour des oeufs en chocolats
    pondus par des poules en chocolat. Mais la plupart du temps, il n'est pas possible de répartir
    de manière équitable le nombre d'oeufs entre les soeurs, et tout le monde sait qu'on ne peut pas
    couper en morceaux un oeuf en chocolat, ce serait du gâchis ! Les disputes se font de plus en
    plus fortes. Le village en a assez d'entendre les soeurs se plaindre, et Chandra, l'arbitre du
    village, est finalement parvenue à une solution qui satisfera tout le monde.
    Chacune des quatre soeurs reçoit un nombre égal d'oeufs chaque jour, et le reste est donné à
    Canidou, leur animal de compagnie.

    Objectif:
    - Créer un programme qui laisse l'utilisateur entrer le nombre d'oeufs en chocolat réclotés ce jour.
    - En utilisant / et %, calculer combien d'oeufs chaque soeur devrait recevoir et combien en reste-t-il pour Canidou.
    - Répondre à cette question : Quels sont les trois quantité d'oeufs où Canidou reçoit plus que ce que reçoit chaque soeur ?
*/
Console.WriteLine("Combien d'oeufs en chocolat récoltés aujourd'hui ?");
int eggs = Convert.ToInt32(Console.ReadLine());

int sisterShare = eggs / 4;
Console.WriteLine("Chaque soeur reçoit " + sisterShare + " oeufs");

int duckbearShare = eggs % 4;
Console.WriteLine("Il reste " + duckbearShare + " oeufs pour Duckbear.");