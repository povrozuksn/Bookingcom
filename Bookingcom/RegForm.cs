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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PasTextBox.Text == ConfirmTextBox.Text)
            {
                SQLClass.MyUpDate("INSERT INTO users (login, pass, name, family, admin) VALUES ('" + LoginTextBox.Text + "', '" + PasTextBox.Text + "', '" + NameTextBox.Text + "', '" + FamilyTextBox.Text + "', 0)");
                MessageBox.Show("Регистрация прошла успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
