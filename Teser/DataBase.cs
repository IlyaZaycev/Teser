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
        public SqlConnection sqlConnection =
            new SqlConnection(
                @"Data Source=(local);Initial Catalog=TestDB;Persist Security Info=True;User ID=sa;Password=sa");
        public SqlCommand command = new SqlCommand();
        public SqlDataAdapter adapter = new SqlDataAdapter();


        public string obj = String.Empty;
        public string cost = String.Empty;
        public string kdNumber = string.Empty;
        public string KDdateDetermenation = String.Empty;
        public int taxYear = 20000;
        public int dropTax = 550000;
        public int dropTaxYear = 11000;
        public int saving = 9000;
        public string notes = "String.Empty";

        public void OpenConnection()
        {
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Подключение выполнено успешно");
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

        public void PostInfo(string abc)
        {
            try
            {
                var scanDoc = new ScanDoc();
                obj = scanDoc.FindObject(abc);
                kdNumber = scanDoc.FindKadNumber(abc);
                cost = scanDoc.FindKadCost(abc);
                KDdateDetermenation = scanDoc.FindKDdateDetermenation(kdNumber);
                string sqlExpression =
                    $"INSERT INTO testTable (id, object, KDcost, KDdateDetermenation, taxYear, dropTax, dropTaxYear, saving, notes) VALUES ('{1}','{obj}', '{cost}', '{KDdateDetermenation}', '{taxYear}', '{dropTax}', '{dropTaxYear}', '{saving}', '{notes}')";
                sqlConnection.Open();
                command = new SqlCommand(sqlExpression, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Данные занесены в таблицу");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                
            }
        }
    }
}
//