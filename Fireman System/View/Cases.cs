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

namespace Fireman_Systemn.View
{
    public partial class Cases : Form
    {
        Thread thread;
        public Cases()
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

        private void Cases_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);            
        }
    }
}
