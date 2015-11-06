namespace View
{
    partial class TeamsView
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
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.addTeam = new MetroFramework.Controls.MetroTile();
            this.teamGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(376, 126);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(163, 48);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Remove";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(207, 126);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(163, 48);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Edit";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(42, 126);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(158, 48);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Refresh Data";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // addTeam
            // 
            this.addTeam.ActiveControl = null;
            this.addTeam.Location = new System.Drawing.Point(655, 69);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(232, 105);
            this.addTeam.TabIndex = 7;
            this.addTeam.Text = "Add Teague";
            this.addTeam.UseSelectable = true;
            this.addTeam.Click += new System.EventHandler(this.addTeam_Click);
            // 
            // teamGrid
            // 
            this.teamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGrid.Location = new System.Drawing.Point(41, 180);
            this.teamGrid.Name = "teamGrid";
            this.teamGrid.RowTemplate.Height = 28;
            this.teamGrid.Size = new System.Drawing.Size(846, 394);
            this.teamGrid.TabIndex = 6;
            // 
            // TeamsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 592);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.teamGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeamsView";
            this.Resizable = false;
            this.Text = "TeamsView";
            this.Load += new System.EventHandler(this.TeamsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile addTeam;
        private System.Windows.Forms.DataGridView teamGrid;
    }
}