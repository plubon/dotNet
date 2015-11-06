namespace View
{
    partial class PlayerCreate
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
            this.dismissButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nationalityInput = new System.Windows.Forms.TextBox();
            this.teamsCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dismissButton
            // 
            this.dismissButton.Location = new System.Drawing.Point(213, 304);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(178, 100);
            this.dismissButton.TabIndex = 7;
            this.dismissButton.Text = "Dismiss";
            this.dismissButton.UseSelectable = true;
            this.dismissButton.Click += new System.EventHandler(this.dismissButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(397, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(178, 100);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nationality:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Team:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(232, 148);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(338, 26);
            this.nameInput.TabIndex = 11;
            // 
            // nationalityInput
            // 
            this.nationalityInput.Location = new System.Drawing.Point(232, 198);
            this.nationalityInput.Name = "nationalityInput";
            this.nationalityInput.Size = new System.Drawing.Size(338, 26);
            this.nationalityInput.TabIndex = 12;
            // 
            // teamsCombo
            // 
            this.teamsCombo.FormattingEnabled = true;
            this.teamsCombo.Location = new System.Drawing.Point(232, 245);
            this.teamsCombo.Name = "teamsCombo";
            this.teamsCombo.Size = new System.Drawing.Size(338, 28);
            this.teamsCombo.TabIndex = 13;
            // 
            // PlayerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 417);
            this.Controls.Add(this.teamsCombo);
            this.Controls.Add(this.nationalityInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dismissButton);
            this.Controls.Add(this.saveButton);
            this.MaximizeBox = false;
            this.Name = "PlayerCreate";
            this.Resizable = false;
            this.Text = "PlayerCreate";
            this.Load += new System.EventHandler(this.PlayerCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton dismissButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox nationalityInput;
        private System.Windows.Forms.ComboBox teamsCombo;
    }
}