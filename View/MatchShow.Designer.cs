namespace View
{
    partial class MatchShow
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homeTeamLabel = new System.Windows.Forms.Label();
            this.awayTeamLabel = new System.Windows.Forms.Label();
            this.homeTeamResultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.awayTeamResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(101, 86);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 20);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Away Team";
            // 
            // homeTeamLabel
            // 
            this.homeTeamLabel.AutoSize = true;
            this.homeTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamLabel.Location = new System.Drawing.Point(27, 229);
            this.homeTeamLabel.Name = "homeTeamLabel";
            this.homeTeamLabel.Size = new System.Drawing.Size(95, 36);
            this.homeTeamLabel.TabIndex = 4;
            this.homeTeamLabel.Text = "label4";
            // 
            // awayTeamLabel
            // 
            this.awayTeamLabel.AutoSize = true;
            this.awayTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeamLabel.Location = new System.Drawing.Point(384, 229);
            this.awayTeamLabel.Name = "awayTeamLabel";
            this.awayTeamLabel.Size = new System.Drawing.Size(95, 36);
            this.awayTeamLabel.TabIndex = 5;
            this.awayTeamLabel.Text = "label5";
            // 
            // homeTeamResultLabel
            // 
            this.homeTeamResultLabel.AutoSize = true;
            this.homeTeamResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamResultLabel.Location = new System.Drawing.Point(220, 233);
            this.homeTeamResultLabel.Name = "homeTeamResultLabel";
            this.homeTeamResultLabel.Size = new System.Drawing.Size(27, 30);
            this.homeTeamResultLabel.TabIndex = 6;
            this.homeTeamResultLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // awayTeamResultLabel
            // 
            this.awayTeamResultLabel.AutoSize = true;
            this.awayTeamResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeamResultLabel.Location = new System.Drawing.Point(279, 233);
            this.awayTeamResultLabel.Name = "awayTeamResultLabel";
            this.awayTeamResultLabel.Size = new System.Drawing.Size(27, 30);
            this.awayTeamResultLabel.TabIndex = 8;
            this.awayTeamResultLabel.Text = "0";
            // 
            // MatchShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 316);
            this.Controls.Add(this.awayTeamResultLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.homeTeamResultLabel);
            this.Controls.Add(this.awayTeamLabel);
            this.Controls.Add(this.homeTeamLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MatchShow";
            this.Resizable = false;
            this.Text = "MatchShow";
            this.Load += new System.EventHandler(this.MatchShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label homeTeamLabel;
        private System.Windows.Forms.Label awayTeamLabel;
        private System.Windows.Forms.Label homeTeamResultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label awayTeamResultLabel;
    }
}