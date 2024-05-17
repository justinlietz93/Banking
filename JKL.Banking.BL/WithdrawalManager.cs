using JKL.Banking.BL.Models;
using JKL.Utility.PL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL
{
    public class WithdrawalManager
    {
        public static List<Withdrawal> Populate(int customerId)
        {
            List<Withdrawal> list = new List<Withdrawal>();

            switch (customerId)
            {
                case 1:
                    list.Add(new Withdrawal { WithdrawalId = 1, WithdrawalAmount = 500.25, WithdrawalDate = new DateTime(2024, 1, 5) });
                    list.Add(new Withdrawal { WithdrawalId = 2, WithdrawalAmount = 200.00, WithdrawalDate = new DateTime(2023, 12, 20) });
                    list.Add(new Withdrawal { WithdrawalId = 3, WithdrawalAmount = 1000.00, WithdrawalDate = new DateTime(2023, 11, 10) });
                    break;
                case 2:
                    list.Add(new Withdrawal { WithdrawalId = 4, WithdrawalAmount = 300.75, WithdrawalDate = new DateTime(2023, 10, 15) });
                    list.Add(new Withdrawal { WithdrawalId = 5, WithdrawalAmount = 150.50, WithdrawalDate = new DateTime(2023, 9, 30) });
                    break;
                case 3:
                    list.Add(new Withdrawal { WithdrawalId = 6, WithdrawalAmount = 100.00, WithdrawalDate = new DateTime(2023, 8, 25) });
                    list.Add(new Withdrawal { WithdrawalId = 7, WithdrawalAmount = 75.25, WithdrawalDate = new DateTime(2023, 7, 10) });
                    break;
            }
            return list;
        }

        public static List<Withdrawal> Load()
        {
            try
            {
                List<Withdrawal> withdrawals = new List<Withdrawal>();
                Database db = new Database();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tblWithdrawals";
                SqlCommand sqlCommand = new SqlCommand(sql);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Withdrawal withdrawal = new Withdrawal();
                    withdrawal.WithdrawalId = Convert.ToInt32(dr["ID"]);
                    withdrawal.WithdrawalAmount = Convert.ToDouble(dr["Amount"]);
                    withdrawal.WithdrawalDate = Convert.ToDateTime(dr["Date"]);

                    withdrawals.Add((withdrawal));
                }
                return withdrawals;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Withdrawal> Load(int custId)
        {
            try
            {
                List<Withdrawal> withdrawals = new List<Withdrawal>();
                Database db = new Database();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tblWithdrawals WHERE CustID = @CustId";
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.Parameters.AddWithValue("@CustId", custId);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Withdrawal withdrawal = new Withdrawal();
                    withdrawal.WithdrawalId = Convert.ToInt32(dr["ID"]);

                    withdrawal.WithdrawalAmount = Convert.ToDouble(dr["Amount"]);
                    withdrawal.WithdrawalDate = Convert.ToDateTime(dr["Date"]);
                    withdrawal.CustID = Convert.ToInt32(dr["CustID"]);

                    withdrawals.Add((withdrawal));
                }
                return withdrawals;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Withdrawal> Load(short id)
        {
            try
            {
                List<Withdrawal> withdrawals = new List<Withdrawal>();
                Database db = new Database();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tblWithdrawals WHERE ID = @Id";
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.Parameters.AddWithValue("@Id", id);

                dt = db.Select(sqlCommand);

                Withdrawal withdrawal = new Withdrawal();

                foreach (DataRow dr in dt.Rows)
                {

                    withdrawal.WithdrawalId = Convert.ToInt32(dr["ID"]);
                    withdrawal.WithdrawalAmount = Convert.ToDouble(dr["Amount"]);
                    withdrawal.WithdrawalDate = Convert.ToDateTime(dr["Date"]);
                    withdrawal.CustID = Convert.ToInt32(dr["CustID"]);

                    withdrawals.Add((withdrawal));
                }
                return withdrawals;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(Withdrawal withdrawal, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "INSERT INTO tblWithdrawals (ID, Amount, Date, CustID)"
                             + "VALUES (@Id, @Amount, @Date, @CustID)";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@Id", Database.GetNextWithdrawalId());
                sqlCommand.Parameters.AddWithValue("@Amount", withdrawal.WithdrawalAmount);
                sqlCommand.Parameters.AddWithValue("@Date", withdrawal.WithdrawalDate);
                sqlCommand.Parameters.AddWithValue("@CustID", withdrawal.CustID);

                int results = db.Insert(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Update(Withdrawal withdrawal, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "UPDATE tblWithdrawals "
                           + "SET Amount = @Amount, "
                           + "Date = @Date, "
                           + "CustID = @CustID "
                           + "WHERE ID = @Id";

                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("@Id", withdrawal.WithdrawalId);
                sqlCommand.Parameters.AddWithValue("@Amount", withdrawal.WithdrawalAmount);
                sqlCommand.Parameters.AddWithValue("@Date", withdrawal.WithdrawalDate);
                sqlCommand.Parameters.AddWithValue("@CustID", withdrawal.CustID);

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

                string sql = "DELETE FROM tblWithdrawals WHERE ID = @Id";

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

                string sql = "DELETE FROM tblWithdrawals WHERE CustID = @CustID";

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