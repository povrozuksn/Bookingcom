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
    public partial class HotelForm : Form
    {
        public HotelForm(string name)
        {
            InitializeComponent();

            Text = name;
            HotelLabel.Text = name;
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
