using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesRobots
{
    public class Robot
    {
        const int MAX_X = 10000;
        const int MAX_Y = 20000;

        #region Propriétés
        private int _taille;
        private int _largeur;
        private int _coordonneeX;
        private int _coordonneeY;
        private string _nom;
        #endregion

        public Robot(string nom) : this(nom, 0, 0)
        {

        }

        public Robot(string nom, int taille) : this(nom, taille, 0)
        {

        }

        public Robot(string nom, int taille, int largeur) : this(nom, taille, largeur, 0, 0)
        {
        }

        public Robot(string nom, int taille, int largeur, int coordX, int coordY)
        {
            this.Taille = taille;
            this._largeur = largeur;
            this.CoordonneeX = coordX;
            this.CoordonneeY = coordY;
            this.Nom = nom;
        }

        // A montrer =>  ne fonctionne pas car ?
        //public MonRobot(int coordX, int coordY)
        //{

        //}

        /// <summary>
        /// Se déplacer sur la carte 2D
        /// </summary>
        /// <param name="deplacementX"></param>
        /// <param name="deplacementY"></param>
        public virtual void SeDeplacer(int deplacementX, int deplacementY)
        {
            this.CoordonneeX = deplacementX;
            this.CoordonneeY = deplacementY;

            this.VerifierCoordonnees();
        }

        public void AfficherPositionnement()
        {
            Console.WriteLine(string.Format("{2} //>  Coordonnées : x({0}), y({1})", this.CoordonneeX, this.CoordonneeY, this.Nom));
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
        public string Nom { get => this._nom; set => this._nom = value; }
        protected int CoordonneeX { get => this._coordonneeX; set => this._coordonneeX = value; }
        protected int CoordonneeY { get => this._coordonneeY; set => this._coordonneeY = value; }
    }
}
