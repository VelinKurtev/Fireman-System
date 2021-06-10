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
    public partial class EditFireTruckView : Form
    {
        FireTrucks oldFireTruck;
        FireTrucksController fireTrucksController = new FireTrucksController();

        public EditFireTruckView(FireTrucks fireTruck)
        {
            InitializeComponent();
            txt_box_model.Text = fireTruck.model;
            nud_water_capacity.Value = Convert.ToDecimal(fireTruck.water_capacity);
            nud_available_seats.Value = Convert.ToInt32(fireTruck.staff_capacity);
            nud_available_water.Value = Convert.ToDecimal(fireTruck.available_water);
            nud_available_fuel.Value = Convert.ToDecimal(fireTruck.available_fuel);
            nud_fuel_capacity.Value = Convert.ToDecimal(fireTruck.fuel_capacity);

            oldFireTruck = fireTruck;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new FireTrucksView());
        }

        private void EditFireTruckView_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_edit_case_Click(object sender, EventArgs e)
        {
            try
            {
                oldFireTruck.model = txt_box_model.Text.Trim().ToString();
                oldFireTruck.water_capacity = Convert.ToDouble(nud_water_capacity.Value);
                oldFireTruck.staff_capacity = Convert.ToInt32(nud_available_seats.Value);
                oldFireTruck.available_water = Convert.ToDouble(nud_available_water.Value);
                oldFireTruck.fuel_capacity = Convert.ToDouble(nud_fuel_capacity.Value);
                oldFireTruck.available_fuel = Convert.ToDouble(nud_available_fuel.Value);

                if (txt_box_model.Text == string.Empty || nud_available_water.Value > nud_water_capacity.Value || nud_available_fuel.Value > nud_fuel_capacity.Value)
                {
                    EnterValidData enterValidDataException = new EnterValidData();
                    enterValidDataException.ShowDialog();

                }
                else
                {
                    fireTrucksController.Update(oldFireTruck);
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
    }
}
