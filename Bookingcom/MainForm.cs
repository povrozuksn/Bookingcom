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
        public static string Login = "";
        public static string NameFamily = "";

        public MainForm()
        {
            InitializeComponent();

            FindButton_Click(null,null);
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

        private void FindButton_Click(object sender, EventArgs e)
        {
            List<string> cityes = SQLClass.MySelect("SELECT DISTINCT name FROM cityes ORDER BY name");

            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach(string city in cityes)
            {
                CityComboBox.Items.Add(city);
            }

            string command = "SELECT id, name, adress_pic FROM hotels WHERE 1";

            if (CityComboBox.Text != "")
            {
                command += " AND name_city = '" + CityComboBox.Text + "'";
            }

            if (RatingComboBox.Text != "")
            {
                command += " AND rating = '" + RatingComboBox.Text + "'";
            }

            List<string> hotels = SQLClass.MySelect(command);
            
            InfoPanel.Controls.Clear();
            int x = 20;
            for (int i = 0; i < hotels.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 20);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = hotels[i + 1];
                lbl.Tag = hotels[i];
                lbl.Click += new EventHandler(labelHotel_Click);
                InfoPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + hotels[i + 2]);
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

        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> user_date = SQLClass.MySelect("SELECT login, name, family FROM users WHERE login = '" + LoginTextBox.Text + "' AND pass = '" + PassTextBox.Text + "'");

            if(AuthButton.Text == "Выйти")
            {
                Login = "";
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(label1);
                LoginTextBox.Text = "";
                AuthPanel.Controls.Add(LoginTextBox);
                AuthPanel.Controls.Add(label2);
                PassTextBox.Text = "";
                AuthPanel.Controls.Add(PassTextBox);
                AuthButton.Text = "Войти";
                AuthPanel.Controls.Add(AuthButton);
                HelloLabel.Visible = false;
                HelloLabel.Text = "";

            }
            else
            {
                if(user_date.Count>0)
                {
                    Login = user_date[0];
                    NameFamily = user_date[1] + " " + user_date[2];
                    AuthPanel.Controls.Clear();
                    AuthButton.Text = "Выйти";
                    AuthPanel.Controls.Add(AuthButton);
                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Visible = true;
                    HelloLabel.Text = "Приветствуем Вас, " + NameFamily;
                }
                else
                {
                    MessageBox.Show("Вы указали неверный логин/пароль");
                    LoginTextBox.Text = "";
                    PassTextBox.Text = "";
                }
                
            }
        }
    }
}
