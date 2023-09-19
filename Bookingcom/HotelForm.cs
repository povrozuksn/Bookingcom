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
        public HotelForm(string hotelName, int ratingHotel)
        {
            InitializeComponent();

            Text = "Гостиница \"" + hotelName + "\"";
            HotelLabel.Text = "Гостиница \"" + hotelName + "\"";
            HotelPictureBox.Load("../../Pictures/" + hotelName + ".jpg");

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
    }
}
