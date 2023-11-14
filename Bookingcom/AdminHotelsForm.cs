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
    public partial class AdminHotelsForm : Form
    {
        public AdminHotelsForm()
        {
            InitializeComponent();
        }

        string adress;
        private void HotelPictureBox_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                HotelPictureBox.Load(adress);
            }
        }

        private void AddHotelButton_Click(object sender, EventArgs e)
        {
            if(NameHotelTextBox.Text != "" && CityComboBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO hotels (name, rating, adress_pic, name_city) VALUES ('" + NameHotelTextBox.Text + "','" + RatingComboBox.Text + "', '" + adress + "', '" + CityComboBox.Text + "')");
                MessageBox.Show("Сохранено");
                AdminHotelsForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            
        }

        private void AdminHotelsForm_Load(object sender, EventArgs e)
        {
            InfoHotelsPanel.Controls.Clear();
            InfoHotelsPanel.Controls.Add(label1);
            InfoHotelsPanel.Controls.Add(label2);
            InfoHotelsPanel.Controls.Add(label3);

            List<string> cityes = SQLClass.MySelect("SELECT DISTINCT name FROM cityes ORDER BY name");

            CityComboBox.Items.Clear();
            foreach (string city in cityes)
            {
                CityComboBox.Items.Add(city);
            }

            List<string> hotels = SQLClass.MySelect("SELECT id, name, name_city, rating FROM hotels");
            int y = 50;
            for (int i = 0; i < hotels.Count; i += 4)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = hotels[i];
                lbl.Text = hotels[i+1];
                InfoHotelsPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(250, y);
                lbl1.Size = new Size(120, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = hotels[i + 2];
                InfoHotelsPanel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(450, y);
                lbl2.Size = new Size(220, 30);
                lbl2.Font = new Font("Arial Narrow", 13);
                lbl2.Text = hotels[i + 3];
                InfoHotelsPanel.Controls.Add(lbl2);

                Button btn = new Button();
                btn.Location = new Point(800, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Text = "Удалить";
                InfoHotelsPanel.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoHotelsPanel.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM hotels WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                    AdminHotelsForm_Load(sender, e);
                }
            }
        }

    }

}
