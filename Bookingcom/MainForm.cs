using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bookingcom
{
    public partial class MainForm : Form
    {
        const string CONNECTION_STRING =
       "SslMode=none;Server=localhost;Database=bookingcom;port=3306;Uid=root;charset=utf8";

        public MainForm()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id, name FROM cityes", conn);

            DbDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                string id = reader.GetValue(0).ToString();
                string name = reader.GetValue(1).ToString();
            }
            reader.Close();

            conn.Close();


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
