using System;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.AddViews;

namespace Fireman_Systemn.View
{
    public partial class TeamsView : Form
    {
        TeamsController teamsController = new TeamsController();
        public TeamsView()
        {
            InitializeComponent();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }

        private void Teams_and_Employees_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
            Refresh_table();
        }

        private void Refresh_table()
        {
            dgvTeams.DataSource = teamsController.GetAll();
        }

        private void btn_add_team_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new AddTeamView());
        }

        private void btn_delete_team_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgvTeams.CurrentRow;
                int id = int.Parse(row.Cells["TeamID"].Value.ToString());
                teamsController.Delete(id);
                Refresh_table();
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Row Selected!", ex);
            }
        }

        private void btn_update_table_Click(object sender, EventArgs e)
        {

        }
    }
}
