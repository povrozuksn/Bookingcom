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
    public partial class RoomForm : Form
    {
        public RoomForm(string HotelName, string RoomName)
        {
            InitializeComponent();
            Text = "Гостиница " + HotelName + ": " + RoomName;
            RoomLabel.Text = "Гостиница " + HotelName + ": " + RoomName;

            RoomPictureBox.Load("../../Pictures/" + RoomName + ".jpg");

        }

    }
}
