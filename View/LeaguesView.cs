using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Model.Enitites;
using Repository;

namespace View
{
    public partial class LeaguesView : MetroForm
    {
        private Discipline discipline;
        private BindingSource bindingSource1 = new BindingSource();
        public LeaguesView(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            Text = discipline.Name + " Leagues:";
            LeagueRepository repo = new LeagueRepository();
            leaguesGrid.AutoGenerateColumns = true;
            bindingSource1.DataSource = repo.GetAll().Where(x=> x.Discipline.Id==discipline.Id);
            //TODO coś jest nie tak, źle tworzy Ligi, mimo że dodaje poprawną dyscyplinę to dą jakieś problemy
            leaguesGrid.DataSource = bindingSource1;
            foreach (League source in bindingSource1)
            {
              //  Console.Write("Name: "+source.Name+" Discipline: "+source.Discipline);
            }

        }

        private void addLeague_Click(object sender, EventArgs e)
        {
            var view = new LeagueCreate(discipline);
            System.Console.Write(discipline.Name);
            view.Show();

        }

    }
}
