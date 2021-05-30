namespace University_Project
{
    partial class MainForm
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
            this.buttonSaveGame = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelTasksDone = new System.Windows.Forms.Label();
            this.labelTasksDoneText = new System.Windows.Forms.Label();
            this.buttonSellCage = new System.Windows.Forms.Button();
            this.buttonBuyCage = new System.Windows.Forms.Button();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelDayText = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelMoneyText = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.Silver;
            this.panelUserInfo.Controls.Add(this.buttonSaveGame);
            this.panelUserInfo.Controls.Add(this.labelError);
            this.panelUserInfo.Controls.Add(this.labelTasksDone);
            this.panelUserInfo.Controls.Add(this.labelTasksDoneText);
            this.panelUserInfo.Controls.Add(this.buttonSellCage);
            this.panelUserInfo.Controls.Add(this.buttonBuyCage);
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
            this.panelUserInfo.TabIndex = 0;
            // 
            // buttonSaveGame
            // 
            this.buttonSaveGame.Location = new System.Drawing.Point(1136, 70);
            this.buttonSaveGame.Name = "buttonSaveGame";
            this.buttonSaveGame.Size = new System.Drawing.Size(115, 23);
            this.buttonSaveGame.TabIndex = 9;
            this.buttonSaveGame.Text = "Save Game";
            this.buttonSaveGame.UseVisualStyleBackColor = true;
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
            // labelTasksDone
            // 
            this.labelTasksDone.AutoSize = true;
            this.labelTasksDone.Location = new System.Drawing.Point(191, 39);
            this.labelTasksDone.Name = "labelTasksDone";
            this.labelTasksDone.Size = new System.Drawing.Size(99, 13);
            this.labelTasksDone.TabIndex = 8;
            this.labelTasksDone.Text = "label for tasks done";
            // 
            // labelTasksDoneText
            // 
            this.labelTasksDoneText.AutoSize = true;
            this.labelTasksDoneText.Location = new System.Drawing.Point(116, 39);
            this.labelTasksDoneText.Name = "labelTasksDoneText";
            this.labelTasksDoneText.Size = new System.Drawing.Size(59, 13);
            this.labelTasksDoneText.TabIndex = 1;
            this.labelTasksDoneText.Text = "Tasks left :";
            // 
            // buttonSellCage
            // 
            this.buttonSellCage.Location = new System.Drawing.Point(1136, 41);
            this.buttonSellCage.Name = "buttonSellCage";
            this.buttonSellCage.Size = new System.Drawing.Size(115, 23);
            this.buttonSellCage.TabIndex = 7;
            this.buttonSellCage.Text = "Sell Cage +200";
            this.buttonSellCage.UseVisualStyleBackColor = true;
            this.buttonSellCage.Click += new System.EventHandler(this.buttonSellCage_Click);
            // 
            // buttonBuyCage
            // 
            this.buttonBuyCage.Location = new System.Drawing.Point(1136, 12);
            this.buttonBuyCage.Name = "buttonBuyCage";
            this.buttonBuyCage.Size = new System.Drawing.Size(115, 23);
            this.buttonBuyCage.TabIndex = 1;
            this.buttonBuyCage.Text = "Buy Cage -400";
            this.buttonBuyCage.UseVisualStyleBackColor = true;
            this.buttonBuyCage.Click += new System.EventHandler(this.buttonBuyCage_Click);
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
            this.labelDay.Location = new System.Drawing.Point(44, 52);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(13, 13);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "0";
            // 
            // labelDayText
            // 
            this.labelDayText.AutoSize = true;
            this.labelDayText.Location = new System.Drawing.Point(12, 52);
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
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 200;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelDayText;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelMoneyText;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button buttonSellCage;
        private System.Windows.Forms.Button buttonBuyCage;
        private System.Windows.Forms.Label labelTasksDone;
        private System.Windows.Forms.Label labelTasksDoneText;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonSaveGame;
    }
}