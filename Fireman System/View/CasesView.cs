using System;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.Pop_Ups;

namespace Fireman_Systemn.View
{
    public partial class CasesView : Form
    {
        CasesController CasesController = new CasesController();
        public CasesView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }

        private void Cases_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
            Refresh_table();
        }

        private void btn_add_case_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new Add_Case_View());
        }

        private void Refresh_table()
        {
            dgvCases.DataSource = CasesController.GetAll();
        }

        private void btn_delete_case_Click(object sender, EventArgs e)
        {

            var row = dgvCases.CurrentRow;
            try
            {
                int id = int.Parse(row.Cells["CaseID"].Value.ToString());
                CasesController.Delete(id);
                Refresh_table();
            }
            catch 
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
            }
        }

        private void btn_update_table_Click(object sender, EventArgs e)
        {

        }
    }
}
