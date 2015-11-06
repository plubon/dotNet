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
    public partial class TeamsView : MetroForm
    {
        public TeamsView()
        {
            InitializeComponent();
            update();
        }

        private void TeamsView_Load(object sender, EventArgs e)
        {

        }
     
      
        private TeamRepository repo = new TeamRepository();
        private BindingSource bindingSource1 = new BindingSource();


        private void addTeam_Click(object sender, EventArgs e)
        {
            var view = new TeamCreate();
            view.Show();

        }

       
      
        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult res = MetroMessageBox.Show(this, "Do you really want to remove this league?", "Remove league.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                int row = teamGrid.CurrentCell.RowIndex;
                var ID = Int32.Parse(teamGrid[teamGrid.ColumnCount - 1, row].Value.ToString());
                Team handler = repo.GetById(ID);
                repo.Delete(handler);
                update();
            }
        }

        public void update()
        {
            teamGrid.DataSource = null;
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = repo.GetAll();
            teamGrid.DataSource = bindingSource1;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            update();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            int row = teamGrid.CurrentCell.RowIndex;
            var ID = Int32.Parse(teamGrid[teamGrid.ColumnCount - 1, row].Value.ToString());
            Team handler = repo.GetById(ID);
            var view = new TeamCreate(handler);
            view.Show();
        }


    }
}
