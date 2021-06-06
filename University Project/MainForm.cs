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
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
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
                var cagesWithoutFodder = animalCages
                    .Where(c => c.fodderState == 0)
                    .ToList();

                cagesWithoutFodder.ForEach(c =>
                {
                    var animals = c.GetAnimals();

                    var uncomfortableAnimals = animals
                    .Where(a => a.GetComfort() == AnimalComfort.Uncomfortable)
                    .ToList();

                    uncomfortableAnimals.ForEach(ua =>
                    {
                        labelError.Text = "An animal ran away!";
                        labelError.Visible = true;
                        c.RemoveAnimal(ua);
                    });

                    animals.ForEach(a =>
                    {
                        labelError.Text = "Fodder low!";
                        labelError.Visible = true;
                        a.LowerComfort();
                    });
                });

                var cagesWithFodder = animalCages
                        .Where(c => c.fodderState != 0)
                        .ToList();

                cagesWithFodder.ForEach(c =>
                {
                    var animals = c.GetAnimals();
                    animals.ForEach(a =>
                    {
                        c.fodderState = a.Eat(c.fodderState);
                        a.IncreaseComfort();
                    });
                });
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
                cage.cageImage.UpdateScale(this.Bounds, panelUserInfo.Bounds);
                cage.cageImage.DrawCage(g);
            }
            
            // Path
            using(var brush = new SolidBrush(Color.DimGray))
            {
                g.FillRectangle(brush, 2 * (float)(this.Bounds.Width / 5), 0, (float)(this.Bounds.Width / 5) - 20,
                    this.Bounds.Height - panelUserInfo.Bounds.Height);
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
            var selectedCage = zooCages.Where(c => c.cageImage.fenceColor == Color.Black).SingleOrDefault();
            if (selectedCage != default){
                zoo.RemoveCage(selectedCage);
                zoo.Money += 200;
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
            var cages = zoo.GetCages();

            cages.ForEach(c => c.cageImage.fenceColor = Color.Brown);

            var selectedCage = cages
                .Where(c => c.cageImage.Contains(e.Location))
                .SingleOrDefault();

            if (selectedCage != default)
            {
                selectedCage.cageImage.fenceColor = Color.Black;
                labelSelectedCage.Text = selectedCage.cageType.ToString();
            }
            else
                labelSelectedCage.Text = "";
                
        }

        /// <summary>
        /// Method for when the left mouse button is clicked twice. Opens a CageForm based on the selected cage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cages = zoo.GetCages();
            var selectedCage = cages
                .Where(c => c.cageImage.fenceColor == Color.Black)
                .SingleOrDefault();

            if(selectedCage != default)
            {
                CageForm cf = new CageForm(selectedCage.cageType)
                {
                    animalCage = selectedCage,
                    zoo = zoo
                };
                cf.Size = this.Size;
                cf.Location = this.Location;
                cf.StartPosition = FormStartPosition.Manual;
                cf.Show();
                this.Hide();
                cf.FormClosed += (s, args) => { this.Show(); timerTime.Enabled = true; };
            }
        }
    }
}
