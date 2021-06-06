using Preslav.ZooGame.ClassLibraryZoo;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Preslav.ZooGame
{
    /// <summary>
    /// The form for the cage of an animal.
    /// </summary>
    public partial class CageForm : Form
    {
        /// <summary>
        /// Contains information about the cage.
        /// </summary>
        public AnimalCage animalCage;

        /// <summary>
        /// Contains information about the zoo/gamesave.
        /// </summary>
        public Zoo zoo;

        private readonly Random rnd = new Random();
        private int actualCageHeight;

        /// <summary>
        /// Constructor for CageForm.
        /// </summary>
        public CageForm(CageType cageType)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Text = cageType + " Cage";
            buttonBuyAnimal.Text = (cageType == CageType.Elephant) ? "Buy Elephant -300" : "Buy Penguin -300";
            buttonSellAnimal.Text = (cageType == CageType.Elephant) ? "Sell Elephant +100" : "Sell Penguin +100";

        }

        /// <summary>
        /// Sets the value of the Minute, Hour, Day, Money and Task.
        /// </summary>
        public void SetLabels()
        {
            labelFodder.Text = animalCage.fodderState.ToString();
            labelDay.Text = zoo.Day.ToString();
            labelHour.Text = zoo.Hour.ToString();
            labelMinutes.Text = zoo.Minute.ToString();
            labelMoney.Text = zoo.Money.ToString();
            labelTaskDone.Text = animalCage.isTaskDone ? "Done" : "Not done";

            var animalCages = animalCage.GetAnimals();
            var selectedAnimal = animalCages
                .Where(a => a.animalImage.OutlineSize == 6)
                .SingleOrDefault();
            if (selectedAnimal != default)
                UpdateAnimalInfoLabels(selectedAnimal);
        }

        /// <summary>
        /// Redraws the form.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            actualCageHeight = this.Bounds.Height - panelUserInfo.Height; // Used for scaling later on
            SetLabels();
            DrawCage(e.Graphics);
            foreach (var animal in animalCage.GetAnimals())
            {
                animal.animalImage.ScaleAnimalSize(this.Bounds);
                animal.animalImage.DrawAnimal(e.Graphics);
            }
        }

        /// <summary>
        /// Draws bonus things on the cage such as water, fodder, etc.
        /// </summary>
        /// <param name="g"></param>
        private void DrawCage(Graphics g)
        {
            if (animalCage.cageType == CageType.Penguin)
            {
                using (var brush = new SolidBrush(Color.LightGray))
                {
                    // Bottom of pool
                    g.FillRectangle(brush, this.Bounds.Width / 2, 0, this.Bounds.Width / 2, actualCageHeight);
                }
                using (var brush = new SolidBrush(Color.FromArgb(140, Color.Cyan)))
                {
                    // Pool
                    g.FillRectangle(brush, this.Bounds.Width / 2, 0, this.Bounds.Width / 2, actualCageHeight);
                }
                using (var brush = new SolidBrush(Color.Brown))
                {
                    // Fodder holder
                    g.FillRectangle(brush, 0, 0, this.Bounds.Width / 10, actualCageHeight);
                }
                using (var brush = new SolidBrush(Color.LightSkyBlue))
                {
                    // Fodder
                    for (int i = 0; i < (int)animalCage.fodderState; i++)
                    {
                        g.FillRectangle(brush, 9, 9 + (i * actualCageHeight / 2 + i * (-20)), this.Bounds.Width / 12, actualCageHeight / 2 - 35);
                    }
                }

            }
            else if (animalCage.cageType == CageType.Elephant)
            {
                using (var brush = new SolidBrush(Color.SaddleBrown))
                {
                    // Fodder holder
                    g.FillRectangle(brush, 0, 0, this.Bounds.Width / 10, this.Bounds.Height - 100);
                }
                using (var brush = new SolidBrush(Color.Red))
                {
                    // Fodder
                    for (int i = 0; i < (int)animalCage.fodderState; i++)
                    {
                        g.FillRectangle(brush, 9, 9 + (i * actualCageHeight / 2 + i * (-20)), this.Bounds.Width / 12, actualCageHeight / 2 - 35);
                    }
                }
            }
        }

        /// <summary>
        /// Buying an animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyAnimal_Click(object sender, EventArgs e)
        {
            if (zoo.Money < 300)
            {
                labelError.Text = "Not enough money.";
                labelError.Visible = true;
                return;
            }

            if (animalCage.cageType == CageType.Elephant)
            {
                animalCage.AddAnimal(new Elephant("Harry", 17, 8600));
            }
            else if (animalCage.cageType == CageType.Penguin)
            {
                animalCage.AddAnimal(new Penguin("Pengu", 5, 20));
            }
            zoo.Money -= 300;
        }

        /// <summary>
        /// Selling a selected animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellAnimal_Click(object sender, EventArgs e)
        {
            var selectedAnimal = animalCage.GetAnimals()
                .Where(a => a.animalImage.OutlineSize == 6)
                .Single();
            animalCage.RemoveAnimal(selectedAnimal);
            UpdateAnimalInfoLabels(null);
        }

        /// <summary>
        /// Moves the animals' position on every tick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMove_Tick(object sender, EventArgs e)
        {
            foreach (var animal in animalCage.GetAnimals())
            {
                animal.CageFormBounds = this.Bounds; // Used for scaling
                animal.panelHeight = panelUserInfo.Height; // Used for scaling
                animal.CheckForOutOfBounds();
                animal.Move();
            }
            Invalidate();
        }

        /// <summary>
        /// Changes the direction of the animals on every tick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerChangeDirection_Tick(object sender, EventArgs e)
        {
            // Randomizing interval of timer
            int randomTime = rnd.Next(1000, 3000);
            timerChangeDirection.Interval = randomTime;

            var animals = animalCage.GetAnimals();

            // Animals who have been close to going out trigger the timer
            animals.Where(a => a.hasBeenCloseToOutOfBounds)
                .ToList()
                .ForEach(a => timerWaitAfterOutOfBounds.Enabled = true);

            // Animals who haven't been close to going out, change direction
            animals.Where(a => !a.hasBeenCloseToOutOfBounds)
                .ToList()
                .ForEach(a => a.ChangeDirection());
        }

        /// <summary>
        /// Timer responsible for the animals not going out of the form after they have returned to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWaitAfterOutOfBounds_Tick(object sender, EventArgs e)
        {
            var beenCloseToOutOfBounds = animalCage.GetAnimals()
                .Where(a => a.hasBeenCloseToOutOfBounds)
                .ToList();

            beenCloseToOutOfBounds.ForEach(a =>
            {
                a.hasBeenCloseToOutOfBounds = false;
                a.ChangeDirection();
                timerWaitAfterOutOfBounds.Enabled = false;
            });
        }

        /// <summary>
        /// Checks if user has clicked on an animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CageForm_MouseClick(object sender, MouseEventArgs e)
        {
            labelError.Visible = false;
            UpdateAnimalInfoLabels(null);

            var animals = animalCage.GetAnimals();

            animals.ForEach(a => a.animalImage.OutlineSize = 3);

            var selectedAnimal = animals
                .Where(a => a.animalImage.Contains(e.Location))
                .LastOrDefault();
            if (selectedAnimal != default)
            {
                selectedAnimal.animalImage.OutlineSize = 6;
                UpdateAnimalInfoLabels(selectedAnimal);
            }
        }

        /// <summary>
        /// Changes the values of the labels about animal info.
        /// </summary>
        /// <param name="animal"></param>
        private void UpdateAnimalInfoLabels(Animal animal)
        {
            if (animal != null)
            {
                labelName.Text = animal.Name;
                labelAge.Text = animal.Age.ToString();
                labelWeight.Text = animal.Weight.ToString();
                labelComfort.Text = animal.GetComfort().ToString();
            }
            else
            {
                labelName.Text = "";
                labelAge.Text = "";
                labelWeight.Text = "";
                labelComfort.Text = "";
            }
        }

        /// <summary>
        /// A button for buying fodder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (zoo.Money < 100)
            {
                labelError.Text = "Not enough money to buy fodder!";
                labelError.Visible = true;
                return;
            }
            if ((int)animalCage.fodderState == 2)
            {
                labelError.Text = "Fodder is already full!";
                labelError.Visible = true;
                return;
            }
            animalCage.BuyFodder();
            zoo.Money -= 100;
        }

        /// <summary>
        /// A button for doing the daily task in a cage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoTask_Click(object sender, EventArgs e)
        {
            animalCage.isTaskDone = true;
        }
    }
}
