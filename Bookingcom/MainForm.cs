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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height < 140)
            {
                FiltrPanel.Height = 140;
            }
            else
            {
                FiltrPanel.Height = FiltrButton.Size.Height;
            }
        }

        private void Hotel_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            HotelForm hotelForm = new HotelForm(pb.Tag.ToString(), 5);
            hotelForm.ShowDialog();
        }

        private void labelHotel_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            string[] text = lb.Text.Split(new char[] { '"' });
            HotelForm hotelForm = new HotelForm(text[1], 5);
            hotelForm.ShowDialog();
        }
    }
}
