using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using BL;
using Entity;
//*
using System.Threading.Tasks;
using System.Data.SqlClient;
//**

namespace Kustia_Trading_Agency_Management
{
    public partial class Management : Form
    {
        float amnt;
       
        public Management()
        {
            InitializeComponent();
            fill_combobox1();
            fill_combobox2();
            fill_combobox4();

            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        void amount()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.ship_name = comboBox1.Text;
                string n = kta_bl.amount(information1);
                amnt = float.Parse(n);
                label5.Text = "Available : "+amnt;
               // label5.Text = n;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        void destination()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.cus_name = comboBox4.Text;
                string n = kta_bl.destination(information1);
                textBox5.Text = n;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
      
        void fill_combobox2()
        {

            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information2 = kta_bl.load_truck_in_combobox(information1);
                int len = information2.truckNumber.Length;
                for (int i = 0; i < len; i++)
                {
                    comboBox3.Items.Add(information2.truckNumber[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
    
        }
        void fill_combobox4()
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
                    comboBox4.Items.Add(information2.customerName[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        void fill_combobox1()
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kustia_Trading_Agency_Management_Entity information = new Kustia_Trading_Agency_Management_Entity();
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            information.amt = float.Parse(textBox2.Text);
            if (information.amt < amnt)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || textBox2.Text == "")
                {

                    MessageBox.Show("All text Box have to be filled!!!");
                }

                else
                {
                    //float txbamt = float.Parse(textBox2.Text);

                    information.truck_number = comboBox3.Text;
                    information.ship_name = comboBox1.Text;
                    information.loading_point = comboBox2.Text;
                    information.customer = comboBox4.Text;
                    information.destination = textBox5.Text;
                    string price = textBox3.Text;
                    information.price = float.Parse(price);
                    information.sacks = int.Parse(textBox1.Text);
                    information.m_ton = float.Parse(textBox2.Text);
                    float n =(amnt - information.amt);
                    information.avamt = n.ToString();
                    //Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                    if (kta_bl.setManagementData(information))
                    {

                        MessageBox.Show("Data Saved Successfully!!");
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        comboBox3.Text = "";
                        comboBox4.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        label12.Text = "";
                        label13.Text = "";
                        label5.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Entry!!");
                    }
                    // MessageBox.Show("Your Carring amount is greater than available amount!!");

                }
            }
            else
            {

                MessageBox.Show("Your entered amount is larger than available product!!");
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            amount();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_form hm = new Home_form();
            hm.Show();
            this.Hide();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            destination();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form hm = new Home_form();
            hm.Show();
            this.Hide();
        }
    }
}
