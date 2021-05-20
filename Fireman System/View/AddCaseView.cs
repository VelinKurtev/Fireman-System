using Fireman_Systemn.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireman_Systemn.View
{
    public partial class Add_Case_View : Form
    {
        
        public Add_Case_View()
        {
            InitializeComponent();
            FillCombo();
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
            Cases Case = new Cases();
            Case.Region = txt_box_region.Text;
            Case.Town = txt_box_town.Text;
            Case.Street = txt_box_street.Text;
            Case.Neighborhood = txt_box_complex.Text;
            Case.Address_number = Convert.ToInt32(nud_building_number.Value);
            Case.Floor = Convert.ToInt32(nud_floor.Value);
            Case.Apartment = Convert.ToInt32(nud_floor.Value);
            Case.Case_type = txt_box_type_of_case.Text;
            Case.Dangerous_substances_info = txt_box_dangerous_substances.Text;
            Case.Selected_team = cb_choosen_team.SelectedIndex;
            Case.Date_time_of_case = start_date_case_time_picker.Value;
            Case.End_date_time_of_case = end_date_case_time_picker.Value;
            Case.Used_water_resources = Convert.ToInt32(nud_Used_water_resources);
        }
    }
}
