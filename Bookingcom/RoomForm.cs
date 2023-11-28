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

            RoomTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            RoomTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            PriceTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            PriceTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            QuantityTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            QuantityTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            SaveRoomButton.Visible = Convert.ToBoolean(MainForm.isAdmin);
            SaveParamButton.Visible = Convert.ToBoolean(MainForm.isAdmin);

            STextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            STextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            id_room = idRoom;

            List<string> rooms = SQLClass.MySelect("SELECT name, adress_pic, specification, id_hotel, area, price, kol FROM rooms WHERE id = " + idRoom);
            List<string> hotel = SQLClass.MySelect("SELECT name FROM hotels WHERE id = " + rooms[3]);

            Text = hotel[0] + ": " + rooms[0];
            RoomLabel.Text = hotel[0] + ": " + rooms[0];

            RoomPictureBox.Load("../../Pictures/" + rooms[1]);
            RoomTextBox.Text = rooms[2];
            PriceTextBox.Text = rooms[5];
            QuantityTextBox.Text = rooms[6];
            STextBox.Text = rooms[4];

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

        private void SaveRoomButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE rooms SET specification = '" + RoomTextBox.Text + "' WHERE id = '" + id_room + "'");
            MessageBox.Show("Сохранено");
        }

        private void SaveParamButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE rooms SET price = '" + PriceTextBox.Text + "', kol = '" + QuantityTextBox.Text + "', area = '" + STextBox.Text + "' WHERE id = '" + id_room + "'");
            MessageBox.Show("Сохранено");
        }

        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(e.KeyCode == Keys.Enter)
            {
                SQLClass.MyUpDate("UPDATE rooms SET price = '" + PriceTextBox.Text + "' WHERE id = '" + id_room + "'");
                MessageBox.Show("Сохранено");
            }

        }
    }
}
