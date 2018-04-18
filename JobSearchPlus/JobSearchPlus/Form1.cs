using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobSearchPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTransactionLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the connection string. See ConnectionStrings.com for reference.
                string connectionString = @"Server=PL11\MTCDEVDB;Database=JobSearchPlus;Trusted_Connection=True;";

                // Define the connection using the connection string
                SqlConnection sqlConnecton = new SqlConnection(connectionString);

                // Define a data adapter to pull the data from the server using the connection and a stored procedure
                SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.ActiveContactList", sqlConnecton);

                // Declare an empty data table to hold the data
                DataTable DataTableGridView1 = new DataTable();

                // Fill the data table using the data adapter
                dataAdapter.Fill(DataTableGridView1);

                // Use the data table as the data source for a data grid control
                dataGridView1.DataSource = DataTableGridView1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define the connection string. See ConnectionStrings.com for reference.
            string connectionString = @"Server=PL11\MTCDEVDB;Database=JobSearchPlus;Trusted_Connection=True;";

            // Define the connection using the connection string
            SqlConnection sqlConnecton = new SqlConnection(connectionString);

            // Define a data adapter to pull the data from the server using the connection and a stored procedure
            SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.CallListforActiveLeads", sqlConnecton);

            // Declare an empty data table to hold the data
            DataTable DataTableGridView1 = new DataTable();

            // Fill the data table using the data adapter
            dataAdapter.Fill(DataTableGridView1);

            // Use the data table as the data source for a data grid control
            dataGridView2.DataSource = DataTableGridView1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Define the connection string. See ConnectionStrings.com for reference.
            string connectionString = @"Server=PL11\MTCDEVDB;Database=JobSearchPlus;Trusted_Connection=True;";

            // Define the connection using the connection string
            SqlConnection sqlConnecton = new SqlConnection(connectionString);

            // Define a data adapter to pull the data from the server using the connection and a stored procedure
            SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.LeadReport", sqlConnecton);

            // Declare an empty data table to hold the data
            DataTable DataTableGridView1 = new DataTable();

            // Fill the data table using the data adapter
            dataAdapter.Fill(DataTableGridView1);

            // Use the data table as the data source for a data grid control
            dataGridView3.DataSource = DataTableGridView1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Define the connection string. See ConnectionStrings.com for reference.
            string connectionString = @"Server=PL11\MTCDEVDB;Database=JobSearchPlus;Trusted_Connection=True;";

            // Define the connection using the connection string
            SqlConnection sqlConnecton = new SqlConnection(connectionString);

            // Define a data adapter to pull the data from the server using the connection and a stored procedure
            SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.LeadsbySource", sqlConnecton);

            // Declare an empty data table to hold the data
            DataTable DataTableGridView1 = new DataTable();

            // Fill the data table using the data adapter
            dataAdapter.Fill(DataTableGridView1);

            // Use the data table as the data source for a data grid control
            dataGridView4.DataSource = DataTableGridView1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Define the connection string. See ConnectionStrings.com for reference.
            string connectionString = @"Server=PL11\MTCDEVDB;Database=JobSearchPlus;Trusted_Connection=True;";

            // Define the connection using the connection string
            SqlConnection sqlConnecton = new SqlConnection(connectionString);

            // Define a data adapter to pull the data from the server using the connection and a stored procedure
            SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.LeadsNeedActivity", sqlConnecton);

            // Declare an empty data table to hold the data
            DataTable DataTableGridView1 = new DataTable();

            // Fill the data table using the data adapter
            dataAdapter.Fill(DataTableGridView1);

            // Use the data table as the data source for a data grid control
            dataGridView5.DataSource = DataTableGridView1;
        }
    }
}
