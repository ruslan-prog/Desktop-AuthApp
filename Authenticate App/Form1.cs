using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authenticate_App
{
    public partial class AutApp : Form
    {
        public AutApp()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "user1" && textBox2.Text == "12345") {
                Form2 s = new Form2();
                s.Show();
            } else if(textBox1.Text == "" && textBox2.Text == "") {
                MessageBox.Show("Пожалуйста,введите логин и пароль");
            }
        }
    }
}
