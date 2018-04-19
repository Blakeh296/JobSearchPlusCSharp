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
        DataInsert DataIn = new DataInsert();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataIn == Refer line 16, GetCallList(); == Method from class
            dataGridView1.DataSource = DataIn.GetCallList();

            // DataIn == Refer line 16, GetLeadsBySource(); == Method from class
            dataGridView4.DataSource = DataIn.GetLeadsBySource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btnAddLead_Click(object sender, EventArgs e)
        {
            int LeadID;

            try
            {
                DataIn.InsertNewLead( DateTime.Parse(tbRecordDate.Text) , tbJobTitle.Text, tbDescription.Text, tbEmploymentType.Text
                    , tbLocation.Text, out LeadID);

                lblOutput.Text = LeadID.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        
    }
    }

