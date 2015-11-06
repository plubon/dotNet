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
    public partial class LeaguesView : MetroForm
    {
        private Discipline discipline;
        private BindingSource bindingSource1 = new BindingSource();
        private LeagueRepository repo = new LeagueRepository();
        public LeaguesView(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            Text = discipline.Name + " Leagues:";
            leaguesGrid.AutoGenerateColumns = true;
            bindingSource1.DataSource = repo.GetAll().Where(x => x.Discipline.Id == discipline.Id);
            System.Console.Write(discipline+"\n");
            //TODO coś jest nie tak, źle tworzy Ligi, mimo że dodaje poprawną dyscyplinę to dą jakieś problemy
            leaguesGrid.DataSource = bindingSource1;
        

        }

        private void addLeague_Click(object sender, EventArgs e)
        {
            var view = new LeagueCreate(discipline);
            System.Console.Write(discipline.Name);
            view.Show();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            update();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int row = leaguesGrid.CurrentCell.RowIndex;
            var ID = Int32.Parse(leaguesGrid[leaguesGrid.ColumnCount - 1, row].Value.ToString());
            League handler = repo.GetById(ID);
            var view = new LeagueUpdate(handler);
            view.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult res = MetroMessageBox.Show(this, "Do you really want to remove this league?", "Remove league.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                int row = leaguesGrid.CurrentCell.RowIndex;
                var ID = Int32.Parse(leaguesGrid[leaguesGrid.ColumnCount - 1, row].Value.ToString());
                League handler = repo.GetById(ID);
                repo.Delete(handler);
                update();
            }
        }

        public void update()
        {
            leaguesGrid.DataSource = null;
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = repo.GetAll().Where(x => x.Discipline.Id == discipline.Id);
            leaguesGrid.DataSource = bindingSource1;
        }

    }
}
