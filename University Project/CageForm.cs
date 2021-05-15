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
    public partial class CageForm : Form
    {
        public AnimalCage animalCage;
        public Zoo zoo;

        /// <summary>
        /// Constructor for CageForm.
        /// </summary>
        public CageForm(CageType cageType)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Text = cageType + " Cage";
            buttonBuyAnimal.Text = (cageType == CageType.Elephant) ? "Buy Elephant -300" : "Buy Penguin -300";
            buttonSellAnimal.Text = (cageType == CageType.Elephant) ? "Sell Elephant +100" : "Sell Penguin +100";
        }

        /// <summary>
        /// Sets the value of the Minute, Hour, Day, Money and Task.
        /// </summary>
        public void SetLabels()
        {
            labelDay.Text = zoo.Day.ToString();
            labelHour.Text = zoo.Hour.ToString();
            labelMinutes.Text = zoo.Minute.ToString();
            labelMoney.Text = zoo.Money.ToString();
            labelTaskDone.Text = animalCage.isTaskDone ? "Done" : "Not done";
        }

        /// <summary>
        /// Redraws the form.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SetLabels();
            foreach(var animal in animalCage.GetAnimals())
            {
                animal.animalImage.DrawAnimal(e.Graphics);
            }
        }

        /// <summary>
        /// Method that simulates a clock using the timer's tick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            zoo.Minute++;
            if (zoo.Minute >= 60)
            {
                zoo.Hour++;
                if (zoo.Hour >= 21)
                    zoo.NextDay();
                zoo.Minute = 0;
            }
            Invalidate();
        }

        /// <summary>
        /// Buying an animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyAnimal_Click(object sender, EventArgs e)
        {
            if (zoo.Money < 300)
                return; labelError.Text = "Not enough money.";

            if(animalCage.cageType == CageType.Elephant)
            {
                animalCage.AddAnimal(new Elephant("Harry", 17, 8600));
            }
            else if(animalCage.cageType == CageType.Penguin)
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
            var animals = animalCage.GetAnimals();
            for(int i = animals.Count - 1; i >= 0; i--)
            {
                if (animals[i].animalImage.outlineSize == 6)
                {
                    animalCage.RemoveAnimal(animals[i]);
                    zoo.Money += 100;
                }
            }
            UpdateAnimalInfoLabels();
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
            foreach (var animal in animalCage.GetAnimals())
            {
                animal.ChangeDirection();
            }
        }

        /// <summary>
        /// Checks if user has clicked on an animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CageForm_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateAnimalInfoLabels();
            foreach (var animal in animalCage.GetAnimals())
            {
                animal.animalImage.outlineSize = 3;
                if (animal.animalImage.Contains(e.Location))
                {
                    animal.animalImage.outlineSize = 6;
                    UpdateAnimalInfoLabels(animal);
                }
            }
        }

        /// <summary>
        /// Changes the values of the labels about animal info.
        /// </summary>
        /// <param name="animal"></param>
        private void UpdateAnimalInfoLabels(Animal animal = null)
        {
            if(animal != null)
            {
                labelName.Text = animal.Name;
                labelAge.Text = animal.Age.ToString();
                labelWeight.Text = animal.Weight.ToString();
                labelComfort.Text = animal.comfort.ToString();
            }
            else
            {
                labelName.Text = "";
                labelAge.Text = "";
                labelWeight.Text = "";
                labelComfort.Text = "";
            }
            
        }
    }
}
