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

            List<string> hotels = MySelect("SELECT name FROM hotels");

            int x = 20;
            for(int i=0; i<hotels.Count; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 20);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = hotels[i];
                lbl.Click += new EventHandler(labelHotel_Click);
                InfoPanel.Controls.Add(lbl);

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
