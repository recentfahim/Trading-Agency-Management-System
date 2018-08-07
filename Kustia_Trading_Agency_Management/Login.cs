using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kustia_Trading_Agency_Management
{
    public partial class Login_form : Form
    {
        
        public Login_form()
        {
            InitializeComponent();
        }


        private void Login_button_Click(object sender, EventArgs e)
        {
            if (User_name_textBox.Text == "kta" && Password_textBox.Text == "kta")
            {
                Home_form h = new Home_form();
                h.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Invalid Username or password!!");
            }
            
        }
    }
}
