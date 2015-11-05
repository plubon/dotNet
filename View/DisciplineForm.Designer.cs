namespace View
{
    partial class DisciplineForm
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
            this.components = new System.ComponentModel.Container();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.disciplinesPanel = new MetroFramework.Controls.MetroPanel();
            this.addDiscipline = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.maintenanceToolStripMenuItem.Text = "&Maintenance";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(185, 160);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.metroToolTip_Popup);
            // 
            // disciplinesPanel
            // 
            this.disciplinesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disciplinesPanel.HorizontalScrollbarBarColor = true;
            this.disciplinesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.disciplinesPanel.HorizontalScrollbarSize = 10;
            this.disciplinesPanel.Location = new System.Drawing.Point(34, 190);
            this.disciplinesPanel.Name = "disciplinesPanel";
            this.disciplinesPanel.Size = new System.Drawing.Size(1015, 508);
            this.disciplinesPanel.TabIndex = 1;
            this.disciplinesPanel.VerticalScrollbarBarColor = true;
            this.disciplinesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.disciplinesPanel.VerticalScrollbarSize = 10;
            // 
            // addDiscipline
            // 
            this.addDiscipline.ActiveControl = null;
            this.addDiscipline.Location = new System.Drawing.Point(753, 56);
            this.addDiscipline.Name = "addDiscipline";
            this.addDiscipline.Size = new System.Drawing.Size(296, 128);
            this.addDiscipline.TabIndex = 2;
            this.addDiscipline.Text = "Add Discipline";
            this.addDiscipline.UseSelectable = true;
            this.addDiscipline.Click += new System.EventHandler(this.addDiscipline_Click);
            // 
            // DisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 732);
            this.Controls.Add(this.addDiscipline);
            this.Controls.Add(this.disciplinesPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisciplineForm";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Discipline";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel disciplinesPanel;
        private MetroFramework.Controls.MetroTile addDiscipline;
    }
}