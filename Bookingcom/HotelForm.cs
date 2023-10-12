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
        string _idHotel = "";

        public HotelForm(string idHotel)
        {
            _idHotel = idHotel;

            InitializeComponent();

            List<string> hotel = MainForm.MySelect("SELECT * FROM hotels WHERE id = " + _idHotel);
            List<string> rooms = MainForm.MySelect("SELECT id, name, adress_pic FROM rooms WHERE id_hotel = " + _idHotel);

            #region Выбранная гостиница на панеле HotelPanel 
            Text = hotel[1];
            HotelLabel.Text = hotel[1];
            HotelPictureBox.Load("../../Pictures/" + hotel[4]);
            HotelTextBox.Text = hotel[3];
            int ratingHotel = Convert.ToInt32(hotel[2]);
            int x = 415;
            for(int i=0; i< ratingHotel; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/Star.png");
                box.Location = new Point(x, 70);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                HotelPanel.Controls.Add(box);

                x += 55;
            }
            #endregion

            #region Номера выбранной гостиницы на панеле InfoPanel
            int x1 = 20;
            for (int i = 0; i < rooms.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x1, 30);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = rooms[i + 1];
                lbl.Tag = rooms[i];
                lbl.Click += new EventHandler(labelRoom_Click);
                InfoPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + rooms[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x1, 70);
                pb.Size = new Size(270, 184);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = rooms[i];
                pb.Click += new EventHandler(Room_Click);
                InfoPanel.Controls.Add(pb);

                x1 += 320;
            }
            #endregion

        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void Room_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(pb.Tag.ToString());
            rf.ShowDialog();
        }

        private void labelRoom_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            RoomForm rf = new RoomForm(lb.Tag.ToString());
            rf.ShowDialog();
        }
    }
}
