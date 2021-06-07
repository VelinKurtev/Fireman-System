using Fireman_Systemn.Controller;
using Fireman_Systemn.View.Pop_Ups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireman_Systemn.View.EditViews
{
    public partial class EditTeamView : Form
    {
        Teams oldTeam;
        TeamsController teamsController = new TeamsController(); 
        public EditTeamView(Teams Team)
        {
            InitializeComponent();
            txt_box_team_name.Text = Team.team_name;
            nud_employees_in_team.Value = Convert.ToInt32(Team.number_of_members);
            nud_answered_cases.Value = Convert.ToInt32(Team.number_of_answered_cases);
            cb_activity.SelectedItem = Team.is_team_active;
            cb_buisiness.SelectedItem = Team.is_team_busy;
            
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                cb_choosen_fireTruck.DataSource = fse.FireTrucks.ToList();
                cb_choosen_fireTruck.ValueMember = "fire_truck_id";
                cb_choosen_fireTruck.DisplayMember = "fire_truck_id";

                cb_choosen_fireTruck.SelectedValue = Team.FireTrucks.fire_truck_id;
            }
            oldTeam = Team;
        }

        private void EditTeamView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new TeamsView());
        }

        private void btn_edit_team_Click(object sender, EventArgs e)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                oldTeam.team_name = txt_box_team_name.Text;
                oldTeam.number_of_members = Convert.ToInt32(nud_employees_in_team.Value);
                oldTeam.number_of_answered_cases = Convert.ToInt32(nud_answered_cases.Value);
                oldTeam.is_team_active = cb_activity.SelectedItem.ToString();
                oldTeam.is_team_busy = cb_buisiness.SelectedItem.ToString();
                oldTeam.choosen_fire_truck = Convert.ToInt32(cb_choosen_fireTruck.SelectedValue);
            }

            if (txt_box_team_name.Text == string.Empty)
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
                FormLayout.NavigateForms(this, new TeamsView());
            }
            else
            {
                teamsController.Update(oldTeam);
                SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                successfullyAddedData.ShowDialog();
                FormLayout.NavigateForms(this, new TeamsView());
            }
        }
    }
}
