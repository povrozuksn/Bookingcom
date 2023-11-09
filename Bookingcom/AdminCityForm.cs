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
            if (CityTextBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO cityes (name) VALUES ('" + CityTextBox.Text + "')");
                MessageBox.Show("Сохранено");
                CityTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Вы забыли ввести название города");
            }
            AdminCityForm_Load(sender, e);
        }

        private void AdminCityForm_Load(object sender, EventArgs e)
        {
            InfoCityPanel.Controls.Clear();
            InfoCityPanel.Controls.Add(label1);
            List<string> cityes = SQLClass.MySelect("SELECT id, name FROM cityes ORDER BY name");
            int y = 50;
            for (int i=0; i<cityes.Count; i+=2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = cityes[i];
                lbl.Text = cityes[i+1];
                InfoCityPanel.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(280, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteCityClick);
                btn.Text = "Удалить";
                InfoCityPanel.Controls.Add(btn);

                y += 40;
            }            
        }

        private void DeleteCityClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach(Control control in InfoCityPanel.Controls)
            {
                if(control.Location == new Point(50, y))
                {
                    SQLClass.MyUpDate("DELETE FROM cityes WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                    AdminCityForm_Load(sender, e);
                }
            }
        }
    }
}
