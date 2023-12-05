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

        private void AdminRoomsButton_Click(object sender, EventArgs e)
        {
            AdminRoomsForm arf = new AdminRoomsForm();
            arf.ShowDialog();
        }

        private void AdminUsersButton_Click(object sender, EventArgs e)
        {
            AdminUsersForm auf = new AdminUsersForm();
            auf.ShowDialog();
        }

        private void AdminBookingButton_Click(object sender, EventArgs e)
        {
            AdminBookingForm abf = new AdminBookingForm();
            abf.ShowDialog();
        }
    }
}
