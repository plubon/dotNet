namespace View
{
    partial class MatchesView
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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.addTeam = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.matchesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matchesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(149, 128);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(232, 105);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 23;
            this.metroTile2.Text = "Update Match";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(387, 128);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(232, 105);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 22;
            this.metroTile1.Text = "Remove Match";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // addTeam
            // 
            this.addTeam.ActiveControl = null;
            this.addTeam.Location = new System.Drawing.Point(625, 128);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(232, 105);
            this.addTeam.Style = MetroFramework.MetroColorStyle.Green;
            this.addTeam.TabIndex = 21;
            this.addTeam.Text = "Add Match";
            this.addTeam.UseSelectable = true;
            this.addTeam.Click += new System.EventHandler(this.addTeam_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(7, 185);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(136, 48);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Refresh Data";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // matchesGrid
            // 
            this.matchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesGrid.Location = new System.Drawing.Point(6, 239);
            this.matchesGrid.Name = "matchesGrid";
            this.matchesGrid.RowTemplate.Height = 28;
            this.matchesGrid.Size = new System.Drawing.Size(846, 394);
            this.matchesGrid.TabIndex = 19;
            this.matchesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showSelectedMatch);
            // 
            // MatchesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 644);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.matchesGrid);
            this.Name = "MatchesView";
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.MatchesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile addTeam;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView matchesGrid;
    }
}