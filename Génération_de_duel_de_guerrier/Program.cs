using Programme_de_génération_de_duel_de_guerrier;
using System;

class Program
{
    static void Main(string[] args)
    {

        Nain jean = new Nain("Jean", 40, 3, true);
        Elfe ali = new Elfe("Ali", 30, 5);

        Console.WriteLine("Début du duel entre Jean et Ali !");
        jean.AfficherInfos();
        ali.AfficherInfos();


        while (jean.PointsDeVie > 0 && ali.PointsDeVie > 0)
        {

            int degats = jean.Attaquer();
            Console.WriteLine($"{jean.Nom} attaque et inflige {degats} points de dégâts !");
            ali.SubirDegats(degats);
            ali.AfficherInfos();

            if (ali.PointsDeVie <= 0)
            {
                Console.WriteLine($"{ali.Nom} est vaincu !");
                break;
            }


            degats = ali.Attaquer();
            Console.WriteLine($"{ali.Nom} attaque et inflige {degats} points de dégâts !");
            jean.SubirDegats(degats);
            jean.AfficherInfos();

            if (jean.PointsDeVie <= 0)
            {
                Console.WriteLine($"{jean.Nom} est vaincu !");
                break;
            }
        }

        Console.WriteLine("Fin du duel !");
    }
}
