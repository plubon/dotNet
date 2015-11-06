namespace View
{
    partial class LeagueShow
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
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.disciplineLabel = new System.Windows.Forms.Label();
            this.matchesGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(18, 168);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ReadOnly = true;
            this.descriptionText.Size = new System.Drawing.Size(560, 130);
            this.descriptionText.TabIndex = 2;
            this.descriptionText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discipline";
            // 
            // disciplineLabel
            // 
            this.disciplineLabel.AutoSize = true;
            this.disciplineLabel.Location = new System.Drawing.Point(23, 362);
            this.disciplineLabel.Name = "disciplineLabel";
            this.disciplineLabel.Size = new System.Drawing.Size(51, 20);
            this.disciplineLabel.TabIndex = 4;
            this.disciplineLabel.Text = "label3";
            // 
            // matchesGrid
            // 
            this.matchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesGrid.Location = new System.Drawing.Point(18, 426);
            this.matchesGrid.Name = "matchesGrid";
            this.matchesGrid.RowTemplate.Height = 28;
            this.matchesGrid.Size = new System.Drawing.Size(560, 150);
            this.matchesGrid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matches";
            // 
            // LeagueShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matchesGrid);
            this.Controls.Add(this.disciplineLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LeagueShow";
            this.Resizable = false;
            this.Text = "LeagueShow";
            this.Load += new System.EventHandler(this.LeagueShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descriptionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label disciplineLabel;
        private System.Windows.Forms.DataGridView matchesGrid;
        private System.Windows.Forms.Label label3;
    }
}