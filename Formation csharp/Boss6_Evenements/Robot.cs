using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss6_Evenements
{
    public class Robot
    {
        public event EventHandler<WinerEventArgs> Winner;

        public event EventHandler StartingFight;

        public event EventHandler<StepEventArgs> Fighting;

        private int _lifePoints = 100;

        public Robot(string name)
        {
            this.Name = name;
        }

        public void Kill(Robot robot)
        {
            Robot winer = this;

            StartingFight?.Invoke(this, new EventArgs());

            while ((robot.IsAlive && this.IsAlive))
            {
                this.Attack(robot);
                robot.Attack(this);
            }

            if (robot.IsAlive)
                winer = robot;

            Winner?.Invoke(winer, new WinerEventArgs() { Winer = winer });
        }

        private void Attack(Robot rob)
        {
            Random rand = new Random();
            int max = rand.Next(20, 50);
            int val = rand.Next(0, max);

            rob.LifePoints = (rob.LifePoints - val);
            System.Threading.Thread.Sleep(200);

            Fighting?.Invoke(this, new StepEventArgs() { FightValue = val, Defender = rob, Fighter = this });
        }

        public int LifePoints
        {
            get
            {
                return _lifePoints;
            }
            set
            {
                _lifePoints = value;
                if (_lifePoints < 0)
                    _lifePoints = 0;
            }
        }

        public bool IsAlive
        {
            get
            {
                return (this._lifePoints > 0);
            }
        }

        public string Name
        {
            get; set;
        }
    }
}
