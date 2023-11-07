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
    public partial class AdminCityForm : Form
    {
        public AdminCityForm()
        {
            InitializeComponent();            
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("INSERT INTO cityes (name) VALUES ('" + CityTextBox.Text + "')");
            MessageBox.Show("Сохранено");
            CityTextBox.Text = "";
            AdminCityForm_Load(sender, e);
        }

        private void AdminCityForm_Load(object sender, EventArgs e)
        {
            InfoCityPanel.Controls.Clear();
            InfoCityPanel.Controls.Add(label1);
            List<string> cityes = SQLClass.MySelect("SELECT DISTINCT name FROM cityes ORDER BY name");
            int y = 50;
            foreach (string city in cityes)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = city;
                InfoCityPanel.Controls.Add(lbl);

                y += 35;
            }
        }
    }
}
