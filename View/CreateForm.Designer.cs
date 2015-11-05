namespace View
{
    partial class CreateForm
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
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.dismissButton = new MetroFramework.Controls.MetroButton();
            this.formTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(559, 685);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(178, 100);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            // 
            // dismissButton
            // 
            this.dismissButton.Location = new System.Drawing.Point(375, 685);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(178, 100);
            this.dismissButton.TabIndex = 1;
            this.dismissButton.Text = "Dismiss";
            this.dismissButton.UseSelectable = true;
            // 
            // formTableLayout
            // 
            this.formTableLayout.ColumnCount = 1;
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.Location = new System.Drawing.Point(24, 125);
            this.formTableLayout.Name = "formTableLayout";
            this.formTableLayout.RowCount = 1;
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.Size = new System.Drawing.Size(713, 554);
            this.formTableLayout.TabIndex = 2;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 808);
            this.Controls.Add(this.formTableLayout);
            this.Controls.Add(this.dismissButton);
            this.Controls.Add(this.saveButton);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroButton dismissButton;
        private System.Windows.Forms.TableLayoutPanel formTableLayout;
    }
}