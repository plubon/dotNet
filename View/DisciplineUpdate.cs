using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework;
using MetroFramework.Forms;
using Model.Enitites;
using Repository;

namespace View
{
    public partial class DisciplineUpdate : MetroForm
    {
        private Boolean validate()
        {
            bool result = !(nameInput.TextLength == 0 || descriptionInput.TextLength == 0);

            return result;
        }

        private Discipline discipline;
        public DisciplineUpdate(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            MediaTypeNames.Text = "Update: "+discipline.Name;
            nameInput.Text = discipline.Name;
            descriptionInput.Text = discipline.Description;

        }

        private void DisciplineUpdate_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                
                discipline.Description = descriptionInput.Text;
                discipline.Name = nameInput.Text;
                var repo = new DisciplineRepository();
                repo.SaveOrUpdate(discipline);
                DialogResult result = MetroMessageBox.Show(this, "Discipline updated!", "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    VisualStyleElement.ToolTip.Close();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Sorry, data is not valid.", "Validation error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            VisualStyleElement.ToolTip.Close();
        }
    }
}
