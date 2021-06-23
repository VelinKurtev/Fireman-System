using System;
using System.Linq;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.Pop_Ups;
namespace Fireman_Systemn.View
{
    public partial class Add_Case_View : Form
    {
        Cases Case = new Cases();
        CasesController CaseController = new CasesController();

        public Add_Case_View()
        {
            InitializeComponent();
            FillCombo();
        }

        private void FillCombo()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                cb_choosen_team.DataSource = fse.Teams.Where(t => t.is_team_active == "Активен" && t.is_team_busy == "Свободен").ToList();
                cb_choosen_team.ValueMember = "team_id";
                cb_choosen_team.DisplayMember = "team_name";
            }
        }

        private void Add_Case_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }

        private void btn_submit_case_Click(object sender, EventArgs e)
        {
            Case.Region = txt_box_region.Text.Trim().ToString();
            Case.Town = txt_box_town.Text.Trim().ToString();
            Case.Street = txt_box_street.Text.Trim().ToString();
            Case.Neighborhood = txt_box_complex.Text.Trim().ToString();
            Case.Address_number = Convert.ToInt32(nud_building_number.Value);
            Case.Floor = Convert.ToInt32(nud_floor.Value);
            Case.Apartment = Convert.ToInt32(nud_floor.Value);
            Case.Case_type = txt_box_type_of_case.Text.Trim().ToString();
            Case.Dangerous_substances_info = txt_box_dangerous_substances.Text.Trim().ToString();
            Case.Selected_team = Convert.ToInt32(cb_choosen_team.SelectedValue);
            Case.Date_time_of_case = start_date_case_time_picker.Value;
            Case.Used_water_resources = Convert.ToDouble(nud_Used_water_resources.Value);
            Case.Used_fuel = Convert.ToDouble(nud_used_fuel.Value);

            if (txt_box_region.Text == string.Empty || txt_box_town.Text == string.Empty || 
                txt_box_street.Text == string.Empty || txt_box_type_of_case.Text == string.Empty || 
                cb_choosen_team.SelectedItem == null)
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
            }
            else
            {
                using (FiremanSysEntities fse = new FiremanSysEntities())
                {
                    var team = fse.Teams.Where(t => t.team_id == Case.Selected_team).FirstOrDefault();
                    var fireTruck = fse.FireTrucks.Where(c => c.fire_truck_id == team.choosen_fire_truck).FirstOrDefault();

                    if (team != null && fireTruck != null)
                    {
                        ++team.number_of_answered_cases; 
                        ++fireTruck.answered_cases;
                        if (fireTruck.available_fuel >= Convert.ToDouble(nud_used_fuel.Value))
                        {
                            fireTruck.available_fuel = fireTruck.available_fuel - Convert.ToDouble(nud_used_fuel.Value);
                        }
                        else
                        {
                            //pop-up
                        }

                        if (fireTruck.available_water >= Convert.ToDouble(nud_Used_water_resources.Value))
                        {
                            fireTruck.available_water = fireTruck.available_water - Convert.ToDouble(nud_Used_water_resources.Value);
                        }

                        team.is_team_busy = "Зает";
                       
                        fse.Teams.Attach(team);
                        fse.Entry(team).State = System.Data.Entity.EntityState.Modified;
                        fse.SaveChanges();

                        fse.FireTrucks.Attach(fireTruck);
                        fse.Entry(fireTruck).State = System.Data.Entity.EntityState.Modified;
                        fse.SaveChanges();

                        foreach (var employee in team.Employees)
                        {
                            ++employee.number_of_answered_cases;

                            fse.Employees.Attach(employee);
                            fse.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                            fse.SaveChanges();
                        }
                    }
                }

                CaseController.Insert(Case);
                SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                successfullyAddedData.ShowDialog();
                FormLayout.NavigateForms(this, new CasesView());
            }

        }

    }
}
