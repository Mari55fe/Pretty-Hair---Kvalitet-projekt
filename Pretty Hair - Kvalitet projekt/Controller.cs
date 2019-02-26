using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretty_Hair___Kvalitet_projekt
{
    public class Controller
    {
        Database_Controller DBC = new Database_Controller();

        public void InsertCustomer()
        {
            Customer customer = new Customer { };
            DBC.InsertCustomer(customer);
        }
        public void ShowCustomer()
        {
            DBC.ShowCustomer();
        }
    }
}
