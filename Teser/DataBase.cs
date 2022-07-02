using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teser
{
    public class DataBase
    {
        private readonly SqlConnection sqlConnection =
            new SqlConnection(
                @"Data Source=(local);Initial Catalog=TestDB;Persist Security Info=True;User ID=sa;Password=sa");

        private SqlCommand command = new SqlCommand();

        public void OpenConnection()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    MessageBox.Show("Подключение выполнено успешно");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка!", "Невозможно подключиться к Базе Данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Connection are closed");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка!", "Невозможно закрыть соединение с Базой данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public void PostInfo( /*string column*/)
        {
            List<string> listObject = new List<string>();
            List<string> listKDcost = new List<string>();
            List<string> listKDdateDetermenation = new List<string>();
            List<string> listTaxPrecent = new List<string>();
            List<string> listTaxYear = new List<string>();
            List<string> listDropTax = new List<string>();
            List<string> listDropTaxYear = new List<string>();
            List<string> listSaving = new List<string>();
            List<string> listSavingRetrospective = new List<string>();
            List<string> listSavingPerspective = new List<string>();
            List<string> listSavingPerspectiveTenYears = new List<string>();
            List<string> listNotes = new List<string>();
            string sqlExpression = "SELECT * FROM FinalTable";
            try
            {
                OpenConnection();
                command = new SqlCommand(sqlExpression);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}