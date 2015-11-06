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
    public partial class MatchesView : MetroForm
    {
        private MatchRepository repo = new MatchRepository();
        private BindingSource bindingSource1 = new BindingSource();
        private Discipline discipline;
 
        public MatchesView(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            bindingSource1.DataSource = repo.GetAll().Where(x => x.League != null && x.League.Discipline.Id == discipline.Id);
            matchesGrid.DataSource = bindingSource1;
            matchesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            matchesGrid.MultiSelect = false;
            matchesGrid.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }
        public void update()
        {
            matchesGrid.DataSource = null;
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = repo.GetAll().Where(x => x.League != null && x.League.Discipline.Id == discipline.Id);
            matchesGrid.DataSource = bindingSource1;
        }
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void MatchesView_Load(object sender, EventArgs e)
        {

        }

        private void addTeam_Click(object sender, EventArgs e)
        {
            var view = new MatchCreate(discipline);
            view.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int row = matchesGrid.CurrentCell.RowIndex;
            var ID = Int32.Parse(matchesGrid[matchesGrid.ColumnCount - 1, row].Value.ToString());
            Match handler = repo.GetById(ID);
            var view = new MatchCreate(discipline,handler);
            view.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DialogResult res = MetroMessageBox.Show(this, "Do you really want to remove this match?", "Remove match.",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                int row = matchesGrid.CurrentCell.RowIndex;
                var ID = Int32.Parse(matchesGrid[matchesGrid.ColumnCount - 1, row].Value.ToString());
                Match handler = repo.GetById(ID);
                try
                {
                    repo.Delete(handler);
                }
                catch (Exception)
                {

                    MetroMessageBox.Show(this,
                       "We are sorry but you can't delete element which other elements depend on. Please remove all elements depending on this one and then try again.",
                       "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
                update();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void showSelectedMatch(object sender, DataGridViewCellEventArgs e)
        {

            int row = matchesGrid.CurrentCell.RowIndex;
            var ID = Int32.Parse(matchesGrid[matchesGrid.ColumnCount - 1, row].Value.ToString());
            Match handler = repo.GetById(ID);
            var view = new MatchShow(handler);
            view.Show();
        }
    }
}
