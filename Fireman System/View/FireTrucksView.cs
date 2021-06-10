using System;
using System.Linq;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.EditViews;
using Fireman_Systemn.View.Pop_Ups;

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

            var row = dgvFireTrucks.CurrentRow;
            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
            }
            else
            {
                try
                {
                    int id = int.Parse(row.Cells["FireTruckID"].Value.ToString());
                    fireTrucksController.Delete(id);
                    Refresh_table();
                    DeleteRow deleteRow = new DeleteRow();
                    deleteRow.ShowDialog();
                }
                catch 
                {
                    InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                    invalidRowSelected.ShowDialog();
                }
            }

        }

        private void btn_add_fire_truck_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new AddFireTruckView());
        }

        private void btn_update_table_Click(object sender, EventArgs e)
        {
            var row = dgvFireTrucks.CurrentRow;
            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
            }
            else
            {
                int id = int.Parse(row.Cells["FireTruckID"].Value.ToString());
                using (FiremanSysEntities fse = new FiremanSysEntities())
                {
                    var fireTruck = fse.FireTrucks.Where(f => f.fire_truck_id == id).FirstOrDefault();
                    FormLayout.NavigateForms(this, new EditFireTruckView(fireTruck));
                }
            }
        }
    }
}
