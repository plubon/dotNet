using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Model.Enitites;

namespace View
{
    class DisciplineItem : MetroTile
    {
        private Discipline discipline;

        public DisciplineItem(Discipline _discipline)
        {
            discipline = _discipline;
            Text = discipline.Name;
            Anchor = AnchorStyles.Top;
            

            Height = 100;
            Width = 200;

        }

        public Discipline getDiscipline()
        {
            return discipline;
        }
       
    }
}
