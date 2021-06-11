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

namespace Fireman_Systemn.View.EditViews
{
    public partial class EditEmployeeView : Form
    {
        Employees oldEmployee;
        EmployeesController employeesController = new EmployeesController();

        public EditEmployeeView(Employees employee)
        {
            InitializeComponent();
            txt_box_name.Text = employee.first_name;
            txt_box_middleName.Text = employee.middle_name;
            txt_box_lastName.Text = employee.last_name;
            nud_age.Value = employee.age;
            txt_box_rank.Text = employee.rank;
            txt_box_homeAddress.Text = employee.home_address;
            txt_box_personalNum.Text = Convert.ToString(employee.personal_phone_number);
            txt_box_email.Text = employee.email;
            DateTimeStartBuisnessTrip.Value = employee.business_trip_start_date.Value;
            DateTimeEndBuisnessTrip.Value = employee.buisiness_trip_end_date.Value;
            DateTimeStartVacation.Value = employee.vacation_start_date.Value;
            DateTimeEndVacation.Value = employee.vacation_end_date.Value;
            
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                cb_choosen_team.DataSource = fse.Teams.ToList();
                cb_choosen_team.ValueMember = "team_id";
                cb_choosen_team.DisplayMember = "team_name";

                cb_choosen_team.SelectedValue = employee.Teams.team_id;
            }

            oldEmployee = employee;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new EmployeesView());
        }

        private void btn_edit_team_Click(object sender, EventArgs e)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                try
                {
                    oldEmployee.first_name = txt_box_name.Text.Trim().ToString();
                    oldEmployee.middle_name = txt_box_middleName.Text.Trim().ToString();
                    oldEmployee.last_name = txt_box_lastName.Text.Trim().ToString();
                    oldEmployee.age = Convert.ToInt32(nud_age.Value);
                    oldEmployee.rank = txt_box_rank.Text.Trim().ToString();
                    oldEmployee.home_address = txt_box_homeAddress.Text.Trim().ToString();
                    oldEmployee.personal_phone_number = Convert.ToInt32(txt_box_personalNum.Text);
                    oldEmployee.email = txt_box_email.Text.Trim().ToString();
                    oldEmployee.choosen_team = Convert.ToInt32(cb_choosen_team.SelectedValue);
                    oldEmployee.business_trip_start_date = DateTimeStartBuisnessTrip.Value;
                    oldEmployee.buisiness_trip_end_date = DateTimeEndBuisnessTrip.Value;
                    oldEmployee.vacation_start_date = DateTimeStartVacation.Value;
                    oldEmployee.vacation_end_date = DateTimeEndVacation.Value;

                    if (DateTime.Compare(DateTimeStartVacation.Value, DateTimeEndVacation.Value) > 0 || DateTime.Compare(DateTimeStartBuisnessTrip.Value, DateTimeEndBuisnessTrip.Value) > 0 || txt_box_personalNum.TextLength > 10 || !txt_box_email.Text.Contains('@'))
                    {
                        EnterValidData enterValidDataException = new EnterValidData();
                        enterValidDataException.ShowDialog();
                    }
                    else
                    {
                        employeesController.Update(oldEmployee);
                        SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                        successfullyAddedData.ShowDialog();
                        FormLayout.NavigateForms(this, new EmployeesView());
                    }
                }
                catch
                {
                    EnterValidData enterValidDataException = new EnterValidData();
                    enterValidDataException.ShowDialog();
                }
            }
        }

        private void EditEmployeeView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
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
