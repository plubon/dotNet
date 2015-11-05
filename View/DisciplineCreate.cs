using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Model.Enitites;
using Repository;

namespace View
{
    public partial class DisciplineCreate : MetroForm
    {
        private DisciplineForm parent;
        private Boolean validate()
        {
            bool result = !(nameInput.TextLength == 0 || descriptionInput.TextLength == 0);

            return result;
        }

        public DisciplineCreate(DisciplineForm _parent)
        {
            parent = _parent;
            InitializeComponent();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Discipline newDiscipline = new Discipline();
                newDiscipline.Description = descriptionInput.Text;
                newDiscipline.Name = nameInput.Text;
                var repo = new DisciplineRepository();
                repo.SaveOrUpdate(newDiscipline);
                DialogResult result = MetroMessageBox.Show(this, "Discipline created!", "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    parent.addDisciplineItem(newDiscipline);
                    parent.BringToFront();
                    Close();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Sorry, data is not valid.", "Validation error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
