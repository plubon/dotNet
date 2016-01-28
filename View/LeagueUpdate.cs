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
    public partial class LeagueUpdate : MetroForm
    {
        private League league;
        private LeagueRepository repo = new LeagueRepository();
        public LeagueUpdate(League _league)
        {
            league = _league;
            InitializeComponent();
            MediaTypeNames.Text = "Update league: "+league.Name;
            nameInput.Text = league.Name;
            descriptionInput.Text = league.Description;
        }

        private Boolean validate()
        {
            Boolean result = !((nameInput.Text == "") || (descriptionInput.Text == ""));
            return result;
        }
        private void LeagueUpdate_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                 league.Name = nameInput.Text;
                league.Description = descriptionInput.Text;
                repo.SaveOrUpdate(league);
                MetroMessageBox.Show(this, "League have been updated!", "Update.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
           
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            VisualStyleElement.ToolTip.Close();
        }
    }
}
