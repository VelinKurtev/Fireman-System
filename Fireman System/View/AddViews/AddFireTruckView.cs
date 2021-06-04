using System;
using System.Windows.Forms;
using Fireman_Systemn.Controller;

namespace Fireman_Systemn.View
{
    public partial class AddFireTruckView : Form
    {
        FireTrucks fireTruck = new FireTrucks();
        FireTrucksController FireTruckController = new FireTrucksController();

        public AddFireTruckView()
        {
            InitializeComponent();
        }

        private void btn_submit_case_Click(object sender, EventArgs e)
        {
            fireTruck.model = txt_box_model.Text.Trim().ToString();
            fireTruck.water_capacity = (double)nud_water_capacity.Value;
            fireTruck.staff_capacity = Convert.ToInt32(nud_available_seats.Value);
            fireTruck.available_water = (double)nud_available_water.Value;
            fireTruck.fuel_capacity = (double)nud_fuel_capacity.Value;
            fireTruck.available_fuel = (double)nud_available_fuel.Value;

            FireTruckController.Insert(fireTruck);
            MessageBox.Show("Added Automobile!");
            FormLayout.NavigateForms(this, new FireTrucksView());

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new FireTrucksView());
        }

        private void AddFireTruckView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }
    }
}
