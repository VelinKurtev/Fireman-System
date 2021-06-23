using Fireman_Systemn.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireman_Systemn.View
{
    public partial class EmployeesByCaseView : Form
    {
        EmployeesController employeesController = new EmployeesController();
        public EmployeesByCaseView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new EmployeesView());
        }

        private void EmployeesByCaseView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
            Refresh_table();
        }

        private void Refresh_table()
        {
            dgvEmployeesByCase.DataSource = employeesController.GetAllEmployeesByCases();
        }
    }
}
