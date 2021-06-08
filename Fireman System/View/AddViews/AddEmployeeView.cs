using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireman_Systemn.View.AddViews
{
    public partial class AddEmployeeView : Form
    {
        public AddEmployeeView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new EmployeesView());
        }

        private void AddEmployeeView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }
    }
}
