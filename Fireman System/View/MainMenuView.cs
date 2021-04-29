using System;
using System.Windows.Forms;
using Fireman_Systemn.View;

namespace Fireman_Systemn
{
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void Btn_view_teams(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new TeamsView());
        }

        private void btn_view_cases_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new CasesView());
        }

        private void btn_view_firetrucks_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new FireTrucksView());
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_view_employees_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new EmployeesView());
        }

        private void btn_add_case_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new Add_Case_View());
        }

    }
}
