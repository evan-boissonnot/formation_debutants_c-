using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012DesClassesEtDesObjets
{
    public class MonRobot
    {
        const int MAX_X = 10000;
        const int MAX_Y = 20000;

        private int _taille;
        private int _largeur;
        private int _coordonneeX;
        private int _coordonneeY;
        private string _nom;

        public MonRobot(string nom) : this(nom, 0, 0)
        {

        }

        public MonRobot(string nom, int taille) : this(nom, taille, 0)
        {

        }

        public MonRobot(string nom, int taille, int largeur) : this(nom, taille, largeur, 0, 0)
        {
        }

        public MonRobot(string nom, int taille, int largeur, int coordX, int coordY)
        {
            this.Taille = taille;
            this._largeur = largeur;
            this._coordonneeX = coordX;
            this._coordonneeY = coordY;
            this._nom = nom;
        }

        // A montrer =>  ne fonctionne pas car ?
        //public MonRobot(int coordX, int coordY)
        //{

        //}



        public void SeDeplacer(int deplacementX, int deplacementY)
        {
            this._coordonneeX = deplacementX;
            this._coordonneeY = deplacementY;

            this.VerifierCoordonnees();

            this.AfficherPositionnement();
        }

        public void AfficherPositionnement()
        {
            Console.WriteLine(string.Format("{2} //>  Coordonnées : x({0}), y({1})", this._coordonneeX, this._coordonneeY, this._nom));
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
