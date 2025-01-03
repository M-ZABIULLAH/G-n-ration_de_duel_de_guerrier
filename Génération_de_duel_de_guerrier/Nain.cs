using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_de_génération_de_duel_de_guerrier
{

    internal class Nain : Guerrier

    {
        private bool _armureLourde;

        // Constructor
        public Nain(string nom, int pointsDeVie, int nbDesAttaque, bool armureLourde)
            : base(nom, pointsDeVie, nbDesAttaque)
        {
            _armureLourde = armureLourde;
        }

        // Redefinition de SubirDegats
        public override void SubirDegats(int degats)
        {
            if (_armureLourde)
            {

                degats /= 2;
            }
            base.SubirDegats(degats);

        }

        // AfficherInfos supplémentaire
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Armure Lourde : {(_armureLourde ? "Activée" : "Désactivée")}");
        }
    }
}

