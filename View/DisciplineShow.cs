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
    public partial class DisciplineShow : MetroForm
    {
        private Discipline discipline;
        public DisciplineShow(Discipline _discipline)
        {
            discipline = _discipline;
            InitializeComponent();
            MediaTypeNames.Text = discipline.Name;
            description.Text = discipline.Description;
        }

        private void DisciplineShow_Load(object sender, EventArgs e)
        {

        }
    }
}
