using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BL;
using Entity;

namespace Kustia_Trading_Agency_Management
{
    public partial class Truck : Form
    {
        public Truck()
        {
            InitializeComponent();
            fill_grid_view();
            fill_combobox1();
            load_truck_combobox();
        }


        private void fill_grid_view()
        {
             Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
             Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
             DataSet n = kta_bl.available_truck(information1);
             truck_dataGridView.DataSource = n;
             truck_dataGridView.DataMember = "truck_number";
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form hm = new Home_form();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.truck_number = textBox1.Text;
            information1.driver_name = comboBox1.Text;

            if (kta_bl.addTruck(information1))
            {
                comboBox1.Text = "";
                textBox1.Text = "";

            }


            else
            {
                MessageBox.Show("not successful");
            }


        }
        void truck_number()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.driver_name = comboBox2.Text;
                string n = kta_bl.truck_number(information1);
               // amnt = float.Parse(n);
               // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                comboBox3.Text = n;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        void details()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                Kustia_Trading_Agency_Management_Entity information2 = new Kustia_Trading_Agency_Management_Entity();
                information1.driver_name = comboBox4.Text;
                information2 = kta_bl.details(information1);
                // amnt = float.Parse(n);
                // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                textBox7.Text = information2.mobile_number;
                textBox6.Text = information2.address;

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
                information1.driver_name = comboBox6.Text;
                information2 = kta_bl.details(information1);
                // amnt = float.Parse(n);
                // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                textBox9.Text = information2.mobile_number;
                textBox8.Text = information2.address;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        void truck_number2()
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.driver_name = comboBox5.Text;
                string n = kta_bl.truck_number(information1);
                // amnt = float.Parse(n);
                // label5.Text = "Available : " + amnt;
                // label5.Text = n;
                textBox2.Text = n;

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
                information2 = kta_bl.load_profile_in_combobox(information1);
                int len = information2.profile.Length;
                for (int i = 0; i < len; i++)
                {
                    comboBox1.Items.Add(information2.profile[i]);
                    comboBox2.Items.Add(information2.profile[i]);
                    comboBox5.Items.Add(information2.profile[i]);
                    comboBox4.Items.Add(information2.profile[i]);
                    comboBox6.Items.Add(information2.profile[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void load_truck_combobox()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fill_grid_view();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            fill_combobox1();
            load_truck_combobox();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            truck_number();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            truck_number2();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.truck_number = comboBox3.Text;
                information1.driver_name = comboBox2.Text;
                kta_bl.update_truck(information1);
               // amnt = float.Parse(n);
                //label5.Text = "Available : "+amnt;
               // label5.Text = n;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.truck_number = textBox2.Text;
                information1.driver_name = comboBox5.Text;
                kta_bl.delete_truck(information1);
                textBox2.Text = "";
                comboBox5.Text = "";
                // amnt = float.Parse(n);
                //label5.Text = "Available : "+amnt;
                // label5.Text = n;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.driver_name = textBox3.Text;
            information1.mobile_number = textBox4.Text;
            information1.address = textBox5.Text;

            if (kta_bl.addDriver(information1))
            {
                textBox4.Text = "";
                textBox5.Text = "";
                textBox3.Text = "";
            }


            else
            {
                MessageBox.Show("not successful");
            }


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            details();

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            details2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.driver_name = comboBox4.Text;
                information1.mobile_number = textBox7.Text;
                information1.address = textBox6.Text;
                kta_bl.update_driver(information1);
                //amnt = float.Parse(n);
                //label5.Text = "Available : "+amnt;
                //label5.Text = n;
                comboBox4.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
                Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
                information1.driver_name = comboBox6.Text;
                kta_bl.delete_driver(information1);
                textBox9.Text = "";
                textBox8.Text = "";
                comboBox6.Text = "";
                // amnt = float.Parse(n);
                //label5.Text = "Available : "+amnt;
                // label5.Text = n;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Driver_tab_Click(object sender, EventArgs e)
        {

        }
        
    }
}
