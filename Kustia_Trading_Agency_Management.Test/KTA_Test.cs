using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using BL;
using Kustia_Trading_Agency_Management;

namespace Kustia_Trading_Agency_Management.Test
{
    [TestClass]
    public class KTA_Test
    {
        [TestMethod]
        public void Check_Management_save()
        {
            //arrange
            Kustia_Trading_Agency_Management_Entity information = new Kustia_Trading_Agency_Management_Entity();
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();

            //act
            information.truck_number = "KST-11-1392";
            information.ship_name = "Pirireis";
            information.loading_point = "RVJ";
            information.customer = "Arpon";
            information.destination = "Nilphamari";
            string price = "21.5";
            information.price = float.Parse(price);
            information.sacks = 50;
            string mton = "5.0";
            information.m_ton = float.Parse(mton);
            float amnt=800;
            float n =(amnt - information.amt);
            information.avamt = n.ToString();

            Boolean t = kta_bl.setManagementData(information); 
            //assert
            Assert.AreEqual(true, t);

        }

        [TestMethod]
        public void Check_Add_Ship()
        {
            //arrange
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();

            //act
            information1.ship_name = "Sundorbon";
            information1.amount = "500";

            bool t = kta_bl.addShip(information1);
                
            //assert
            Assert.AreEqual(true, t);
        }

        [TestMethod]
        public void Check_Add_Truck()
        {
            //arrange
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.truck_number = "KST-11-1392";
            information1.driver_name = "Mr. x";
            //act
            bool t = kta_bl.addTruck(information1);
            //assert
            Assert.AreEqual(true, t);
        }

        [TestMethod]
        public void Check_Add_Driver()
        {
            //arrange
             Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.driver_name = "Mr. x";
            information1.mobile_number = "12345678912";
            information1.address = "Dhaka";
            //act
            bool t = kta_bl.addDriver(information1);
            //assert
            Assert.AreEqual(true, t);

        }

        [TestMethod]
        public void Check_Customer_Place()
        {
            //arrange
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.cus_name = "Arpon";

            //act
            string n = kta_bl.destination(information1);
            //assertS
            Assert.AreEqual("Khulna", n);

        }

        [TestMethod]
         public void  Check_Add_Customer()
        {
            Kustia_Trading_Agency_Management_BL kta_bl = new Kustia_Trading_Agency_Management_BL();
            Kustia_Trading_Agency_Management_Entity information1 = new Kustia_Trading_Agency_Management_Entity();
            information1.cus_name = "aaa";
            information1.cus_mob_no = "xxx";
            information1.cus_address = "zzz";

            //act
            bool t = (kta_bl.addCustomer(information1));
            

            //assert
            Assert.AreEqual(true, t);
        }



       
    }
}
