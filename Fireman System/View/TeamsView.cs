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

namespace Fireman_Systemn.View
{
    public partial class TeamsView : Form
    {
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
        }
    }
}
