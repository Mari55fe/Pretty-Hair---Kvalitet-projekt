﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretty_Hair___Kvalitet_projekt
{
    public class Controller
    {
        Database_Controller DBC = new Database_Controller();

        public void InsertCustomer(string name, string address, string zip, string town, string phoneNum)
        {
            Customer customer = new Customer { Name = name, Address = address, Zip = zip, Town = town, PhoneNum = phoneNum};
            DBC.InsertCustomer(customer);
        }
        public void ShowCustomer()
        {
            DBC.ShowCustomer();
        }
        public void InsertOrder(string ordreID, string navn, string bestillingsdato, string leveringsdato, object checkbox)
        {
            Order order = new Order { OrdreID = ordreID, Navn = navn, Bestillingsdato = bestillingsdato, Leveringsdato = leveringsdato, Checkbox = checkbox };
            DBC.InsertOrder(order);
        }
    }
}
