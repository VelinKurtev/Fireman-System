using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
        }
    }
}
