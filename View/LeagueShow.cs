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
    public partial class LeagueShow : MetroForm
    {
        League handler = null;
        private BindingSource bindingSourceMathces = new BindingSource();
        public LeagueShow(League _handler)
        {
            handler = _handler;
            InitializeComponent();
            Text = handler.Name;
            descriptionText.Text = handler.Description;
            disciplineLabel.Text = handler.Discipline.Name;
            bindingSourceMathces.DataSource = handler.Matches;
            matchesGrid.DataSource = bindingSourceMathces;
        }

        private void LeagueShow_Load(object sender, EventArgs e)
        {

        }
    }
}
