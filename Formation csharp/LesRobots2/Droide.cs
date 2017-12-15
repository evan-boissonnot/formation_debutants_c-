using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesRobots
{
    public class Droide : Robot
    {
        // Ici, on est obligé de créer un constructeur, car des paramètres dans le parent
        public Droide(string nom) : base(nom)
        {

        }

        public Droide(string nom, int x, int y, string nomArme) : base(nom)
        {
            this.CoordonneeX = x;
            this.CoordonneeY = y;
            this.Arme = nomArme;
        }

        public override void SeDeplacer(int deplacementX, int deplacementY)
        {
            const int COEFFICIENT = 2;

            this.CoordonneeX = deplacementX * COEFFICIENT;
            this.CoordonneeY = deplacementY * COEFFICIENT;

            this.VerifierCoordonnees();
        }

        public override string ToString()
        {
            return this.Nom;
        }

        public string Arme { get; set; }
    }
}
