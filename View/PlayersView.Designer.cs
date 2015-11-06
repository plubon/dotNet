namespace View
{
    partial class PlayersView
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.playersGrid = new System.Windows.Forms.DataGridView();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.addTeam = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(16, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(131, 48);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Refresh Data";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // playersGrid
            // 
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Location = new System.Drawing.Point(15, 269);
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.RowTemplate.Height = 28;
            this.playersGrid.Size = new System.Drawing.Size(846, 394);
            this.playersGrid.TabIndex = 6;
            this.playersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playersGrid_CellContentClick);
            this.playersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showSelectedPlayer);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(153, 158);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(232, 105);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 15;
            this.metroTile2.Text = "Update Player";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(391, 158);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(232, 105);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 14;
            this.metroTile1.Text = "Remove Player";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // addTeam
            // 
            this.addTeam.ActiveControl = null;
            this.addTeam.Location = new System.Drawing.Point(629, 158);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(232, 105);
            this.addTeam.Style = MetroFramework.MetroColorStyle.Green;
            this.addTeam.TabIndex = 13;
            this.addTeam.Text = "Add Player";
            this.addTeam.UseSelectable = true;
            this.addTeam.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // PlayersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 678);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.playersGrid);
            this.Name = "PlayersView";
            this.Text = "Players";
            this.Load += new System.EventHandler(this.PlayersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView playersGrid;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile addTeam;
    }
}