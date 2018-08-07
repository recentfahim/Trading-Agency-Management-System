using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kustia_Trading_Agency_Management
{
    public partial class Home_form : Form
    {
        public Home_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Login_form l = new Login_form();
            l.Show();
            this.Hide();
        }

        private void Calculation_button_Click(object sender, EventArgs e)
        {
            Management s = new Management();
            s.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  AvailableTrack tr = new AvailableTrack();
            Truck tr = new Truck();
            tr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report rt = new Report();
            rt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ship sp = new Ship();
            sp.Show();
            this.Hide();
        }

        private void Management_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Customer c = new Customer();
            c.Show();
            this.Hide();
        }
    }
}
