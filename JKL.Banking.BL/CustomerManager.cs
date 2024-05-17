using JKL.Banking.BL.Models;
using JKL.Utility.PL;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace JKL.Banking.BL
{
    public static class CustomerManager
    {
        public static List<Customer> Populate()
        {
            try
            {
                // Initialize customer list
                List<Customer> customers = new List<Customer>();

                // Initialize 3 fake customers
                Customer customer1 = new Customer();
                Customer customer2 = new Customer();
                Customer customer3 = new Customer();

                // Create data for customers
                customer1.ID = 1;
                customer1.FirstName = "John";
                customer1.LastName = "Cena";
                customer1.SSN = "123-456-7890";
                customer1.BirthDate = new DateTime(1985, 7, 10);

                customer2.ID = 2;
                customer2.FirstName = "Dan";
                customer2.LastName = "Tired";
                customer2.SSN = "111-111-1111";
                customer2.BirthDate = new DateTime(1990, 5, 15);

                customer3.ID = 3;
                customer3.FirstName = "Amanda";
                customer3.LastName = "Huggenkis";
                customer3.SSN = "123-555-9999";
                customer3.BirthDate = new DateTime(1988, 12, 20);

                // Populate deposit data for customers
                customer1.Deposits = DepositManager.Populate(customer1.ID);
                customer2.Deposits = DepositManager.Populate(customer2.ID);
                customer3.Deposits = DepositManager.Populate(customer3.ID);

                // Populate withdrawal data for customers
                customer1.Withdrawals = WithdrawalManager.Populate(customer1.ID);
                customer2.Withdrawals = WithdrawalManager.Populate(customer2.ID);
                customer3.Withdrawals = WithdrawalManager.Populate(customer3.ID);

                // Add customers to list
                customers.Add(customer1);
                customers.Add(customer2);
                customers.Add(customer3);

                return customers;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static bool WriteXML(List<Customer> customers, string filePath)
        {
            try
            {
                FileIO.Delete(filePath);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
                TextWriter writer = new StreamWriter(filePath);
                serializer.Serialize(writer, customers);
                writer.Close();
                writer = null;
                serializer = null;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Customer> ReadXML(string xmlfilePath)
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
                TextReader reader = new StreamReader(xmlfilePath);
                customers.AddRange((List<Customer>)serializer.Deserialize(reader));
                reader.Close();
                reader = null;
                serializer = null;
                return customers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Customer> Load()
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                Database db = new Database();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tblCustomers";
                SqlCommand sqlCommand = new SqlCommand(sql);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Customer customer = new Customer();
                    customer.ID = Convert.ToInt32(dr["ID"]);

                    customer.SSN = dr["SSN"].ToString();
                    customer.FirstName = dr["FirstName"].ToString();
                    customer.LastName = dr["LastName"].ToString();
                    customer.BirthDate = Convert.ToDateTime(dr["BirthDate"]);

                    customers.Add((customer));
                }
                return customers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(Customer customer, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "INSERT INTO tblCustomers (ID, SSN, FirstName, LastName, BirthDate)"
                             + "VALUES (@ID, @SSN, @FirstName, @LastName @BirthDate)";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@ID", customer.ID);
                sqlCommand.Parameters.AddWithValue("@SSN", customer.SSN);
                sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
                sqlCommand.Parameters.AddWithValue("@BirthDate", customer.BirthDate);

                int results = db.Insert(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Update(Customer customer, int maxId, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "UPDATE tblCustomers"
                           + "SET SSN = @SSN, "
                           + "FirstName = @FirstName, "
                           + "LastName = @CustID, "
                           + "WHERE ID = @Id";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@Id", customer.ID);
                sqlCommand.Parameters.AddWithValue("@SSN", customer.SSN);
                sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
                sqlCommand.Parameters.AddWithValue("@BirthDate", customer.BirthDate);

                int results = db.Insert(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Delete(int id, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "DELETE FROM tblCustomers WHERE ID = @Id";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@Id", id);

                int results = db.Delete(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }


}
