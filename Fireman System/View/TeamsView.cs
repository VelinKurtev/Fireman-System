using System;
using System.Linq;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.AddViews;
using Fireman_Systemn.View.EditViews;
using Fireman_Systemn.View.Pop_Ups;

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
            var row = dgvTeams.CurrentRow;
            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
                FormLayout.NavigateForms(this, new TeamsView());
            }
            else
            {
                int id = int.Parse(row.Cells["TeamID"].Value.ToString());
                teamsController.Delete(id);
                Refresh_table();
            }
        }

        private void btn_update_table_Click(object sender, EventArgs e)
        {
            var row = dgvTeams.CurrentRow;
            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
                FormLayout.NavigateForms(this, new TeamsView());
            }
            else
            {
                int id = int.Parse(row.Cells["TeamID"].Value.ToString());
                using (FiremanSysEntities fse = new FiremanSysEntities())
                {
                    var team = fse.Teams.Where(t => t.team_id == id).FirstOrDefault();
                    FormLayout.NavigateForms(this, new EditTeamView(team));
                }
            }

        }
    }
}
