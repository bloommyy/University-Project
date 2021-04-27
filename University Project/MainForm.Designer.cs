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
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelDayText = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelMoneyText = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.Silver;
            this.panelUserInfo.Controls.Add(this.button2);
            this.panelUserInfo.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1177, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buy Cage";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1096, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sell Cage";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}