using System;
using System.Linq;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.Pop_Ups;

namespace Fireman_Systemn.View.AddViews
{
    public partial class AddTeamView : Form
    {
        Teams Team = new Teams();
        TeamsController teamsController = new TeamsController();

        public AddTeamView()
        {
            InitializeComponent();
            FillCombo();
        }

        private void FillCombo()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                cb_choosen_fireTruck.DataSource = fse.FireTrucks.ToList();
                cb_choosen_fireTruck.ValueMember = "fire_truck_id";
                cb_choosen_fireTruck.DisplayMember = "model";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new TeamsView());
        }

        private void AddTeamView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_submit_team_Click(object sender, EventArgs e)
        {
            try
            {
                Team.team_name = txt_box_team_name.Text.Trim().ToString();
                Team.number_of_members = Convert.ToInt32(nud_employees_in_team.Value);
                Team.choosen_fire_truck = Convert.ToInt32(cb_choosen_fireTruck.SelectedValue);
                Team.is_team_active = "Активен";
                Team.is_team_busy = "Свободен";

                if (txt_box_team_name.Text == string.Empty || cb_choosen_fireTruck.SelectedItem == null)
                {
                    EnterValidData enterValidDataException = new EnterValidData();
                    enterValidDataException.ShowDialog();
                }
                else
                {
                    teamsController.Insert(Team);
                    SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                    successfullyAddedData.ShowDialog();
                    FormLayout.NavigateForms(this, new TeamsView());
                }
            }
            catch
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
            }
        }
    }
}
