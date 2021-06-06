namespace University_Project
{
    partial class CageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuyFodder = new System.Windows.Forms.Button();
            this.buttonDoTask = new System.Windows.Forms.Button();
            this.buttonBuyAnimal = new System.Windows.Forms.Button();
            this.buttonSellAnimal = new System.Windows.Forms.Button();
            this.labelFodder = new System.Windows.Forms.Label();
            this.labelFodderText = new System.Windows.Forms.Label();
            this.labelComfort = new System.Windows.Forms.Label();
            this.labelComfortText = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelWeightText = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelAgeText = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameText = new System.Windows.Forms.Label();
            this.labelTaskDone = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelTasksDoneText = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelDayText = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelMoneyText = new System.Windows.Forms.Label();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.timerChangeDirection = new System.Windows.Forms.Timer(this.components);
            this.timerWaitAfterOutOfBounds = new System.Windows.Forms.Timer(this.components);
            this.panelUserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.Silver;
            this.panelUserInfo.Controls.Add(this.panel1);
            this.panelUserInfo.Controls.Add(this.labelFodder);
            this.panelUserInfo.Controls.Add(this.labelFodderText);
            this.panelUserInfo.Controls.Add(this.labelComfort);
            this.panelUserInfo.Controls.Add(this.labelComfortText);
            this.panelUserInfo.Controls.Add(this.labelWeight);
            this.panelUserInfo.Controls.Add(this.labelWeightText);
            this.panelUserInfo.Controls.Add(this.labelAge);
            this.panelUserInfo.Controls.Add(this.labelAgeText);
            this.panelUserInfo.Controls.Add(this.labelName);
            this.panelUserInfo.Controls.Add(this.labelNameText);
            this.panelUserInfo.Controls.Add(this.labelTaskDone);
            this.panelUserInfo.Controls.Add(this.labelError);
            this.panelUserInfo.Controls.Add(this.labelTasksDoneText);
            this.panelUserInfo.Controls.Add(this.labelMinutes);
            this.panelUserInfo.Controls.Add(this.labelHour);
            this.panelUserInfo.Controls.Add(this.labelTime);
            this.panelUserInfo.Controls.Add(this.labelDay);
            this.panelUserInfo.Controls.Add(this.labelDayText);
            this.panelUserInfo.Controls.Add(this.labelMoney);
            this.panelUserInfo.Controls.Add(this.labelMoneyText);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 581);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(1264, 100);
            this.panelUserInfo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBuyFodder);
            this.panel1.Controls.Add(this.buttonDoTask);
            this.panel1.Controls.Add(this.buttonBuyAnimal);
            this.panel1.Controls.Add(this.buttonSellAnimal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1019, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 100);
            this.panel1.TabIndex = 21;
            // 
            // buttonBuyFodder
            // 
            this.buttonBuyFodder.Location = new System.Drawing.Point(3, 9);
            this.buttonBuyFodder.Name = "buttonBuyFodder";
            this.buttonBuyFodder.Size = new System.Drawing.Size(115, 23);
            this.buttonBuyFodder.TabIndex = 18;
            this.buttonBuyFodder.Text = "Buy Fodder -100";
            this.buttonBuyFodder.UseVisualStyleBackColor = true;
            this.buttonBuyFodder.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDoTask
            // 
            this.buttonDoTask.Location = new System.Drawing.Point(3, 38);
            this.buttonDoTask.Name = "buttonDoTask";
            this.buttonDoTask.Size = new System.Drawing.Size(115, 23);
            this.buttonDoTask.TabIndex = 20;
            this.buttonDoTask.Text = "Do Task";
            this.buttonDoTask.UseVisualStyleBackColor = true;
            this.buttonDoTask.Click += new System.EventHandler(this.buttonDoTask_Click);
            // 
            // buttonBuyAnimal
            // 
            this.buttonBuyAnimal.Location = new System.Drawing.Point(124, 9);
            this.buttonBuyAnimal.Name = "buttonBuyAnimal";
            this.buttonBuyAnimal.Size = new System.Drawing.Size(115, 23);
            this.buttonBuyAnimal.TabIndex = 1;
            this.buttonBuyAnimal.Text = "Buy Animal -300";
            this.buttonBuyAnimal.UseVisualStyleBackColor = true;
            this.buttonBuyAnimal.Click += new System.EventHandler(this.buttonBuyAnimal_Click);
            // 
            // buttonSellAnimal
            // 
            this.buttonSellAnimal.Location = new System.Drawing.Point(124, 38);
            this.buttonSellAnimal.Name = "buttonSellAnimal";
            this.buttonSellAnimal.Size = new System.Drawing.Size(115, 23);
            this.buttonSellAnimal.TabIndex = 7;
            this.buttonSellAnimal.Text = "Sell Animal +100";
            this.buttonSellAnimal.UseVisualStyleBackColor = true;
            this.buttonSellAnimal.Click += new System.EventHandler(this.buttonSellAnimal_Click);
            // 
            // labelFodder
            // 
            this.labelFodder.AutoSize = true;
            this.labelFodder.Location = new System.Drawing.Point(537, 12);
            this.labelFodder.Name = "labelFodder";
            this.labelFodder.Size = new System.Drawing.Size(0, 13);
            this.labelFodder.TabIndex = 17;
            // 
            // labelFodderText
            // 
            this.labelFodderText.AutoSize = true;
            this.labelFodderText.Location = new System.Drawing.Point(494, 12);
            this.labelFodderText.Name = "labelFodderText";
            this.labelFodderText.Size = new System.Drawing.Size(46, 13);
            this.labelFodderText.TabIndex = 16;
            this.labelFodderText.Text = "Fodder :";
            // 
            // labelComfort
            // 
            this.labelComfort.AutoSize = true;
            this.labelComfort.Location = new System.Drawing.Point(392, 12);
            this.labelComfort.Name = "labelComfort";
            this.labelComfort.Size = new System.Drawing.Size(0, 13);
            this.labelComfort.TabIndex = 15;
            // 
            // labelComfortText
            // 
            this.labelComfortText.AutoSize = true;
            this.labelComfortText.Location = new System.Drawing.Point(347, 12);
            this.labelComfortText.Name = "labelComfortText";
            this.labelComfortText.Size = new System.Drawing.Size(49, 13);
            this.labelComfortText.TabIndex = 14;
            this.labelComfortText.Text = "Comfort :";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(393, 39);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(0, 13);
            this.labelWeight.TabIndex = 13;
            // 
            // labelWeightText
            // 
            this.labelWeightText.AutoSize = true;
            this.labelWeightText.Location = new System.Drawing.Point(347, 39);
            this.labelWeightText.Name = "labelWeightText";
            this.labelWeightText.Size = new System.Drawing.Size(47, 13);
            this.labelWeightText.TabIndex = 12;
            this.labelWeightText.Text = "Weight :";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(248, 39);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(0, 13);
            this.labelAge.TabIndex = 11;
            // 
            // labelAgeText
            // 
            this.labelAgeText.AutoSize = true;
            this.labelAgeText.Location = new System.Drawing.Point(219, 39);
            this.labelAgeText.Name = "labelAgeText";
            this.labelAgeText.Size = new System.Drawing.Size(32, 13);
            this.labelAgeText.TabIndex = 10;
            this.labelAgeText.Text = "Age :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(257, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 9;
            // 
            // labelNameText
            // 
            this.labelNameText.AutoSize = true;
            this.labelNameText.Location = new System.Drawing.Point(219, 12);
            this.labelNameText.Name = "labelNameText";
            this.labelNameText.Size = new System.Drawing.Size(41, 13);
            this.labelNameText.TabIndex = 2;
            this.labelNameText.Text = "Name :";
            // 
            // labelTaskDone
            // 
            this.labelTaskDone.AutoSize = true;
            this.labelTaskDone.Location = new System.Drawing.Point(157, 39);
            this.labelTaskDone.Name = "labelTaskDone";
            this.labelTaskDone.Size = new System.Drawing.Size(0, 13);
            this.labelTaskDone.TabIndex = 8;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(490, 63);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 37);
            this.labelError.TabIndex = 1;
            this.labelError.Visible = false;
            // 
            // labelTasksDoneText
            // 
            this.labelTasksDoneText.AutoSize = true;
            this.labelTasksDoneText.Location = new System.Drawing.Point(116, 39);
            this.labelTasksDoneText.Name = "labelTasksDoneText";
            this.labelTasksDoneText.Size = new System.Drawing.Size(37, 13);
            this.labelTasksDoneText.TabIndex = 1;
            this.labelTasksDoneText.Text = "Task :";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(176, 12);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(13, 13);
            this.labelMinutes.TabIndex = 6;
            this.labelMinutes.Text = "0";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(157, 12);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(13, 13);
            this.labelHour.TabIndex = 5;
            this.labelHour.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(115, 12);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time :";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(44, 39);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(13, 13);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "0";
            // 
            // labelDayText
            // 
            this.labelDayText.AutoSize = true;
            this.labelDayText.Location = new System.Drawing.Point(12, 39);
            this.labelDayText.Name = "labelDayText";
            this.labelDayText.Size = new System.Drawing.Size(32, 13);
            this.labelDayText.TabIndex = 2;
            this.labelDayText.Text = "Day :";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(53, 12);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(13, 13);
            this.labelMoney.TabIndex = 1;
            this.labelMoney.Text = "0";
            // 
            // labelMoneyText
            // 
            this.labelMoneyText.AutoSize = true;
            this.labelMoneyText.Location = new System.Drawing.Point(12, 12);
            this.labelMoneyText.Name = "labelMoneyText";
            this.labelMoneyText.Size = new System.Drawing.Size(45, 13);
            this.labelMoneyText.TabIndex = 0;
            this.labelMoneyText.Text = "Money :";
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 24;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // timerChangeDirection
            // 
            this.timerChangeDirection.Enabled = true;
            this.timerChangeDirection.Interval = 4000;
            this.timerChangeDirection.Tick += new System.EventHandler(this.timerChangeDirection_Tick);
            // 
            // timerWaitAfterOutOfBounds
            // 
            this.timerWaitAfterOutOfBounds.Interval = 1000;
            this.timerWaitAfterOutOfBounds.Tick += new System.EventHandler(this.timerWaitAfterOutOfBounds_Tick);
            // 
            // CageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelUserInfo);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CageForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CageForm_MouseClick);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelTasksDoneText;
        private System.Windows.Forms.Button buttonSellAnimal;
        private System.Windows.Forms.Button buttonBuyAnimal;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelDayText;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelMoneyText;
        private System.Windows.Forms.Label labelTaskDone;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Timer timerChangeDirection;
        private System.Windows.Forms.Label labelComfort;
        private System.Windows.Forms.Label labelComfortText;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelWeightText;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelAgeText;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameText;
        private System.Windows.Forms.Label labelFodder;
        private System.Windows.Forms.Label labelFodderText;
        private System.Windows.Forms.Button buttonBuyFodder;
        private System.Windows.Forms.Timer timerWaitAfterOutOfBounds;
        private System.Windows.Forms.Button buttonDoTask;
        private System.Windows.Forms.Panel panel1;
    }
}