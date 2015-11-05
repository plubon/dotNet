namespace View
{
    partial class DisciplineShow
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
            this.description = new MetroFramework.Drawing.Html.HtmlLabel();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.AutoScroll = true;
            this.description.AutoScrollMinSize = new System.Drawing.Size(89, 29);
            this.description.AutoSize = false;
            this.description.BackColor = System.Drawing.SystemColors.Window;
            this.description.Location = new System.Drawing.Point(23, 116);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(771, 428);
            this.description.TabIndex = 0;
            this.description.Text = "htmlLabel1";
            // 
            // DisciplineShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 558);
            this.Controls.Add(this.description);
            this.Name = "DisciplineShow";
            this.Resizable = false;
            this.Text = "DisciplineShow";
            this.Load += new System.EventHandler(this.DisciplineShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel description;
    }
}