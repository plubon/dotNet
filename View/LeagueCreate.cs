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
    public partial class LeagueCreate : MetroForm
    {
        private Discipline discipline;
        private Boolean validate()
        {
            bool result = !(nameInput.TextLength == 0 || descriptionInput.TextLength == 0 || discipline == null);

            return result;
        }
        public LeagueCreate(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                
               
                    League newLeague = new League();
                    newLeague.Description = descriptionInput.Text;
                    newLeague.Name = nameInput.Text;
                    newLeague.Discipline = discipline;
                    newLeague.Matches = new List<Match>();
                    var repo = new LeagueRepository();
                    repo.SaveOrUpdate(newLeague);
                    DialogResult result = MetroMessageBox.Show(this, "League created!", "Success!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {


                    }
                
               
            }
            else
            {
                MetroMessageBox.Show(this, "Sorry, data is not valid.", "Validation error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                System.Console.Write(discipline.Name);
            }
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
