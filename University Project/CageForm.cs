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
        private Queue<string> q = new Queue<string>();

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
            //Invalidate();
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SetLabels();

            if (q.Count >= 1)
            {
                if(q.Dequeue() == "Elephant")
                {
                    animalCage.AddAnimal(new Elephant("Harry", 17, 8600));
                }else if(q.Dequeue() == "Penguin")
                {
                    animalCage.AddAnimal(new Penguin("Pengu", 5, 20));
                }
            }

            foreach(var animal in animalCage.GetAnimals())
            {
                animal.animalImage.DrawAnimal(e.Graphics);
            }
        }

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

        private void buttonBuyAnimal_Click(object sender, EventArgs e)
        {
            if (zoo.Money < 300)
                return;


            if(animalCage.cageType == CageType.Elephant)
            {
                q.Enqueue("Elephant");
                
            }else if(animalCage.cageType == CageType.Penguin)
            {
                q.Enqueue("Penguin");
            }
        }

        private void buttonSellAnimal_Click(object sender, EventArgs e)
        {

        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            foreach (var animal in animalCage.GetAnimals())
            {
                animal.Move();
            }
            Invalidate();
        }

        private void timerChangeDirection_Tick(object sender, EventArgs e)
        {
            foreach (var animal in animalCage.GetAnimals())
            {
                animal.ChangeDirection();
            }
        }
    }
}
