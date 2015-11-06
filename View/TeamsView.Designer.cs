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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.addTeam = new MetroFramework.Controls.MetroTile();
            this.teamGrid = new System.Windows.Forms.DataGridView();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(13, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(131, 48);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Refresh Data";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // addTeam
            // 
            this.addTeam.ActiveControl = null;
            this.addTeam.Location = new System.Drawing.Point(626, 158);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(232, 105);
            this.addTeam.Style = MetroFramework.MetroColorStyle.Green;
            this.addTeam.TabIndex = 7;
            this.addTeam.Text = "Add Team";
            this.addTeam.UseSelectable = true;
            this.addTeam.Click += new System.EventHandler(this.addTeam_Click);
            // 
            // teamGrid
            // 
            this.teamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGrid.Location = new System.Drawing.Point(12, 269);
            this.teamGrid.Name = "teamGrid";
            this.teamGrid.RowTemplate.Height = 28;
            this.teamGrid.Size = new System.Drawing.Size(846, 394);
            this.teamGrid.TabIndex = 6;
            this.teamGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamGrid_CellContentClick);
            this.teamGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showSellectedTeam);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(388, 158);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(232, 105);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "Remove Team";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroButton3_Click);
            this.metroTile1.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.metroTile1_ChangeUICues);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(150, 158);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(232, 105);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 12;
            this.metroTile2.Text = "Update Team";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // TeamsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 675);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.teamGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeamsView";
            this.Resizable = false;
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.TeamsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile addTeam;
        private System.Windows.Forms.DataGridView teamGrid;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}