using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class AdminRoomsForm : Form
    {
        public AdminRoomsForm()
        {
            InitializeComponent();

        }

        private void AdminRoomsForm_Load(object sender, EventArgs e)
        {
            InfoRoomsPanel.Controls.Clear();
            InfoRoomsPanel.Controls.Add(label1);
            InfoRoomsPanel.Controls.Add(label2);

            List<string> hotels = SQLClass.MySelect("SELECT id, name FROM hotels");

            HotelsComboBox.Items.Clear();
            for (int i = 0; i < hotels.Count; i += 2)
            {
                HotelsComboBox.Items.Add(hotels[i] + ". " + hotels[i+1]);
            }

            List<string> rooms = SQLClass.MySelect("SELECT name, id_hotel FROM rooms");
            int y = 50;
            for (int i = 0; i < rooms.Count; i += 2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = rooms[i];
                InfoRoomsPanel.Controls.Add(lbl);

                List<string> hotel = new List<string>();
                hotel.Clear();
                hotel = SQLClass.MySelect("SELECT name FROM hotels WHERE id = " + rooms[i + 1]);

                Label lbl1 = new Label();
                lbl1.Location = new Point(475, y);
                lbl1.Size = new Size(250, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = hotel[0];
                InfoRoomsPanel.Controls.Add(lbl1);

                y += 35;
            }
        }

        string adress;
        private void RoomPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                RoomPictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            string id_hotel = "";
            string[] text = HotelsComboBox.Text.Split(new string[] {". "}, StringSplitOptions.None);
            id_hotel = text[0];

            if (NameRoomTextBox.Text != "" && HotelsComboBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO rooms (name, adress_pic, id_hotel) VALUES ('" + NameRoomTextBox.Text + "','" + adress + "', '" + id_hotel + "')");
                MessageBox.Show("Сохранено");
                AdminRoomsForm_Load(sender, e);
                NameRoomTextBox.Text = "";
                HotelsComboBox.Text = "";
                RoomPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }
        }
    }
}
