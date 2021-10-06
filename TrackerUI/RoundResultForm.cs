using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class RoundResultForm: Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();
        public RoundResultForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;
            WireUpLists();
            LoadFormData();
            //LoadRounds();
            LoadMatchups(1);
            LoadMatchups(2);
        }
        private void Tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }
        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }
        private void WireUpLists()
        {
   
        }
        private void LoadRounds()
        {

            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                   
                }
            }
            

        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    int count = round;
                    foreach (MatchupModel m in matchups)
                    {
                        
                        
                        selectedMatchups.Add(m);
                        LoadMatchup(m, count);
                        count = count * 3;
                    }
                }
            }
            


        }

        private void LoadMatchup(MatchupModel m, int count)
        {
            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (count == 1)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                            teamOneScoreValue.Text = m.Entries[0].Score.ToString();

                            teamTwoName.Text = "<bye>";
                            teamTwoScoreValue.Text = "";
                        }
                        else
                        {
                            teamOneName.Text = "Not Yet Set";
                            teamOneScoreValue.Text = "";
                        }
                    }
                    if (count == 3)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            team1Name.Text = m.Entries[0].TeamCompeting.TeamName;
                            team1ScoreValue.Text = m.Entries[0].Score.ToString();
                            team2Name.Text = m.Entries[1].TeamCompeting.TeamName;
                            team2ScoreValue.Text = m.Entries[1].Score.ToString();
                        }
                        else
                        {
                            team1Name.Text = "Not Yet Set";
                            team1ScoreValue.Text = "";
                        }
                    }
                    if (count == 2)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            leftWinner.Text = m.Entries[0].TeamCompeting.TeamName;
                            leftWinnerScoreValue.Text = m.Entries[0].Score.ToString();
                            rightWinner.Text = m.Entries[1].TeamCompeting.TeamName;
                            rightWinnerScoreValue.Text = m.Entries[1].Score.ToString();

                        }
                        else
                        {
                            leftWinner.Text = m.Entries[0].TeamCompeting.TeamName;
                            leftWinnerScoreValue.Text = m.Entries[0].Score.ToString();
                            rightWinner.Text = "Not Yet Set";
                            rightWinnerScoreValue.Text = "";
                        }
                    }
                    if (count == 6)
                    {
                        if (m.Entries[3].TeamCompeting != null)
                        {
                            team2Name.Text = m.Entries[3].TeamCompeting.TeamName;
                            team2ScoreValue.Text = m.Entries[3].Score.ToString();
                        }
                        else
                        {
                            team2Name.Text = "Not Yet Set";
                            team2ScoreValue.Text = "";
                        }
                    }
                }
            }

        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
      
        }
        private string ValidateData()
        {
            string output = "";
            double teamOneScore = 0;
            double teamTwoScore = 0;
            bool scoreOneValid = double.TryParse(leftWinnerScoreValue.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(rightWinnerScoreValue.Text, out teamTwoScore);
            if (!scoreOneValid)
            {
                output = "The Score One value is not a valid number.";
            }
            else if (!scoreTwoValid)
            {
                output = "The Score Two value is not a valid number.";
            }
            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "You did not enter a score for either team";
            }
            else if (teamOneScore == teamTwoScore)
            {
                output = "We do not allow ties in this application.";
            }
            return output;
        }
        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();

            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Input Error: { errorMessage }");
                return;
            }
           

        }
    }
}
