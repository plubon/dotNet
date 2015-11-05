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
            this.addLeague = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.leaguesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leaguesGrid
            // 
            this.leaguesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaguesGrid.Location = new System.Drawing.Point(23, 174);
            this.leaguesGrid.Name = "leaguesGrid";
            this.leaguesGrid.RowTemplate.Height = 28;
            this.leaguesGrid.Size = new System.Drawing.Size(846, 394);
            this.leaguesGrid.TabIndex = 0;
            // 
            // addLeague
            // 
            this.addLeague.ActiveControl = null;
            this.addLeague.Location = new System.Drawing.Point(637, 63);
            this.addLeague.Name = "addLeague";
            this.addLeague.Size = new System.Drawing.Size(232, 105);
            this.addLeague.TabIndex = 1;
            this.addLeague.Text = "Add League";
            this.addLeague.UseSelectable = true;
            this.addLeague.Click += new System.EventHandler(this.addLeague_Click);
            // 
            // LeaguesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 591);
            this.Controls.Add(this.addLeague);
            this.Controls.Add(this.leaguesGrid);
            this.Name = "LeaguesView";
            this.Resizable = false;
            this.Text = "Leagues";
            ((System.ComponentModel.ISupportInitialize)(this.leaguesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView leaguesGrid;
        private MetroFramework.Controls.MetroTile addLeague;
    }
}