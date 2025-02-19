using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace _83_SQL_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                connectionString = string.Format(
                    "Server={0};Database=Master;User Id={2}",
                    txtServerName.Text, txtUsername.Text
                    );
            }
            else
            {
                connectionString = @"Data Source=OGRETMEN01;
                                    Initial Catalog=Master;
                                    Integrated Security=True;
                                    Connect Timeout=30;Encrypt=True;
                                    Trust Server Certificate=True;
                                    Application Intent=ReadWrite;
                                    Multi Subnet Failover=False";
            }
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SYS.DATABASES";
                conn.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string dbName = sqlDataReader.GetString(0);
                    this.cmbDatabases.Items.Add(dbName);
                }
                sqlDataReader.Close();
                sqlDataReader.Dispose();
                conn.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtServerName.Text = "OGRETMEN01";
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;
            string connectionString = string.Empty;

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                connectionString = string.Format(
                    "Server={0};Database={1};User Id={2}",
                    txtServerName.Text, dbName, txtUsername.Text
                    );
            }
            else
            {
                connectionString = @"Data Source=OGRETMEN01;
                                    Initial Catalog=Master;
                                    Integrated Security=True;
                                    Connect Timeout=30;Encrypt=True;
                                    Trust Server Certificate=True;
                                    Application Intent=ReadWrite;
                                    Multi Subnet Failover=False";
            }
            try
            {
                cmbTables.Items.Clear();
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT name FROM SYS.TABLES";
                conn.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string tableName = sqlDataReader.GetString(0);
                    this.cmbTables.Items.Add(tableName);
                }
                sqlDataReader.Close();
                sqlDataReader.Dispose();
                conn.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;
            string connectionString = string.Empty;

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                connectionString = string.Format(
                    "Server={0};Database={1};User Id={2}",
                    txtServerName.Text, dbName, txtUsername.Text
                    );
            }
            else
            {
                connectionString = @"Data Source=OGRETMEN01;
                                    Initial Catalog=Master;
                                    Integrated Security=True;
                                    Connect Timeout=30;Encrypt=True;
                                    Trust Server Certificate=True;
                                    Application Intent=ReadWrite;
                                    Multi Subnet Failover=False";
            }
            try
            {
                clbColumns.Items.Clear();
                string tableName = cmbTables.Text;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                    "SELECT COLUMN_NAME FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=@TableName", dbName);
                cmd.Parameters.AddWithValue("@TableName", tableName);
                conn.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string columnName = sqlDataReader.GetString(0);
                    this.clbColumns.Items.Add(columnName);
                }
                sqlDataReader.Close();
                sqlDataReader.Dispose();
                conn.Close();
                //
                string query = string.Format("SELECT * FROM {0}", tableName);
                txtQuery.Text = query;
                cmd.CommandText = query;
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dataTable);
                dvgResults.DataSource = dataTable;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;
            string connectionString = string.Empty;
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                connectionString = string.Format("Server={0};Database={1};User Id={2}", txtServerName.Text, dbName, txtUsername.Text);
            }
            else
            {
                connectionString = @"Data Source=OGRETMEN01;Initial Catalog=Master;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            }
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = txtQuery.Text;
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd); sqlDataAdapter.Fill(dataTable);
                dvgResults.DataSource = dataTable;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }

        private void clbColumns_SelectedIndexChanged(object sender, EventArgs e){
            #region Sabit Kodlar
            string dbName = cmbDatabases.Text;
            string connectionString = string.Empty;
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                connectionString = string.Format("Server={0};Database={1};User Id={2}", txtServerName.Text, dbName, txtUsername.Text);
            }
            else
            {
                connectionString = @"Data Source=OGRETMEN01;Initial Catalog=Master;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            }
            string tablename = cmbTables.Text;
            #endregion
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                string sorgu = string.Empty;
                string kolonlar = string.Empty;
                if (clbColumns.CheckedItems.Count > 0) 
                {
                    foreach (object item in clbColumns.CheckedItems)
                    {
                        kolonlar += string.Format("[{0}],", item.ToString());
                    }
                    kolonlar = kolonlar.TrimEnd(','); //sonundaki virgülü kaldýrmak iç
                }
                else{
                    kolonlar = "*"; //eðer hiç bir kolon seçilmemiþse.
                }
               sorgu = string.Format("SELECT {0} FROM {1}", kolonlar, tablename);
                cmd.CommandText = sorgu;
                txtQuery.Text = sorgu;
            }
            catch (Exception exc){ MessageBox.Show(exc.ToString()); }
        }
    }
}

