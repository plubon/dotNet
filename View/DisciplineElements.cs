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

namespace View
{
    public partial class DisciplineElements : MetroForm
    {
        private Discipline discipline;
        public DisciplineElements(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            Text = discipline.Name;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var view = new LeaguesView(discipline);
            view.Show();
        }
    }
}
