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
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.addPlayer = new MetroFramework.Controls.MetroTile();
            this.playersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(358, 128);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(163, 48);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Remove";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(189, 128);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(163, 48);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Edit";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 128);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(158, 48);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Refresh Data";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // addPlayer
            // 
            this.addPlayer.ActiveControl = null;
            this.addPlayer.Location = new System.Drawing.Point(637, 71);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(232, 105);
            this.addPlayer.TabIndex = 7;
            this.addPlayer.Text = "Add Player";
            this.addPlayer.UseSelectable = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // playersGrid
            // 
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Location = new System.Drawing.Point(23, 182);
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.RowTemplate.Height = 28;
            this.playersGrid.Size = new System.Drawing.Size(846, 394);
            this.playersGrid.TabIndex = 6;
            this.playersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playersGrid_CellContentClick);
            // 
            // PlayersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 597);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.playersGrid);
            this.Name = "PlayersView";
            this.Text = "Players";
            this.Load += new System.EventHandler(this.PlayersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile addPlayer;
        private System.Windows.Forms.DataGridView playersGrid;
    }
}