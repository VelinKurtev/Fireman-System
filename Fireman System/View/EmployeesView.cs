using Fireman_Systemn.Controller;
using Fireman_Systemn.View.AddViews;
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

namespace Fireman_Systemn.View
{
    public partial class EmployeesView : Form
    {
        EmployeesController employeesController = new EmployeesController(); 
        public EmployeesView()
        {
            InitializeComponent();
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
            Refresh_table();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }

        private void Refresh_table()
        {
            dgvEmployees.DataSource = employeesController.GetAll();
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new AddEmployeeView());
        }

        private void btn_update_employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_employee_Click(object sender, EventArgs e)
        {
            var row = dgvEmployees.CurrentRow;
            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
                FormLayout.NavigateForms(this, new EmployeesView());
            }
            else
            {
                int id = int.Parse(row.Cells["EmployeeID"].Value.ToString());
                employeesController.Delete(id);
                Refresh_table();
            }
        }
    }
}
