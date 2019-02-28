using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pretty_Hair___Kvalitet_projekt
{
    public class Database_Controller
    {
        private static string connectionString =
       "Server = ealSQL1.eal.local; Database = A_DB27_2018; User Id = A_STUDENT27; Password = A_OPENDB27;";

        public void InsertCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand("InsertKundeInfo", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.Add(new SqlParameter("@Navn", customer.Name));
                    cmd1.Parameters.Add(new SqlParameter("@Adresse", customer.Address));
                    cmd1.Parameters.Add(new SqlParameter("@PostNr", customer.Zip));
                    cmd1.Parameters.Add(new SqlParameter("@Bydel", customer.Town));
                    cmd1.Parameters.Add(new SqlParameter("@Telefonnummer", customer.PhoneNum));

                    cmd1.ExecuteNonQuery();
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa: " + e.Message);
                }
            }
        }
        public void ShowCustomer()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("GetKundeInfo", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string KundeID = read["KundeID"].ToString();
                            string Navn = read["Navn"].ToString();
                            string Adresse = read["Adresse"].ToString();
                            string PostNr = read["PostNr"].ToString();
                            string Bydel = read["Bydel"].ToString();
                            string Telefonnummer = read["Telefonnummer"].ToString();
                            Console.WriteLine(KundeID + " " + Navn + " " + Adresse + " " + PostNr + " " + Bydel + " " + Telefonnummer);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa: " + e.Message);
                }
            }
        }
        //public void InsertOrder(Customer customer)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();

        //            SqlCommand cmd1 = new SqlCommand("InsertKundeInfo", conn);
        //            cmd1.CommandType = CommandType.StoredProcedure;

        //            cmd1.Parameters.Add(new SqlParameter("@Navn", customer.Name));
        //            cmd1.Parameters.Add(new SqlParameter("@Adresse", customer.Address));
        //            cmd1.Parameters.Add(new SqlParameter("@PostNr", customer.Zip));
        //            cmd1.Parameters.Add(new SqlParameter("@Bydel", customer.Town));
        //            cmd1.Parameters.Add(new SqlParameter("@Telefonnummer", customer.PhoneNum));

        //            cmd1.ExecuteNonQuery();
        //        }

        //        catch (SqlException e)
        //        {
        //            Console.WriteLine("Hovsa: " + e.Message);
        //        }
        //    }
        //}
    }
}
