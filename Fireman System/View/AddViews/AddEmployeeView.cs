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

namespace Fireman_Systemn.View.AddViews
{
    public partial class AddEmployeeView : Form
    {
        Employees Employee = new Employees();
        EmployeesController employeesController = new EmployeesController();

        public AddEmployeeView()
        {
            InitializeComponent();
            FillCombo();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new EmployeesView());
        }

        private void AddEmployeeView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_submit_team_Click(object sender, EventArgs e)
        {
            try
            {
                Employee.first_name = txt_box_name.Text.Trim().ToString();
                Employee.middle_name = txt_box_middleName.Text.Trim().ToString();
                Employee.last_name = txt_box_lastName.Text.Trim().ToString();
                Employee.age = Convert.ToInt32(nud_age.Value);
                Employee.rank = txt_box_rank.Text.Trim().ToString();
                Employee.home_address = txt_box_homeAddress.Text.Trim().ToString();
                Employee.personal_phone_number = Convert.ToInt32(txt_box_personalNum.Text);
                Employee.email = txt_box_email.Text.Trim().ToString();
                Employee.number_of_answered_cases = Convert.ToInt32(nud_answered_cases.Value);
                Employee.choosen_team = Convert.ToInt32(cb_choosen_team.SelectedValue);
                Employee.business_trip_start_date = DateTimeStartBuisnessTrip.Value;
                Employee.buisiness_trip_end_date = DateTimeEndBuisnessTrip.Value;
                Employee.vacation_start_date = DateTimeStartVacation.Value;
                Employee.vacation_end_date = DateTimeEndVacation.Value;

               
            }
            catch
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
                FormLayout.NavigateForms(this, new AddEmployeeView());
            }

            if (DateTime.Compare(DateTimeStartVacation.Value, DateTimeEndVacation.Value) > 0 || DateTime.Compare(DateTimeStartVacation.Value, DateTimeEndVacation.Value) == 0 || DateTime.Compare(DateTimeStartBuisnessTrip.Value, DateTimeEndBuisnessTrip.Value) > 0 || DateTime.Compare(DateTimeStartBuisnessTrip.Value, DateTimeEndBuisnessTrip.Value) == 0)
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
                FormLayout.NavigateForms(this, new AddEmployeeView());
            }
            else
            {
                employeesController.Insert(Employee);
                SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                successfullyAddedData.ShowDialog();
                FormLayout.NavigateForms(this, new EmployeesView());
            }
            

        }

        private void FillCombo()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                cb_choosen_team.DataSource = fse.Teams.ToList();
                cb_choosen_team.ValueMember = "team_id";
                cb_choosen_team.DisplayMember = "team_name";
            }
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_box_personalNum.Text, "[^0-9]"))
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
                txt_box_personalNum.Text = txt_box_personalNum.Text.Remove(txt_box_personalNum.Text.Length - 1);
            }
        }
    }
}
