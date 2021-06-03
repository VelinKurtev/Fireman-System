using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fireman_Systemn.Controller;

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
                cb_choosen_fireTruck.DisplayMember = "fire_truck_id";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }

        private void AddTeamView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_submit_case_Click(object sender, EventArgs e)
        {
            
        }
    }
}
