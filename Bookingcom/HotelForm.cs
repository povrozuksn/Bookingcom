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

            List<string> hotel = MainForm.MySelect("SELECT name, rating, adress_pic FROM hotels WHERE id = " + _idHotel);
            List<string> rooms = MainForm.MySelect("SELECT name FROM rooms WHERE id_hotel = " + _idHotel);

            Text = hotel[0];
            HotelLabel.Text = hotel[0];
            HotelPictureBox.Load("../../Pictures/" + hotel[2]);
            //HotelTextBox.Text = hotel[3];
            int ratingHotel = Convert.ToInt32(hotel[1]);

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
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void Room_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(_idHotel, pb.Tag.ToString());
            rf.ShowDialog();
        }
    }
}
