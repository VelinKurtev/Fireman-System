using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Fireman_Systemn.View;

namespace Fireman_Systemn
{
    public partial class MainMenu : Form
    {
        Thread thread;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Btn_view_teams(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new Teams_and_Employees());
        }

        private void btn_view_cases_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new Cases());
        }

        private void btn_view_firetrucks_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new FireTrucks());
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }
    }
}
