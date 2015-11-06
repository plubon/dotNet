namespace View
{
    partial class MatchCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamHomeBox = new System.Windows.Forms.ComboBox();
            this.teamAwayBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.team1Score = new System.Windows.Forms.NumericUpDown();
            this.team2Score = new System.Windows.Forms.NumericUpDown();
            this.dismissButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.matchDate = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leagueBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.team1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Score)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Away Team";
            // 
            // teamHomeBox
            // 
            this.teamHomeBox.FormattingEnabled = true;
            this.teamHomeBox.Location = new System.Drawing.Point(27, 135);
            this.teamHomeBox.Name = "teamHomeBox";
            this.teamHomeBox.Size = new System.Drawing.Size(272, 28);
            this.teamHomeBox.TabIndex = 2;
            // 
            // teamAwayBox
            // 
            this.teamAwayBox.FormattingEnabled = true;
            this.teamAwayBox.Location = new System.Drawing.Point(305, 134);
            this.teamAwayBox.Name = "teamAwayBox";
            this.teamAwayBox.Size = new System.Drawing.Size(275, 28);
            this.teamAwayBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Score:";
            // 
            // team1Score
            // 
            this.team1Score.Location = new System.Drawing.Point(27, 250);
            this.team1Score.Name = "team1Score";
            this.team1Score.Size = new System.Drawing.Size(120, 26);
            this.team1Score.TabIndex = 6;
            // 
            // team2Score
            // 
            this.team2Score.ForeColor = System.Drawing.Color.Black;
            this.team2Score.Location = new System.Drawing.Point(461, 249);
            this.team2Score.Name = "team2Score";
            this.team2Score.Size = new System.Drawing.Size(120, 26);
            this.team2Score.TabIndex = 7;
            // 
            // dismissButton
            // 
            this.dismissButton.Location = new System.Drawing.Point(235, 528);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(178, 100);
            this.dismissButton.TabIndex = 9;
            this.dismissButton.Text = "Dismiss";
            this.dismissButton.UseSelectable = true;
            this.dismissButton.Click += new System.EventHandler(this.dismissButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(419, 528);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(178, 100);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // matchDate
            // 
            this.matchDate.Location = new System.Drawing.Point(213, 355);
            this.matchDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.matchDate.Name = "matchDate";
            this.matchDate.Size = new System.Drawing.Size(200, 29);
            this.matchDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "League";
            // 
            // leagueBox
            // 
            this.leagueBox.FormattingEnabled = true;
            this.leagueBox.Location = new System.Drawing.Point(28, 443);
            this.leagueBox.Name = "leagueBox";
            this.leagueBox.Size = new System.Drawing.Size(271, 28);
            this.leagueBox.TabIndex = 13;
            // 
            // MatchCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 651);
            this.Controls.Add(this.leagueBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matchDate);
            this.Controls.Add(this.dismissButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.team2Score);
            this.Controls.Add(this.team1Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamAwayBox);
            this.Controls.Add(this.teamHomeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MatchCreate";
            this.Resizable = false;
            this.Text = "MatchCreate";
            this.Load += new System.EventHandler(this.MatchCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.team1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox teamHomeBox;
        private System.Windows.Forms.ComboBox teamAwayBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown team1Score;
        private System.Windows.Forms.NumericUpDown team2Score;
        private MetroFramework.Controls.MetroButton dismissButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroDateTime matchDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox leagueBox;
    }
}