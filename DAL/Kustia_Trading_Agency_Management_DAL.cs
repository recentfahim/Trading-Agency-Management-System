using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data; 
using Entity;

namespace DAL
{
    public class Kustia_Trading_Agency_Management_DAL
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\3rd Year 2nd Term\SE LAB\Final\Kustia_Trading_Agency_Management\Kustia_Trading_Agency_Management\KTA.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataReader sdr;
        float amnt;
        string n;

        public bool set_management_data(Kustia_Trading_Agency_Management_Entity information)
        {

            try
            {
                cmd2.Connection = cn;
                cn.Open();
                cmd2.CommandText = "SELECT id FROM tbl_customer WHERE name = '" + information.customer + "'";
                sdr = cmd2.ExecuteReader();
                sdr.Read();
                string id = sdr["id"].ToString();

                cn.Close();
                amt_update_ship(information);
                //MessageBox.Show(id);

                int customer_id = int.Parse(id);


                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_shifting(truck_number , ship_name,date , loading_point ,destination , price ,sacks , m_ton ,customerId  ) VALUES('" + information.truck_number + "','" + information.ship_name + "','" + DateTime.Now.ToString("dd-MM-yyyy") + "','" + information.loading_point + "' , '" + information.destination + "' , '" + information.price + "', '" + information.sacks + "' , '" + information.m_ton + "', '" + customer_id + "')", cn);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Kustia_Trading_Agency_Management_Entity load_ship_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT name FROM tbl_ship";
                sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    information.shipName[i] = sdr["name"].ToString();
                    i++;
                }
                cn.Close();
                return information;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return information;
            }
        }
        public Kustia_Trading_Agency_Management_Entity customer_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT name FROM tbl_customer";
                sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    information.customerName[i] = sdr["name"].ToString();
                    i++;
                }
                cn.Close();
                return information;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return information;
            }
        }
        public Kustia_Trading_Agency_Management_Entity load_profile_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT name FROM tbl_profile";
                sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    //string name = sdr["name"].ToString();
                    information.profile[i] = sdr["name"].ToString();
                    i++;
                }
                cn.Close();
                return information;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return information;
            }
        }
        public void amt_update_ship(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "UPDATE tbl_ship SET amount ='" + information.avamt + "' WHERE name = '" + information.ship_name + "'";
                SqlDataReader rd = cmd.ExecuteReader();
                //MessageBox.Show("Update Successfull !!");
                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Unsucessfull");
                // return information;
            }

        }

        public void delete_truck(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "DELETE FROM tbl_truck WHERE  truck_number ='" + information.truck_number + "' ";
                SqlDataReader rd = cmd.ExecuteReader();

                MessageBox.Show("Delete Successfull !!");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Unsucessfull");
                // return information;
            }

        }

        public void update_truck(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "UPDATE tbl_truck SET truck_number ='" + information.truck_number + "' WHERE driver_name = '" + information.driver_name + "'";
                SqlDataReader rd = cmd.ExecuteReader();
                MessageBox.Show("Update Successfull !!");
                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Unsucessfull");
                // return information;
            }

        }



        public Kustia_Trading_Agency_Management_Entity load_truck_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT * FROM tbl_truck WHERE  truck_number not in (SELECT truck_number  FROM tbl_shifting WHERE date = '" + DateTime.Now.ToString("dd-MM-yyyy") + "')";
                sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    information.truckNumber[i] = sdr["truck_number"].ToString();
                    i++;
                }
                cn.Close();
                return information;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex);
                return information;
            }
        }

        public string amount(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT amount FROM tbl_ship WHERE name = '" + information.ship_name + "'";
                sdr = cmd.ExecuteReader();
                sdr.Read();
                string n = sdr["amount"].ToString();
                cn.Close();
                return n;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return n;
            }

        }

        public string truck_number(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT truck_number FROM tbl_truck WHERE  driver_name = '" + information.driver_name + "'";
                sdr = cmd.ExecuteReader();
                sdr.Read();
                string n = sdr["truck_number"].ToString();
                cn.Close();
                return n;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return n;
            }

        }

        public string destination(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT address FROM tbl_customer WHERE name = '" + information.cus_name + "'";
                sdr = cmd.ExecuteReader();
                sdr.Read();
                string des = sdr["address"].ToString();
                cn.Close();
                return des;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return n;
            }

        }
        public bool addShip(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "INSERT INTO tbl_ship(name, amount) VALUES('" + information.ship_name + "','" + information.amount + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Data Saved Successfully!!");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        public bool addTruck(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "INSERT INTO tbl_truck(truck_number, driver_name) VALUES('" + information.truck_number + "','" + information.driver_name + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Data Saved Successfully!!");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }
        public DataSet available_truck(Kustia_Trading_Agency_Management_Entity information)
        {
            cmd.Connection = cn;
            cn.Open();
            string sql = "SELECT truck_number,driver_name FROM tbl_truck WHERE  truck_number not in (SELECT truck_number  FROM tbl_shifting WHERE date = '" + DateTime.Now.ToString("dd-MM-yyyy") + "')";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "truck_number");
            cn.Close();
            return ds;
        }





        public bool addDriver(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "INSERT INTO tbl_profile(name, mobile_number,address) VALUES('" + information.driver_name + "','" + information.mobile_number + "','" + information.address + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Data Saved Successfully!!");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            };
        }

        public Kustia_Trading_Agency_Management_Entity details(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT mobile_number, address FROM tbl_profile WHERE  name = '" + information.driver_name + "'";
                sdr = cmd.ExecuteReader();
                sdr.Read();
                information.mobile_number = sdr["mobile_number"].ToString();
                information.address = sdr["address"].ToString();
                cn.Close();
                return information;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return information;
            }
        }

        public void update_driver(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "UPDATE tbl_profile SET mobile_number ='" + information.mobile_number + "', address ='" + information.address + "' WHERE name = '" + information.driver_name + "'";
                SqlDataReader rd = cmd.ExecuteReader();
                MessageBox.Show("Update Successfull !!");
                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("bal");
                // return information;
            }
        }

        public void delete_driver(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "DELETE FROM tbl_profile WHERE  name ='" + information.driver_name + "' ";
                SqlDataReader rd = cmd.ExecuteReader();

                MessageBox.Show("Delete Successfull !!");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("bal");
                // return information;
            }
        }

        public Kustia_Trading_Agency_Management_Entity product(Kustia_Trading_Agency_Management_Entity information)
        {

            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT amount FROM tbl_ship WHERE  name = '" + information.ship_name + "'";
                sdr = cmd.ExecuteReader();
                sdr.Read();
                information.amount = sdr["amount"].ToString();
                cn.Close();
                return information;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return information;
            }
        }

        public void update_ship(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "UPDATE tbl_ship SET amount ='" + information.amount + "' WHERE name = '" + information.ship_name + "'";
                SqlDataReader rd = cmd.ExecuteReader();
                MessageBox.Show("Update Successfull !!");
                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("bal");
                // return information;
            }
        }

        public void delete_ship(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "DELETE FROM tbl_ship WHERE  name ='" + information.ship_name + "' ";
                SqlDataReader rd = cmd.ExecuteReader();

                MessageBox.Show("Delete Successfull !!");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("bal");
                // return information;
            }
        }

        public DataSet dailyReport(Kustia_Trading_Agency_Management_Entity information)
        {
            cmd.Connection = cn;
            cn.Open();
            string sql = "SELECT ship_name,truck_number,loading_point,destination,price,sacks,m_ton,date FROM tbl_shifting WHERE  date  = '" + DateTime.Now.ToString("dd-MM-yyyy") + "'";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "ship_name");
            cn.Close();
            return ds;
        }
        public DataSet accodingDate(Kustia_Trading_Agency_Management_Entity information)
        {
            cmd.Connection = cn;
            cn.Open();
            string sql = "SELECT * FROM tbl_shifting WHERE  date  = '" + DateTime.Now.ToString("dd-MM-yyyy") + "'";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "ship_name");
            cn.Close();
            return ds;
        }

        public bool addCustomer(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "INSERT INTO tbl_customer(name,mobile,address) VALUES('" + information.cus_name + "','" + information.cus_mob_no + "','" + information.cus_address + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Data Saved Successfully!!");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        public Kustia_Trading_Agency_Management_Entity cus_details(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "SELECT mobile, address FROM [tbl_customer] WHERE  name = '" + information.cus_name + "'";
                sdr = cmd.ExecuteReader();
                sdr.Read();
                information.cus_mob_no = sdr["mobile"].ToString();
                information.cus_address = sdr["address"].ToString();
                cn.Close();
                return information;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return information;
            }
        }

        public void update_customer(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "UPDATE tbl_customer SET mobile ='" + information.cus_mob_no + "', address ='" + information.cus_address + "' WHERE name = '" + information.cus_name + "'";
                SqlDataReader rd = cmd.ExecuteReader();
                MessageBox.Show("Update Successfull !!");
                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("bal");
            }
        }

        public void delete_customer(Kustia_Trading_Agency_Management_Entity information)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "DELETE FROM tbl_customer WHERE  name ='" + information.cus_name + "' ";
                SqlDataReader rd = cmd.ExecuteReader();

                MessageBox.Show("Delete Successfull !!");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("bal");
                // return information;
            }
        }
    }

}