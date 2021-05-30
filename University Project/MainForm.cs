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
    /// <summary>
    /// MainForm class - the form for zoo.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Zoo/gamesave information. Main information for the chosen gamesave/zoo.
        /// </summary>
        public Zoo zoo = new Zoo("doesn't matter", DateTime.Now);

        /// <summary>
        /// Contains all the saves.
        /// </summary>
        public GameSaves gameSaves;

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
            labelTasksDone.Text = zoo.GetTasksLeft();
        }

        /// <summary>
        /// Method for one tick of the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            // Clock
            zoo.Minute++;
            if (zoo.Minute >= 60)
            {
                zoo.Hour++;
                if (zoo.Hour >= 21)
                    zoo.NextDay();
                zoo.Minute = 0;
            }

            // Animals eating
            var animalCages = zoo.GetCages();
            if (zoo.Hour % 6 == 0 && zoo.Minute == 0)
            {
                foreach(var cage in animalCages)
                {
                    foreach (var animal in cage.GetAnimals())
                    {
                        var cageFodder = cage.fodderState;
                        if (cageFodder != 0)
                        {
                            cage.fodderState = animal.Eat(cageFodder);
                            animal.IncreaseComfort();
                        }
                        else
                        {
                            labelError.Text = "Fodder low!";
                            labelError.Visible = true;
                            animal.LowerComfort();
                        }
                    }

                    // Checking for uncomfortable animals
                    var animals = cage.GetAnimals();
                    for (int i = animals.Count - 1; i > 0; i--)
                    {
                        if (animals[i].GetComfort() == AnimalComfort.Uncomfortable)
                        {
                            labelError.Text = "An animal ran away!";
                            labelError.Visible = true;
                            cage.RemoveAnimal(animals[i]);
                        }
                    }
                }
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

        /// <summary>
        /// Method for when buttonBuyCage is clicked. Adds a new cage to the zoo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            BuyCageForm bcf = new BuyCageForm();
            if(bcf.ShowDialog() == DialogResult.OK)
            {
                var choice = (bcf.choice == "Elephant") ? CageType.Elephant : CageType.Penguin;
                zoo.AddCage(this.Bounds, choice);
                zoo.Money -= 400;
            } 
        }

        /// <summary>
        /// Method for when buttonSellCage is clicked. Removes the selected cage from the zoo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellCage_Click(object sender, EventArgs e)
        {
            var zooCages = zoo.GetCages();
            for(int i = 0; i < zooCages.Count; i++)
            {
                if (zooCages[i].cageImage.fenceColor == Color.Black)
                {
                    zoo.RemoveCage(zooCages[i]);
                    zoo.Money += 200;
                }        
            } 
        }

        /// <summary>
        /// Method for when the left mouse button is clicked. Checks if any of the cages are clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            labelError.Visible = false;
            foreach(var cage in zoo.GetCages())
            {
                cage.cageImage.fenceColor = Color.Brown;
                if (cage.cageImage.Contains(e.Location))
                {
                    cage.cageImage.fenceColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Method for when the left mouse button is clicked twice. Opens a CageForm based on the selected cage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(var cage in zoo.GetCages())
            {
                if(cage.cageImage.fenceColor == Color.Black)
                {
                    CageForm cf = new CageForm(cage.cageType)
                    {
                        animalCage = cage,
                        zoo = zoo
                    };
                    cf.Show();
                    this.Hide();
                    cf.FormClosed += (s, args) => { this.Show(); timerTime.Enabled = true; };
                }
            }
        }
    }
}
