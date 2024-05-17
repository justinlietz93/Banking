using JKL.Banking.BL.Models;
using JKL.Utility.PL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JKL.Banking.BL
{
    public class DepositManager
    {
        public static List<Deposit> Populate(int customerId)
        {
            List<Deposit> list = new List<Deposit>();
            switch (customerId)
            {
                case 1:
                    list.Add(new Deposit { DepositId = 1, DepositAmount = 1234.50, DepositDate = new DateTime(2024, 1, 1) });
                    list.Add(new Deposit { DepositId = 2, DepositAmount = 1500.75, DepositDate = new DateTime(2023, 12, 15) });
                    list.Add(new Deposit { DepositId = 3, DepositAmount = 275.00, DepositDate = new DateTime(2023, 11, 30) });
                    break;
                case 2:
                    list.Add(new Deposit { DepositId = 4, DepositAmount = 100.60, DepositDate = new DateTime(2023, 11, 25) });
                    list.Add(new Deposit { DepositId = 5, DepositAmount = 50.25, DepositDate = new DateTime(2023, 10, 10) });
                    break;
                case 3:
                    list.Add(new Deposit { DepositId = 6, DepositAmount = 200.00, DepositDate = new DateTime(2023, 9, 5) });
                    list.Add(new Deposit { DepositId = 7, DepositAmount = 75.50, DepositDate = new DateTime(2023, 8, 20) });
                    break;
            }
            return list;
        }

        public static List<Deposit> Load()
        {
            try
            {
                List<Deposit> deposits = new List<Deposit>();
                Database db = new Database();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tblDeposits";
                SqlCommand sqlCommand = new SqlCommand(sql);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Deposit deposit = new Deposit();
                    deposit.DepositId = Convert.ToInt32(dr["ID"]);
                    deposit.DepositAmount = Convert.ToDouble(dr["Amount"]);
                    deposit.DepositDate = Convert.ToDateTime(dr["Date"]);

                    deposits.Add((deposit));
                }
                return deposits;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Deposit> Load(int custId)
        {
            try
            {
                List<Deposit> deposits = new List<Deposit>();
                Database db = new Database();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tblDeposits WHERE CustID = @CustId";
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.Parameters.AddWithValue("@CustId", custId);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Deposit deposit = new Deposit();
                    deposit.DepositId = Convert.ToInt32(dr["ID"]);

                    deposit.DepositAmount = Convert.ToDouble(dr["Amount"]);
                    deposit.DepositDate = Convert.ToDateTime(dr["Date"]);
                    deposit.CustID = Convert.ToInt32(dr["CustID"]);

                    deposits.Add((deposit));
                }
                return deposits;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Deposit> Load(short id)
        {
            try
            {
                List<Deposit> deposits = new List<Deposit>();
                Database db = new Database();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tblDeposits WHERE ID = @Id";
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.Parameters.AddWithValue("@Id", id);

                dt = db.Select(sqlCommand);

                Deposit deposit = new Deposit();

                foreach (DataRow dr in dt.Rows)
                {

                    deposit.DepositId = Convert.ToInt32(dr["ID"]);
                    deposit.DepositAmount = Convert.ToDouble(dr["Amount"]);
                    deposit.DepositDate = Convert.ToDateTime(dr["Date"]);
                    deposit.CustID = Convert.ToInt32(dr["CustID"]);

                    deposits.Add((deposit));
                }
                return deposits;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(Deposit deposit, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "INSERT INTO tblDeposits (ID, Amount, Date, CustID)"
                             + "VALUES (@Id, @Amount, @Date, @CustID)";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@Id", Database.GetNextDepositId());
                sqlCommand.Parameters.AddWithValue("@Amount", deposit.DepositAmount);
                sqlCommand.Parameters.AddWithValue("@Date", deposit.DepositDate);
                sqlCommand.Parameters.AddWithValue("@CustID", deposit.CustID);

                int results = db.Insert(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Update(Deposit deposit, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "UPDATE tblDeposits "
                           + "SET Amount = @Amount, "
                           + "Date = @Date, "
                           + "CustID = @CustID "
                           + "WHERE ID = @Id";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@Id", deposit.DepositId);
                sqlCommand.Parameters.AddWithValue("@Amount", deposit.DepositAmount);
                sqlCommand.Parameters.AddWithValue("@Date", deposit.DepositDate);
                sqlCommand.Parameters.AddWithValue("@CustID", deposit.CustID);

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

                string sql = "DELETE FROM tblDeposits WHERE ID = @Id";

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

        public static int DeleteByCustId(int custId, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "DELETE FROM tblDeposits WHERE CustID = @CustID";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@CustID", custId);

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
