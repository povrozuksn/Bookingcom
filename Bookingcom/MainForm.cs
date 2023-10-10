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
        //Функция SELECT-запроса
        public static List<string> MySelect (string cmdText)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for(int i=0; i<reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();
            conn.Close();
            return list;
        }

        const string CONNECTION_STRING =
       "SslMode=none;Server=localhost;Database=bookingcom;port=3306;Uid=root;charset=utf8";

         

        public MainForm()
        {
            InitializeComponent();

            List<string> cityes = MySelect("SELECT DISTINCT name FROM cityes ORDER BY name");

            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cityes)
                CityComboBox.Items.Add(city);

            List<string> hotels = MySelect("SELECT id, name, adress_pic FROM hotels");

            int x = 20;
            for(int i=0; i<hotels.Count; i+=3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 20);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = hotels[i+1];
                lbl.Tag = hotels[i];
                lbl.Click += new EventHandler(labelHotel_Click);
                InfoPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + hotels[i+2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 60);
                pb.Size = new Size(270, 184);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = hotels[i];
                pb.Click += new EventHandler(Hotel_Click);
                InfoPanel.Controls.Add(pb);

                x += 320;
            }

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
            HotelForm hotelForm = new HotelForm(pb.Tag.ToString());
            hotelForm.ShowDialog();
        }

        private void labelHotel_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            HotelForm hotelForm = new HotelForm(lb.Tag.ToString());
            hotelForm.ShowDialog();
        }
    }
}
