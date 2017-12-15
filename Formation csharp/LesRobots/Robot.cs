using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesRobots
{
    public class Robot
    {
        const int MAX_X = 50;
        const int MAX_Y = 50;

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

            this.EstVivant = true;
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
            if (this.EstVivant)
            {
                this.CoordonneeX = deplacementX;
                this.CoordonneeY = deplacementY;

                this.VerifierCoordonnees();
            }
        }

        public void AfficherPositionnement()
        {
            Console.WriteLine(string.Format("{2} //>  Coordonnées : x({0}), y({1})", this.CoordonneeX, this.CoordonneeY, this.Nom));
        }

        public void Attaquer(Robot robot)
        {
            if (robot.CoordonneeX == this.CoordonneeX &&
               robot.CoordonneeY == this.CoordonneeY &&
               this.EstVivant)
            {

                //Console.WriteLine(string.Format("Une attaque a lieu entre {0} et {1}", this.Nom, robot.Nom));

                Random rand = new Random();

                int valeur = rand.Next(1, 10);

                this.EstVivant = valeur > 5;
                robot.EstVivant = !this.EstVivant;

                string nomMort = robot.Nom;
                if (!this.EstVivant)
                    nomMort = this.Nom;

                //Console.WriteLine(string.Format("Le robot {0} est mort ...", nomMort));
            }
        }

        public bool EstAuBonEndroit(int x, int y)
        {
            return this.CoordonneeX == x && this.CoordonneeY == y;
        }

        public bool EstAuBonEndroit(Robot robot)
        {
            return this.EstAuBonEndroit(robot.CoordonneeX, robot.CoordonneeY);
        }

        protected void VerifierCoordonnees()
        {
            this.VerifierCoordonnees(ref this._coordonneeX, MAX_X);
            this.VerifierCoordonnees(ref this._coordonneeY, MAX_Y);
        }

        private void VerifierCoordonnees(ref int valeur, int constante)
        {
            if (valeur >= constante)
                valeur = 1;
        }

        public int Taille { get => this._taille; set => this._taille = value; }
        public string Nom { get => this._nom; set => this._nom = value; }
        protected int CoordonneeX { get => this._coordonneeX; set => this._coordonneeX = value; }
        protected int CoordonneeY { get => this._coordonneeY; set => this._coordonneeY = value; }

        public bool EstVivant { get; set; }
    }
}
