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
        public RoomForm(string idRoom)
        {
            InitializeComponent();

            List<string> rooms = MainForm.MySelect("SELECT name, adress_pic, id_hotel FROM rooms WHERE id = " + idRoom);
            List<string> hotel = MainForm.MySelect("SELECT name FROM hotels WHERE id = " + rooms[2]);

            Text = hotel[0] + ": " + rooms[0];
            RoomLabel.Text = hotel[0] + ": " + rooms[0];

            RoomPictureBox.Load("../../Pictures/" + rooms[1]);

        }

    }
}
