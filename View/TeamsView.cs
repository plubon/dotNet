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
        private Discipline discipline;
        public TeamsView(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            update();
            teamGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teamGrid.MultiSelect = false;
            teamGrid.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }
        private void TeamsView_Load(object sender, EventArgs e)
        {

        }
     
      
        private TeamRepository repo = new TeamRepository();
        private BindingSource bindingSource1 = new BindingSource();


        private void addTeam_Click(object sender, EventArgs e)
        {
            var view = new TeamCreate(discipline);
            view.Show();

        }

       
      
        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult res = MetroMessageBox.Show(this, "Do you really want to remove this team?", "Remove team.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                int row = teamGrid.CurrentCell.RowIndex;
                var ID = Int32.Parse(teamGrid[teamGrid.ColumnCount - 1, row].Value.ToString());
                Team handler = repo.GetById(ID);
                try
                {
                    repo.Delete(handler);
                }
                catch (Exception)
                {

                    MetroMessageBox.Show(this,
                      "We are sorry but the action couldn't be finished, please try again later and if the problem remains contact aout support team.",
                      "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                update();
            }
        }

        public void update()
        {
            teamGrid.DataSource = null;
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = repo.GetAll().Where(x=> x.Discipline!=null && x.Discipline.Id == discipline.Id);
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
            var view = new TeamCreate(discipline,handler);
            view.Show();
        }

        private void metroTile1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void teamGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showSellectedTeam(object sender, DataGridViewCellEventArgs e)
        {
            int row = teamGrid.CurrentCell.RowIndex;
            var ID = Int32.Parse(teamGrid[teamGrid.ColumnCount - 1, row].Value.ToString());
            Team handler = repo.GetById(ID);
            var view = new TeamShow(handler);
            view.Show();
        }


    }
}
