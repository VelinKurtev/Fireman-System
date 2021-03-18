using System;
using System.Activities;
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
    public class FormLayout
    {
        public static int x;
        public static int y;

        public static void NavigateForms(Form currentForm, Form navForm) 
        {
            x = currentForm.Location.X;
            y = currentForm.Location.Y;
            currentForm.Close();
            var thread = new Thread(() => 
            {
                Application.Run(navForm); 
            });
            thread.Start();
        }

        public static void FormLoad(Form form)
        {
            form.Location = new Point(x, y);
        }
    }
}       
