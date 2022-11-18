using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace AISCarwash
{
    internal class MySqlConnecter
    {
        private MySqlConnection _dbConection;
        private string _connectionString;
        public MySqlConnecter(string connectionString)
        {
            _connectionString = connectionString;
            _dbConection = new MySqlConnection(connectionString);
        }
        public DataTable QueryReturnTable(string column, string tableName, string condition)
        {
            string query = $"SELECT {column} FROM {tableName} WHERE {condition};";
            DataTable table = new DataTable();
            _dbConection.Open();
            try 
            {
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!" + " - некоректное имя!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            _dbConection.Close();
            return table;
        }
        public void QueryAddInTable(string table, string values)
        {
            string query = $"INSERT INTO {table} VALUES ({values});";
            _dbConection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!" + " - некоректное имя!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            _dbConection.Close();
        }
        public void QueryChangeInTable(string table, string values, string condition)
        {
            string query = $"UPDATE {table} SET {values} WHERE {condition};";
            _dbConection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!" + " - некоректное имя!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            _dbConection.Close();
        }
        
    }
}