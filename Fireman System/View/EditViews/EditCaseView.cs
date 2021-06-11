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
    public partial class EditCaseView : Form
    {

        Cases oldCase;
        CasesController CaseController = new CasesController();
        public EditCaseView(Cases Case)
        {
            InitializeComponent();

            txt_box_region.Text = Case.Region;
            txt_box_street.Text = Case.Street;
            txt_box_town.Text = Case.Town;
            txt_box_type_of_case.Text = Case.Case_type;
            txt_box_dangerous_substances.Text = Case.Dangerous_substances_info;
            nud_building_number.Value = Case.Address_number;
            nud_floor.Value = Convert.ToInt32(Case.Floor);
            nud_Apartment.Value = Convert.ToInt32(Case.Apartment);
            nud_used_fuel.Value = Convert.ToDecimal(Case.Used_fuel);
            nud_Used_water_resources.Value = Convert.ToDecimal(Case.Used_water_resources);
            end_date_case_time_picker.Value = Case.End_date_time_of_case;
            start_date_case_time_picker.Value = Case.Date_time_of_case;
            txt_box_complex.Text = Case.Neighborhood;

            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                cb_choosen_team.DataSource = fse.Teams.Where(t => t.is_team_active == "Активен" && t.is_team_busy == "Свободен").ToList();
                cb_choosen_team.ValueMember = "team_id";
                cb_choosen_team.DisplayMember = "team_name";

                cb_choosen_team.SelectedValue = Case.Teams.team_id; 
            }
            oldCase = Case;
        }

        private void Edit_Case_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new CasesView());
        }

        private void btn_edit_case_Click(object sender, EventArgs e)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                oldCase.Region = txt_box_region.Text.Trim().ToString();
                oldCase.Town = txt_box_town.Text.Trim().ToString();
                oldCase.Street = txt_box_street.Text.Trim().ToString();
                oldCase.Neighborhood = txt_box_complex.Text.Trim().ToString();
                oldCase.Address_number = Convert.ToInt32(nud_building_number.Value);
                oldCase.Floor = Convert.ToInt32(nud_floor.Value);
                oldCase.Apartment = Convert.ToInt32(nud_Apartment.Value);
                oldCase.Case_type = txt_box_type_of_case.Text.Trim().ToString();
                oldCase.Dangerous_substances_info = txt_box_dangerous_substances.Text.Trim().ToString();
                oldCase.Selected_team = Convert.ToInt32(cb_choosen_team.SelectedValue);
                oldCase.Date_time_of_case = start_date_case_time_picker.Value;
                oldCase.End_date_time_of_case = end_date_case_time_picker.Value;
                oldCase.Used_water_resources = Convert.ToDouble(nud_Used_water_resources.Value);
                oldCase.Used_fuel = Convert.ToDouble(nud_used_fuel.Value);
            }

            if (txt_box_region.Text == string.Empty || txt_box_town.Text == string.Empty || txt_box_street.Text == string.Empty || txt_box_type_of_case.Text == string.Empty)
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
                FormLayout.NavigateForms(this, new CasesView());
            }
            else if (DateTime.Compare(start_date_case_time_picker.Value, end_date_case_time_picker.Value) > 0 || DateTime.Compare(start_date_case_time_picker.Value, end_date_case_time_picker.Value) == 0)
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
                FormLayout.NavigateForms(this, new CasesView());
            }
            else
            {
                CaseController.Update(oldCase);
                SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                successfullyAddedData.ShowDialog();
                FormLayout.NavigateForms(this, new CasesView());
            }
        }
    }
}
