using System;
using System.Windows.Forms;
using Fireman_Systemn.Controller;

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
            //DataGridView Default Error Dialog opens up 
            dgvCases.DataSource = CasesController.GetAll();
        }

        private void btn_delete_case_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgvCases.CurrentRow;
                int id = int.Parse(row.Cells["Case_id"].Value.ToString());
                CasesController.Delete(id);
                Refresh_table();
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Row Selected!", ex);
            }
        }

        
        
    }
}
