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
using Repository;

namespace View
{
    public partial class TeamShow : MetroForm
    {
        private Team handler = null;
        private BindingSource bindingSourceHome = new BindingSource();
        private BindingSource bindingSourceAway = new BindingSource();
        private BindingSource bindingSourcePlayers = new BindingSource();

        private MatchRepository matchesRepo = new MatchRepository();
        public TeamShow(Team _handler)
        {
            handler = _handler;
            InitializeComponent();
            MediaTypeNames.Text = handler.Name;
            Name = handler.Name;
            nameLabel.Text = handler.Name;
            
            homeMatchesGrid.DataSource = null;
            bindingSourceHome = new BindingSource();
            bindingSourceHome.DataSource = handler.HomeMatches;
            homeMatchesGrid.DataSource = bindingSourceHome;

            awayMatchesGrid.DataSource = null;
            bindingSourceAway = new BindingSource();
            bindingSourceAway.DataSource = handler.AwayMatches;
            awayMatchesGrid.DataSource = bindingSourceAway;

            playersGrid.DataSource = null;
            bindingSourcePlayers = new BindingSource();
            bindingSourcePlayers.DataSource = handler.Players;
            playersGrid.DataSource = bindingSourcePlayers;
        }

        private void TeamShow_Load(object sender, EventArgs e)
        {

        }
    }
}
