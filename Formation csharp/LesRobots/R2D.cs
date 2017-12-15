using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesRobots
{
    public class R2D : Droide
    {
        public R2D(string name, int x, int y) : base(name, x, y, "laser")
        {

        }

        public override void SeDeplacer(int deplacementX, int deplacementY)
        {
            Random rand = new Random();

            if (rand.Next(0, 2) == 1)
                base.SeDeplacer(deplacementX, deplacementY);
            else
                this.Voler();
        }

        public void Voler()
        {
            Random rand = new Random();
            int coeff = 10;

            this.CoordonneeX = rand.Next(0, 50) * coeff;
            this.CoordonneeY = rand.Next(0, 50) * coeff; // A améliorer ici, la valeur 50 doit etre une constante globale

            this.VerifierCoordonnees();
        }
    }
}
