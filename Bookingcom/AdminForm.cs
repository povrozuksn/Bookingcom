using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminCityButton_Click(object sender, EventArgs e)
        {
            AdminCityForm acf = new AdminCityForm();
            acf.ShowDialog();
        }

        private void AdminHotelsButton_Click(object sender, EventArgs e)
        {
            AdminHotelsForm ahf = new AdminHotelsForm();
            ahf.ShowDialog();
        }
    }
}
