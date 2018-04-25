using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boss6_Evenements
{
    public partial class frmGlobal : Form
    {
        public frmGlobal()
        {
            InitializeComponent();
            this._worker.DoWork += Worker_DoWork;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Raz();
            this._worker.RunWorkerAsync();
        }

        private List<Robot> _list = new List<Robot>();

        private BindingList<FightRepresentation> _historicList = new BindingList<FightRepresentation>();

        private BackgroundWorker _worker = new BackgroundWorker();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Init();
        }

        private void Init()
        {
            this._list.Add(new Robot("droide1") { LifePoints = 100 });
            this._list.Add(new Robot("droide2") { LifePoints = 100 });

            this.dataGridView1.DataSource = this._historicList;
            this._list[0].StartingFight += new System.EventHandler(this.Robot_Starting);
            this._list[0].Winner += new EventHandler<WinerEventArgs>(this.Robot_WinnerIs);
            this._list[0].Fighting += new EventHandler<StepEventArgs>(this.Robot_Fighting);
            this._list[1].Fighting += new EventHandler<StepEventArgs>(this.Robot_Fighting);
        }

        private void Raz()
        {
            foreach (var item in this._list)
                item.LifePoints = 100;

            this._historicList.Clear();
        }

        private void Worker_DoWork(object sender, EventArgs e)
        {
            this._list[0].Kill(this._list[1]);
        }

        private void Robot_Starting(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.label1.Text = "Démarrage du combat";
            }));
        }

        private void Robot_Fighting(object sender, StepEventArgs e)
        {
            string row;
            row = string.Format(">> {0} donne un coup de {2} sur {1}", e.Fighter.Name, e.Defender.Name, e.FightValue);

            this.Invoke(new Action(() =>
            {
                this._historicList.Add(new FightRepresentation()
                {
                    Fighter = e.Fighter.Name,
                    Defender = e.Defender.Name,
                    Point = e.FightValue,
                    FighterLifePoint = e.Fighter.LifePoints,
                    DefenderLifePoint = e.Defender.LifePoints
                });
            }));
        }

        private void Robot_WinnerIs(object sender, WinerEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.label1.Text = $"Le gagnant est {e.Winer.Name}, avec {e.Winer.LifePoints} XP restants";
            }));
        }

        
    }
}
