using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entity;

namespace Kustia_Trading_Agency_Management
{
    public partial class Ship : Form
    {
        public Ship()
        {
            InitializeComponent();
            fill_combobox();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form hm = new Home_form();
            hm.Show();
            this.Hide();
        }

        void fill_combobox()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information2 = kta_bl.load_ship_in_combobox(information1);
                int len = information2.shipName.Length;
                for (int i = 0; i < len; i++)
                {
                    comboBox1.Items.Add(information2.shipName[i]);
                    comboBox2.Items.Add(information2.shipName[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.ship_name = textBox1.Text;
            information1.amount = textBox2.Text;

            if (kta_bl.addShip(information1))
            {
                textBox1.Text = "";
                textBox2.Text = "";

            }


            else
            {
                MessageBox.Show("not successful");
            }
        }

        void product2()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information1.ship_name = comboBox2.Text;
                information2 = kta_bl.product(information1);
                // amnt = float.Parse(n);
                // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                textBox5.Text = information2.amount;
                //textBox6.Text = information2.address;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        void product()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information1.ship_name = comboBox1.Text;
                information2 = kta_bl.product(information1);
                // amnt = float.Parse(n);
                // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                textBox3.Text = information2.amount;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            fill_combobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            product();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            product2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.ship_name = comboBox1.Text;
                information1.amount = textBox3.Text;
                kta_bl.update_ship(information1);
                comboBox1.Text = "";
                textBox3.Text = "";
               // textBox6.Text = "";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.ship_name = comboBox2.Text;
                kta_bl.delete_ship(information1);
                comboBox2.Text = "";
                textBox5.Text = "";
                //comboBox6.Text = "";
                // amnt = float.Parse(n);
                //label5.Text = "Available : "+amnt;
                // label5.Text = n;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
