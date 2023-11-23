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
        string id_room;
        public RoomForm(string idRoom)
        {
            InitializeComponent();

            id_room = idRoom;

            List<string> rooms = SQLClass.MySelect("SELECT name, adress_pic, specification, id_hotel, area FROM rooms WHERE id = " + idRoom);
            List<string> hotel = SQLClass.MySelect("SELECT name FROM hotels WHERE id = " + rooms[3]);

            Text = hotel[0] + ": " + rooms[0];
            RoomLabel.Text = hotel[0] + ": " + rooms[0];

            RoomPictureBox.Load("../../Pictures/" + rooms[1]);
            RoomTextBox.Text = rooms[2];
            SLabel.Text = rooms[4];

            if(MainForm.Login != "")
            {
                CommentPanel.Visible = true;
            }
            else
            {
                CommentPanel.Visible = false;
            }
        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("INSERT INTO ratingroom(comment, score, id_room, user) VALUES('" + CommentTextBox.Text + "', '" + CommentComboBox.Text + "', '" + id_room + "', '" + MainForm.Login + "')");
            MessageBox.Show("Спасибо");
            CommentPanel.Visible = false;
        }
    }
}
