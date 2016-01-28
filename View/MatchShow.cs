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
    public partial class MatchShow : MetroForm
    {
        private Match handler = null;
        public MatchShow(Match _handler)
        {
            handler = _handler;
            InitializeComponent();
            MediaTypeNames.Text = handler.HomeTeam.Name + " against " + handler.AwayTeam.Name;
            homeTeamLabel.Text = handler.HomeTeam.Name;
            homeTeamResultLabel.Text = handler.HomeTeamScore.ToString();
            awayTeamLabel.Text = handler.AwayTeam.Name;
            awayTeamResultLabel.Text = handler.AwayTeamScore.ToString();
            dateLabel.Text = handler.Date.ToString();
        }

        private void MatchShow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
