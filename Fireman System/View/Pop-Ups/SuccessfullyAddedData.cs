using System;
using System.Windows.Forms;

namespace Fireman_Systemn.View.Pop_Ups
{
    public partial class SuccessfullyAddedData : Form
    {
        public SuccessfullyAddedData()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
