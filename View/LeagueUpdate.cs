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
    public partial class LeagueUpdate : MetroForm
    {
        private League league;
        public LeagueUpdate(League _league)
        {
            league = _league;
            InitializeComponent();
            Text = "Update league: "+league.Name;
            nameInput.Text = league.Name;
            descriptionInput.Text = league.Description;
        }

        private void LeagueUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
