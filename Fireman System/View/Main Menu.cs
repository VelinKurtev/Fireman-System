﻿using System;
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
    public partial class MainMenu : Form
    {
        Thread thread;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_view_database_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenTeamsAndEmployees);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenTeamsAndEmployees(object obj)
        {
            Application.Run(new Teams_and_Employees());
        }

        private void btn_view_cases_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenCases);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenCases(object obj)
        {
            
        }
    }
}
