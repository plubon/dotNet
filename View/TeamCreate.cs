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
    public partial class TeamCreate : MetroForm
    {
        private Boolean validate()
        {
            Boolean result = nameInput.Text != "";
            return result;
        }
        private Team handle = null;
        public TeamCreate()
        {
            InitializeComponent();
        }

        public TeamCreate(Team _handle)
        {
            handle = _handle;
            InitializeComponent();
            nameInput.Text = handle.Name;
            Text = "Update Team " + handle.Name;
        }

        private void TeamCreate_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (handle != null)
                {
                    handle.Name = nameInput.Text;
                    var repo = new TeamRepository();
                    repo.SaveOrUpdate(handle);
                    DialogResult result = MetroMessageBox.Show(this, "Team updated!", "Success!", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {


                    }
                }
                else
                {
                    Team newTeam = new Team();
                    newTeam.Name = nameInput.Text;
                    var repo = new TeamRepository();
                    repo.SaveOrUpdate(newTeam);
                    DialogResult result = MetroMessageBox.Show(this, "Team created!", "Success!", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {


                    }
                }
            }
        }
    }
}
