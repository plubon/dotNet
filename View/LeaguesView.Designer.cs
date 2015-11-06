namespace View
{
    partial class LeaguesView
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
            this.leaguesGrid = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.addTeam = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.leaguesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leaguesGrid
            // 
            this.leaguesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaguesGrid.Location = new System.Drawing.Point(17, 282);
            this.leaguesGrid.Name = "leaguesGrid";
            this.leaguesGrid.RowTemplate.Height = 28;
            this.leaguesGrid.Size = new System.Drawing.Size(846, 394);
            this.leaguesGrid.TabIndex = 0;
            this.leaguesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaguesGrid_CellContentClick);
            this.leaguesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showSelectedLeague);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(18, 228);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(136, 48);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Refresh Data";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(160, 171);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(232, 105);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 18;
            this.metroTile2.Text = "Update League";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(398, 171);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(232, 105);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 17;
            this.metroTile1.Text = "Remove League";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // addTeam
            // 
            this.addTeam.ActiveControl = null;
            this.addTeam.Location = new System.Drawing.Point(636, 171);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(232, 105);
            this.addTeam.Style = MetroFramework.MetroColorStyle.Green;
            this.addTeam.TabIndex = 16;
            this.addTeam.Text = "Add League";
            this.addTeam.UseSelectable = true;
            this.addTeam.Click += new System.EventHandler(this.addLeague_Click);
            // 
            // LeaguesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 689);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.leaguesGrid);
            this.MaximizeBox = false;
            this.Name = "LeaguesView";
            this.Resizable = false;
            this.Text = "Leagues";
            ((System.ComponentModel.ISupportInitialize)(this.leaguesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView leaguesGrid;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile addTeam;
    }
}