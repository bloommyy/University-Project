using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Project
{
    public partial class MainForm : Form
    {
        public Zoo zoo = new Zoo();

        /// <summary>
        /// Constructor of MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        /// <summary>
        /// Method that re-draws the whole form.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            labelDay.Text = zoo.Day.ToString();
            labelHour.Text = zoo.Hour.ToString();
            labelMinutes.Text = zoo.Minute.ToString();
            labelMoney.Text = zoo.Money.ToString();
            DrawZoo(e.Graphics);
            labelTasksDone.Text = zoo.GetCages()
                                    .Select(cage => cage.isTaskDone)
                                    .Where(task => task == false)
                                    .Count().ToString();

        }

        /// <summary>
        /// Method for one tick of the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            zoo.Minute++;
            if (zoo.Minute == 60)
            {
                zoo.Hour++;
                if (zoo.Hour == 21)
                    zoo.NextDay();
                zoo.Minute = 0;
            }  
            Invalidate();
        }

        /// <summary>
        /// Method drawing the zoo cages.
        /// </summary>
        /// <param name="g"></param>
        public void DrawZoo(Graphics g)
        {
            zoo.Graphics = g;
            // Goes through cages and draws them.
            foreach(var cage in zoo.GetCages())
            {
                cage.cageImage.DrawCage(g);
            }
            
            // Path
            using(var brush = new SolidBrush(Color.DimGray))
            {
                g.FillRectangle(brush, 15 + 2 * (float)(this.Bounds.Width / 5), 0, (float)(this.Bounds.Width / 5) - 20, 580);
            }
        }

        private void buttonBuyCage_Click(object sender, EventArgs e)
        {
            if(zoo.Money < 400) // Checks if user has enough money
            {
                labelError.Text = "Not enough money!";
                labelError.Visible = true;
                return;
            }
            if(zoo.GetCages().Count == 2) // Checks if user already has 2 cages
            {
                labelError.Text = "Cannot buy more than 2 cages!";
                labelError.Visible = true;
                return;
            }
            zoo.AddCage(this.Bounds);
            zoo.Money -= 400;
        }

        private void buttonSellCage_Click(object sender, EventArgs e)
        {
            var zooCages = zoo.GetCages();
            for(int i = 0; i < zooCages.Count; i++)
            {
                if (zooCages[i].cageImage.Color == Color.Black)
                {
                    zoo.RemoveCage(zooCages[i]);
                    zoo.Money += 200;
                }        
            } 
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            labelError.Visible = false;
            foreach(var cage in zoo.GetCages())
            {
                cage.cageImage.Color = Color.Brown;
                if (cage.cageImage.Contains(e.Location))
                {
                    cage.cageImage.Color = Color.Black;
                }
            }
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(var cage in zoo.GetCages())
            {
                if(cage.cageImage.Color == Color.Black)
                {
                    CageForm cf = new CageForm()
                    {
                        animalCage = cage
                    };
                    
                    cf.Show();
                    this.Hide();
                    cf.FormClosed += (s, args) => this.Show();
                }
            }
        }
    }
}
