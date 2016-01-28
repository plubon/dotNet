using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework;
using MetroFramework.Forms;
using Model.Enitites;
using Repository;

namespace View
{
    public partial class MatchCreate : MetroForm
    {
        private MatchRepository repo = new MatchRepository();
        private TeamRepository teamRepository = new TeamRepository();
        private LeagueRepository leagueRepository = new LeagueRepository();
        private Match handle = null;
        private Boolean validate()
        {
            Boolean result = !((teamHomeBox.SelectedIndex <= -1) || (teamAwayBox.SelectedIndex <= -1) || 
                                (teamHomeBox.SelectedIndex == teamAwayBox.SelectedIndex) || (team1Score.Value < 0) || (team2Score.Value < 0)); 
            return result;
        }
        public MatchCreate(Discipline discipline)
        {
            InitializeComponent();
            foreach (Team team in discipline.Teams)
            {
                teamHomeBox.Items.Add(team);
                teamAwayBox.Items.Add(team);
            }
            foreach (League league in discipline.Leagues)
            {
                leagueBox.Items.Add(league);
            }
        }

        public MatchCreate(Discipline discipline, Match _handle)
        {
            handle = _handle;
            InitializeComponent();
            foreach (Team team in discipline.Teams)
            {
                teamHomeBox.Items.Add(team);
                teamAwayBox.Items.Add(team);
            }
            foreach (League league in discipline.Leagues)
            {
                leagueBox.Items.Add(league);
            }

            teamHomeBox.SelectedItem = handle.HomeTeamScore;
            teamAwayBox.SelectedItem = handle.AwayTeam;
            team1Score.Value = handle.HomeTeamScore.Value;
            team2Score.Value = handle.AwayTeamScore.Value;
            matchDate.Value = handle.Date;
        }

        private void MatchCreate_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (handle == null)
                {
                    Match newMatch = new Match();
                    newMatch.HomeTeamScore = (int) team1Score.Value;
                    newMatch.AwayTeamScore = (int) team2Score.Value;
                    newMatch.Date = matchDate.Value;
                    newMatch.HomeTeam = ((Team) teamHomeBox.SelectedItem);
                    newMatch.AwayTeam = (Team) teamAwayBox.SelectedItem;
                    newMatch.League = (League) leagueBox.SelectedItem;
                    repo.SaveOrUpdate(newMatch);

                    DialogResult result = MetroMessageBox.Show(this, "Match created!", "Success!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {


                    }
                }
                else
                {
                    handle.HomeTeamScore = (int)team1Score.Value;
                    handle.AwayTeamScore = (int)team2Score.Value;
                    handle.Date = matchDate.Value;
                    handle.HomeTeam = ((Team)teamHomeBox.SelectedItem);
                    handle.AwayTeam = (Team)teamAwayBox.SelectedItem;
                    handle.League = (League) leagueBox.SelectedItem;
                    repo.SaveOrUpdate(handle);

                    DialogResult result = MetroMessageBox.Show(this, "Match created!", "Success!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {


                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Data not valid.", "Validation failed.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            VisualStyleElement.ToolTip.Close();
        }
    }
}
