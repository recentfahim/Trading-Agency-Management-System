using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Kustia_Trading_Agency_Management_Entity
    {
        public string truck_number , ship_name , loading_point,cus_name ,destination, driver_name , mobile_number, cus_mob_no, cus_address, address;
        public float price, m_ton;
        public int sacks, n=100;
        public string customer;
        public DateTime date;
        public string accdate;
        public string[] shipName = new string[100];
        public string[] customerName = new string[100];
        public string[] truckNumber = new string[100];
        public string[] profile = new string[100];
        public string avamt;
        public string amount;
        public float amt;
    }
}
