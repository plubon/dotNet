namespace View
{
    partial class TeamShow
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
            this.label3 = new System.Windows.Forms.Label();
            this.homeMatchesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeMatchesGrid = new System.Windows.Forms.DataGridView();
            this.awayMatchesGrid = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.homeMatchesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayMatchesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // homeMatchesLabel
            // 
            this.homeMatchesLabel.AutoSize = true;
            this.homeMatchesLabel.Location = new System.Drawing.Point(19, 591);
            this.homeMatchesLabel.Name = "homeMatchesLabel";
            this.homeMatchesLabel.Size = new System.Drawing.Size(117, 20);
            this.homeMatchesLabel.TabIndex = 1;
            this.homeMatchesLabel.Text = "Home Matches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Away Matches";
            // 
            // homeMatchesGrid
            // 
            this.homeMatchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeMatchesGrid.Location = new System.Drawing.Point(23, 614);
            this.homeMatchesGrid.Name = "homeMatchesGrid";
            this.homeMatchesGrid.RowTemplate.Height = 28;
            this.homeMatchesGrid.Size = new System.Drawing.Size(884, 228);
            this.homeMatchesGrid.TabIndex = 3;
            // 
            // awayMatchesGrid
            // 
            this.awayMatchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayMatchesGrid.Location = new System.Drawing.Point(23, 360);
            this.awayMatchesGrid.Name = "awayMatchesGrid";
            this.awayMatchesGrid.RowTemplate.Height = 28;
            this.awayMatchesGrid.Size = new System.Drawing.Size(884, 228);
            this.awayMatchesGrid.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(94, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Players";
            // 
            // playersGrid
            // 
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Location = new System.Drawing.Point(23, 143);
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.RowTemplate.Height = 28;
            this.playersGrid.Size = new System.Drawing.Size(884, 181);
            this.playersGrid.TabIndex = 7;
            // 
            // TeamShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 858);
            this.Controls.Add(this.playersGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.awayMatchesGrid);
            this.Controls.Add(this.homeMatchesGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeMatchesLabel);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "TeamShow";
            this.Resizable = false;
            this.Text = "TeamShow";
            this.Load += new System.EventHandler(this.TeamShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeMatchesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayMatchesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label homeMatchesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView homeMatchesGrid;
        private System.Windows.Forms.DataGridView awayMatchesGrid;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView playersGrid;
    }
}