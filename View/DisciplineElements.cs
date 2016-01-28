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
using MetroFramework.Forms;
using Model.Enitites;

namespace View
{
    public partial class DisciplineElements : MetroForm
    {
        private Discipline discipline;
        public DisciplineElements(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            MediaTypeNames.Text = discipline.Name;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var view = new LeaguesView(discipline);
            view.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var view = new TeamsView(discipline);
            view.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            var view = new PlayersView();
            view.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            var view = new MatchesView(discipline);
            view.Show();
        }
    }
}
