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
    static class MySqlConnecter
    {
        private static string _connectionString = "host='localhost';database='carwah_shema';uid='root';pwd='';charset=utf8;";
        private static MySqlConnection _dbConection = new MySqlConnection(_connectionString);
        
        public static DataTable QueryReturnTable(string column, string tableName, string condition)
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
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            _dbConection.Close();
            return table;
        }
        public static void QueryAddInTable(string table, string values)
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
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            _dbConection.Close();
        }
        public static void QueryChangeInTable(string table, string values, string condition)
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
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            _dbConection.Close();
        }
        public static void QueryDeleteInTable(string table, string condition)
        { 
            string query = $"DELETE FROM {table} WHERE {condition};";
            _dbConection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            _dbConection.Close();
        }

    }
}