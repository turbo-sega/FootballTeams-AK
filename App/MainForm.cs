using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data;

namespace ConsoleApplication2
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<int, Team> _teamsIdMap = new Dictionary<int, Team>();

        public MainForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            teamsComboBox.Items.Clear();

            var teams = await Program.TeamsRepository.GeTeams();
            teams.ForEach(team =>
            {
                teamsComboBox.Items.Add(team.ToString());
                _teamsIdMap.Add(teamsComboBox.Items.Count-1, team);
            });
        }

        private async void teamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            coachesLabel.Text = $@"Тренер:";
            playersListBox.Items.Clear();
            statisticsRichTextBox.Clear();

            if (_teamsIdMap.ContainsKey(teamsComboBox.SelectedIndex))
            {
                var team = _teamsIdMap[teamsComboBox.SelectedIndex];
                coachesLabel.Text = $@"Тренер: {team.Coaches}";
                
                var players = await Program.TeamsRepository.GetTeamPlayers(team.Id);
                playersListBox.Items.Clear();
                playersListBox.Items.AddRange(players.Select(player => (object)player.ToString()).ToArray());

                var teamChampionships = await Program.TeamsRepository.GetTeamChampionships(team.Id);
                
                foreach (var teamChampionship in teamChampionships)
                {
                    statisticsRichTextBox.SuspendLayout();
                    statisticsRichTextBox.AppendText(Environment.NewLine);
                    statisticsRichTextBox.SelectionColor = Color.Blue;
                    statisticsRichTextBox.AppendText(teamChampionship.ToString());
                    statisticsRichTextBox.AppendText(Environment.NewLine);
                    
                    var teamStatistics = await Program.TeamsRepository.GetTeamStatistics(team.Id, teamChampionship.Id);
                    foreach (var teamStatistic in teamStatistics)
                    {
                        statisticsRichTextBox.SelectionColor = Color.CadetBlue;
                        statisticsRichTextBox.AppendText(teamStatistic.Years);
                        statisticsRichTextBox.AppendText(Environment.NewLine);
                    }
                    statisticsRichTextBox.ScrollToCaret();
                    statisticsRichTextBox.ResumeLayout();
                }

                SetBackgroundImage(team);
            }
            else
            {
                SetBackgroundImage();
            }
        }

        private void SetBackgroundImage(Team team = null)
        {
            var teamName = team?.Name ?? "";
            var bgImageName = "BackgroundImage";
            switch (teamName)
            {
                case "Ювентус":
                {
                    bgImageName = "ronaldo";
                    break;
                }
                case "Барселона":
                {
                    bgImageName = "messi";
                    break;
                }
                case "Ліверпуль":
                {
                    bgImageName = "salah";
                    break;
                }
            }

            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.BackgroundImage = (Image)resources.GetObject(bgImageName);
            this.pictureBox1.Visible = team == null;
        }
    }
}