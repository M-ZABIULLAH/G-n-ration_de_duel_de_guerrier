using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_de_génération_de_duel_de_guerrier
{

    internal class Elfe : Guerrier

    {
        // Constructor
        public Elfe(string nom, int pointsDeVie, int nbDesAttaque)
            : base(nom, pointsDeVie, nbDesAttaque)
        {
        }


        public override int Attaquer()
        {
            int degats = base.Attaquer();
            return Math.Max(degats, NbDesAttaque);


        }
    }
}

