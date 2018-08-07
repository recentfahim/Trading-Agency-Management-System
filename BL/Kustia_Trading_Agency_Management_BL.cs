using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BL
{
    public class Kustia_Trading_Agency_Management_BL
    {
        Kustia_Trading_Agency_Management_DAL kta_dal = new Kustia_Trading_Agency_Management_DAL();
        public bool setManagementData(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.set_management_data(information);

        }
        public void update_truck(Kustia_Trading_Agency_Management_Entity information)
        {
             kta_dal.update_truck(information);

        }
        public void update_driver(Kustia_Trading_Agency_Management_Entity information)
        {
             kta_dal.update_driver(information);

        }

        public void update_customer(Kustia_Trading_Agency_Management_Entity information)
        {
            kta_dal.update_customer(information);

        }

        public void update_ship(Kustia_Trading_Agency_Management_Entity information)
        {
            kta_dal.update_ship(information);

        }

        public void delete_driver(Kustia_Trading_Agency_Management_Entity information)
        {
            kta_dal.delete_driver(information);

        }

        public void delete_customer(Kustia_Trading_Agency_Management_Entity information)
        {
            kta_dal.delete_customer(information);

        }


        public void delete_ship(Kustia_Trading_Agency_Management_Entity information)
        {
            kta_dal.delete_ship(information);

        }

        public void delete_truck(Kustia_Trading_Agency_Management_Entity information)
        {
            kta_dal.delete_truck(information);

        }
        public Kustia_Trading_Agency_Management_Entity load_ship_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.load_ship_in_combobox(information);

        }
        public Kustia_Trading_Agency_Management_Entity customer_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.customer_in_combobox(information);

        }
        public Kustia_Trading_Agency_Management_Entity load_truck_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.load_truck_in_combobox(information);

        }
        public string amount(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.amount(information);

        }


        public Kustia_Trading_Agency_Management_Entity product(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.product(information);

        }
        
         public string truck_number(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.truck_number(information);

        }

        public string destination(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.destination(information);

        }
        public bool addShip(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.addShip(information);

        }
        public bool addCustomer(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.addCustomer(information);

        }
        public bool addTruck(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.addTruck(information);

        }
        public bool addDriver(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.addDriver(information);

        }
        public Kustia_Trading_Agency_Management_Entity load_profile_in_combobox(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.load_profile_in_combobox(information);

        }
        public Kustia_Trading_Agency_Management_Entity details(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.details(information);

        }

        public Kustia_Trading_Agency_Management_Entity cus_details(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.cus_details(information);

        }

         public DataSet available_truck (Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.available_truck(information);
        }

         public DataSet dailyReport(Kustia_Trading_Agency_Management_Entity information)
        {
            return kta_dal.dailyReport(information);
        }




    }
}
