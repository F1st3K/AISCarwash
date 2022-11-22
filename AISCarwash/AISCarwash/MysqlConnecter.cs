using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
            DataTable table = new DataTable();
            string query = $"SELECT {column} FROM {tableName} WHERE {condition};";
            try 
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(table);
                _dbConection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return table;
        }
        public static void QueryAddInTable(string tableName, string values)
        {
            string query = $"INSERT INTO {tableName} VALUES ({values});";
            try
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                command.ExecuteNonQuery();
                _dbConection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        public static void QueryChangeInTable(string tableName, string values, string condition)
        {
            string query = $"UPDATE {tableName} SET {values} WHERE {condition};";
            try
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                command.ExecuteNonQuery();
                _dbConection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        public static void QueryDeleteInTable(string table, string condition)
        { 
            string query = $"DELETE FROM {table} WHERE {condition};";
            try
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                command.ExecuteNonQuery();
                _dbConection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        public static DataGridView ChangeColumnsName(DataGridView dgv, params string[] Names)
        {
            int lenght;
            if (dgv.ColumnCount < Names.Length)
                lenght = dgv.ColumnCount;
            else 
                lenght = Names.Length;
            for (int i = 0; i < lenght; i++)
                dgv.Columns[i].HeaderText = Names[i];
            return dgv;
        }
        public static bool StringsIsEmpty(params string[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == string.Empty)
                {
                    MessageBox.Show("Слишком мало данных для формирования записи", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
    }
}