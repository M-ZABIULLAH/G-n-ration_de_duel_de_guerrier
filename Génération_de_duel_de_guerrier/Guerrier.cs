
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_de_génération_de_duel_de_guerrier
{
    internal class Guerrier
    {

        // Attributs
        private string _nom;            //: Le nom du guerrier.
        private int _pointsDeVie;      // : Les points de vie(PV) du guerrier.
        private int _nbDesAttaque;    //: Le nombre de dés d’attaque.


        // Propriétés   


        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }


        public int PointsDeVie
        {
            get { return _pointsDeVie; }
            set { _pointsDeVie = value; }
        }




        public int NbDesAttaque
        {
            get { return _nbDesAttaque; }
            set { _nbDesAttaque = value; }
        }

        public override string ToString()
        {
            return "Nom : " + _nom + " Points de vie : " + _pointsDeVie + " Nombre de dés d'attaque : "
                + _nbDesAttaque;




        }

        // Constructeur

        public Guerrier(string nom, int pointsDeVie, int nbDesAttaque)
        {
            _nom = nom;
            _pointsDeVie = pointsDeVie;
            _nbDesAttaque = nbDesAttaque;
        }

        // Méthodes


        virtual public void AfficherInfos()
        {
            Console.WriteLine("Nom : " + _nom);
            Console.WriteLine("Points de vie : " + _pointsDeVie);
            Console.WriteLine("Nombre de dés d'attaque : " + _nbDesAttaque);
        }


        virtual public int Attaquer()
        {
            Random random = new Random();
            int resultat = 0;
            for (int i = 0; i < _nbDesAttaque; i++)
            {
                resultat += random.Next(1, 5);

            }
            return resultat;
        }


        virtual public void SubirDegats(int degats)
        {
            _pointsDeVie -= degats;
        }

    }
}

