using System;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.Pop_Ups;

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
            try
            {
                fireTruck.model = txt_box_model.Text.Trim().ToString();
                fireTruck.water_capacity = Convert.ToDouble(nud_water_capacity.Value);
                fireTruck.staff_capacity = Convert.ToInt32(nud_available_seats.Value);
                fireTruck.available_water = Convert.ToDouble(nud_available_water.Value);
                fireTruck.fuel_capacity = Convert.ToDouble(nud_fuel_capacity.Value);
                fireTruck.available_fuel = Convert.ToDouble(nud_available_fuel.Value);

                if (txt_box_model.Text == string.Empty || nud_available_water.Value > nud_water_capacity.Value || nud_available_fuel.Value > nud_fuel_capacity.Value)
                {
                    EnterValidData enterValidDataException = new EnterValidData();
                    enterValidDataException.ShowDialog();

                }
                else
                {
                    FireTruckController.Insert(fireTruck);
                    SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                    successfullyAddedData.ShowDialog();
                    FormLayout.NavigateForms(this, new FireTrucksView());
                }
            }
            catch 
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
                FormLayout.NavigateForms(this, new FireTrucksView());
            }
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
