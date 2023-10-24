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

            List<string> rooms = SQLClass.MySelect("SELECT name, adress_pic, specification, id_hotel, area FROM rooms WHERE id = " + idRoom);
            List<string> hotel = SQLClass.MySelect("SELECT name FROM hotels WHERE id = " + rooms[3]);

            Text = hotel[0] + ": " + rooms[0];
            RoomLabel.Text = hotel[0] + ": " + rooms[0];

            RoomPictureBox.Load("../../Pictures/" + rooms[1]);
            RoomTextBox.Text = rooms[2];
            SLabel.Text = rooms[4];
        }

    }
}
