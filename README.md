Description du projet
Le projet Duel de Guerriers est un simulateur de combat simple entre des guerriers, développé en langage C#.

Caractéristiques du projet
Guerriers personnalisés :

Les guerriers ont un nom, des points de vie (HP) et un nombre de dés d’attaque.

Types de guerriers :

Nain : Dispose d’une armure lourde qui réduit les dégâts subis.
Elfe : Inflige toujours un minimum de dégâts lors de chaque attaque.
Duel dynamique :

Chaque guerrier peut attaquer son adversaire et lui infliger des dégâts.
Le duel continue jusqu’à ce qu’un des guerriers soit vaincu.

Structure des fichiers
Guerrier.cs
 Définit la classe de base Guerrier, avec des propriétés générales et des fonctionnalités comme attaquer et subir des dégâts.
Nain.cs
 Définit la classe Nain, qui hérite de Guerrier et possède des capacités spécifiques pour réduire les dégâts grâce à une armure lourde.
Elfe.cs
 Définit la classe Elfe, qui hérite de Guerrier et garantit un minimum de dégâts lors de chaque attaque.
Program.cs
 Contient le point d’entrée du programme pour exécuter les duels entre les guerriers.
