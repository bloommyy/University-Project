namespace University_Project
{
    partial class StartMenuForm
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
            this.buttonCreateNewGame = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCreateNewGame
            // 
            this.buttonCreateNewGame.Location = new System.Drawing.Point(12, 426);
            this.buttonCreateNewGame.Name = "buttonCreateNewGame";
            this.buttonCreateNewGame.Size = new System.Drawing.Size(111, 23);
            this.buttonCreateNewGame.TabIndex = 0;
            this.buttonCreateNewGame.Text = "Create New Game";
            this.buttonCreateNewGame.UseVisualStyleBackColor = true;
            this.buttonCreateNewGame.Click += new System.EventHandler(this.buttonCreateNewGame_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(351, 426);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(697, 426);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxGames
            // 
            this.listBoxGames.Font = new System.Drawing.Font("Monoid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 21;
            this.listBoxGames.Location = new System.Drawing.Point(12, 12);
            this.listBoxGames.Margin = new System.Windows.Forms.Padding(10);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxGames.Size = new System.Drawing.Size(760, 403);
            this.listBoxGames.TabIndex = 3;
            // 
            // StartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonCreateNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StartMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNewGame;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxGames;
    }
}

