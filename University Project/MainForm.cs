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
            DrawCages(e.Graphics);
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
        public void DrawCages(Graphics g) // Maybe put that Rectangles in AnimalCage and drawing using foreach on cagelist on zoo.
        {
            // Fence
            using (var pen = new Pen(Color.Brown, 10))
            {
                g.DrawRectangle(pen, 5, 5, 2 * (float)(this.Bounds.Width / 5), 570);
                g.DrawRectangle(pen, 5 + 3* (float)(this.Bounds.Width / 5), 5, 2 * (float)(this.Bounds.Width / 5), 570);
            }
            // Mud
            using(var brush = new SolidBrush(Color.SandyBrown))
            {
                g.FillRectangle(brush, 5, 5, 2 * (float)(this.Bounds.Width / 5), 570);
                g.FillRectangle(brush, 5 + 3 * (float)(this.Bounds.Width / 5), 5, 2 * (float)(this.Bounds.Width / 5), 570);
            }
            // Path
            using(var brush = new SolidBrush(Color.DimGray))
            {
                g.FillRectangle(brush, 15 + 2 * (float)(this.Bounds.Width / 5), 0, (float)(this.Bounds.Width / 5) - 20, 580);
            }
        }
    }
}
