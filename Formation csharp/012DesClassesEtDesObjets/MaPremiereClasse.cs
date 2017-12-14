using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012DesClassesEtDesObjets
{
    public class MonRobot
    {
        const int MAX_X = 10;
        const int MAX_Y = 20;

        private int _taille;
        private int _largeur;
        private int _coordonneeX;
        private int _coordonneeY;

        public MonRobot() : this(0, 0)
        {

        }

        public MonRobot(int taille) : this(taille, 0)
        {

        }

        public MonRobot(int taille, int largeur) 
        {
            this.Taille = taille;
            this._largeur = largeur;
        }

        public void SeDeplacer(int deplacementX, int deplacementY)
        {
            this._coordonneeX += deplacementX;
            this._coordonneeY += deplacementY;

            this.VerifierCoordonnees();

            Console.WriteLine(string.Format("Nouvelles coordonnées : x({0}), y({1})", this._coordonneeX, this._coordonneeY));
        }

        private void VerifierCoordonnees()
        {
            this.VerifierCoordonnees(ref this._coordonneeX, MAX_X);
            this.VerifierCoordonnees(ref this._coordonneeY, MAX_Y);
        }

        private void VerifierCoordonnees(ref int valeur, int constante)
        {
            if (valeur >= constante)
                valeur = constante;
        }

        public int Taille { get => this._taille; set => this._taille = value; }
    }
}
