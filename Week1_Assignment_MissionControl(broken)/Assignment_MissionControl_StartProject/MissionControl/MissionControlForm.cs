using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionControl
{
    public partial class MissionControlForm : Form
    {
        Manager MM;
        public MissionControlForm()
        {
            InitializeComponent();
            MM = new Manager();
            PopulateComboBox();
            cbAstronautGender.SelectedIndex = 0;
        }

        private void PopulateComboBox()
        {
            cbAstronautGender.Items.Clear();
            cbAstronautGender.Items.Add(Gender.MALE);
            cbAstronautGender.Items.Add(Gender.FEMALE);
            cbAstronautGender.Items.Add(Gender.UNKOWN);

            cbAstronauts.Items.Clear();
            cbAstronautDetails.Items.Clear();
            List<Astronaut> astronautList = MM.GetAstronauts();
            astronautList.Sort();
            foreach(Astronaut a in astronautList)
            {
                cbAstronauts.Items.Add(a.Name);
                cbAstronautDetails.Items.Add(a.Name);
            }

            cbMissions.Items.Clear();
            List<Mission> missionList = MM.GetMissions();
            missionList.Sort();
            foreach(Mission m in missionList)
            {
                cbMissions.Items.Add(m.Name);
            }
        }

        private void btAddAstronaut_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAstronautName.Text) || String.IsNullOrEmpty(tbAstronautNationality.Text))
            {
                MessageBox.Show("Please fill in all fields before clicking the button");
                return;
            }


            Astronaut a = new Astronaut(tbAstronautName.Text, (Gender)cbAstronautGender.SelectedIndex, tbAstronautNationality.Text);
            if (MM.AddAstronaut(a) == true)
            {
                PopulateComboBox();
                return;
            }
            MessageBox.Show("Astronaut already exists");
        }

        private void btShowAllMissions_Click(object sender, EventArgs e)
        {
            lbMissions.Items.Clear();
            List<Mission> missionList = MM.GetMissions();
            missionList.Sort();
            foreach(Mission m in missionList)
            {
                lbMissions.Items.Add(m);
            }
        }

        private void btAddMission_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbMissionName.Text) || String.IsNullOrEmpty(tbSpaceship.Text))
            {
                MessageBox.Show("Please fill in all fields before clicking the button");
                return;
            }

            Mission m = new Mission(tbMissionName.Text, dtpLaunchDate.Value, dtpReturnDate.Value, tbSpaceship.Text);
            if (MM.AddMission(m))
            {
                PopulateComboBox();
                return;
            }
            MessageBox.Show("Mission already exists");
        }

        private void btAssign_Click(object sender, EventArgs e)
        {
            Mission m = MM.GetMission((String)cbMissions.SelectedItem);
            Astronaut a = MM.GetAstronaut((String)cbAstronauts.SelectedItem);
            if (!m.AddAstronautToMission(a))
            {
                MessageBox.Show("Astronaut is already in this mission");
                return;
            }
            else if (!a.AddMissionToAstronaut(m))
            {
                MessageBox.Show("Mission is already added to the astronaut");
                return;
            }         
        }

        private void btShowAstronautDetails_Click(object sender, EventArgs e)
        {
            Astronaut a = MM.GetAstronaut((String)cbAstronautDetails.SelectedItem);
            TimeSpan daysInSpace = new TimeSpan();
            TimeSpan longestMission = new TimeSpan(0);
            lbMissionHistory.Items.Clear();
            lbTravelCompanions.Items.Clear();
            foreach(Mission m in a.GetMissionsForAstronaut())
            {
                lbMissionHistory.Items.Add(m);
                daysInSpace += m.GetFlightDuration();
                if(m.GetFlightDuration() > longestMission)
                {
                    longestMission = m.GetFlightDuration();
                }
                foreach(Astronaut Na in m.GetAstronautsForThisMission())
                {
                    if(Na != a)
                    {
                        if (!lbTravelCompanions.Items.Contains(Na))
                        {
                            lbTravelCompanions.Items.Add(Na.Name);
                        }
                    }
                }
            }
            tbDaysInSpace.Text = Convert.ToString(daysInSpace.Days);
            tbLongestMission.Text = Convert.ToString(longestMission.Days);
        }
    }
}
