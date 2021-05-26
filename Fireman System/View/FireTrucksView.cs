using System;
using System.Windows.Forms;
using Fireman_Systemn.Controller;

namespace Fireman_Systemn.View
{
    public partial class FireTrucksView : Form
    {
        FireTrucksController fireTrucksController = new FireTrucksController();
        public FireTrucksView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }        

        private void FireTrucks_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
            Refresh_table();
        }

        private void Refresh_table()
        {
            dgvFireTrucks.DataSource = fireTrucksController.GetAll();
        }

        private void btn_delete_fire_truck_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgvFireTrucks.CurrentRow;
                int id = int.Parse(row.Cells["fire_truck_id"].Value.ToString());
                fireTrucksController.Delete(id);
                Refresh_table();
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Row Selected!", ex);
            }
        }

        private void btn_add_fire_truck_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new AddFireTruckView());
        }
    }
}
