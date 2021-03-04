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

namespace Fireman_Systemn
{
    public partial class Teams_and_Employees : Form
    {
        Thread thread;
        public Teams_and_Employees()
        {
            InitializeComponent();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(GoBack);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void GoBack()
        {
            Application.Run(new MainMenu());
        }
    }
}
