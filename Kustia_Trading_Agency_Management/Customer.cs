using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;

namespace Kustia_Trading_Agency_Management
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            fill_combobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.cus_name = textBox1.Text;
            information1.cus_mob_no = textBox2.Text;
            information1.cus_address = textBox3.Text;

            if (kta_bl.addCustomer(information1))
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }


            else
            {
                MessageBox.Show("not successful");
            }
        }
        void fill_combobox()
        {

            try
            {

                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information2 = kta_bl.customer_in_combobox(information1);
                int len = information2.customerName.Length;
                for (int i = 0; i < len; i++)
                {
                    comboBox1.Items.Add(information2.customerName[i]);
                    comboBox2.Items.Add(information2.customerName[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form hm = new Home_form();
            hm.Show();
            this.Hide();
        }

        void details()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information1.cus_name = comboBox2.Text;
                information2 = kta_bl.cus_details(information1);
                // amnt = float.Parse(n);
                // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                textBox4.Text = information2.cus_address;
                textBox5.Text = information2.cus_mob_no;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        void details2()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information1.cus_name = comboBox1.Text;
                information2 = kta_bl.cus_details(information1);
                // amnt = float.Parse(n);
                // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                textBox7.Text = information2.cus_address;
                textBox8.Text = information2.cus_mob_no;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            details();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            details2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.cus_name = comboBox2.Text;
                information1.cus_mob_no = textBox5.Text;
                information1.cus_address = textBox4.Text;
                kta_bl.update_customer(information1);
                //amnt = float.Parse(n);
                //label5.Text = "Available : "+amnt;
                //label5.Text = n;
                comboBox2.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";

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
                information1.cus_name = comboBox1.Text;
                kta_bl.delete_customer(information1);
                textBox7.Text = "";
                textBox8.Text = "";
                comboBox1.Text = "";
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
