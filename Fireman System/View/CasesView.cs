using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Fireman_Systemn.Controller;

namespace Fireman_Systemn.View
{
    public partial class CasesView : Form
    {
        AddCasesController addCasesController = new AddCasesController();
        
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
            dgvCases.DataSource = addCasesController.GetAll();
        }

        private void btn_delete_case_Click(object sender, EventArgs e)
        {
            var row = dgvCases.CurrentRow;
            int id = int.Parse(row.Cells["Case_id"].Value.ToString());
            addCasesController.Delete(id);
            Refresh_table();
        }
    }
}
