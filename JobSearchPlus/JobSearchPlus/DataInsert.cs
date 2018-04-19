using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// MUST HAVE using System.Data; using System.Data.SqlClient; ^^^^ when doing this

namespace JobSearchPlus
{
    class DataInsert
    {
        // Declare a constant to hold the connection @"Server=;Database=;Trusted_Connection= (Windows Authentication Y or N)"
        const string varConDefault = @"Server=PL11\MTCDEVDB;Database=JobSearchPlus;Trusted_Connection=True;";
        // Declare SQL connection
        SqlConnection varSqlconnect;

        private bool DBConnect(string varConnectionString = "")
        {
            bool returnValue;

            // If no connection string was specified, use the default
            if (varConnectionString.Length == 0)
            {
                varConnectionString = varConDefault;
            }

            try
            {
                // Open the connection to SQL server
                varSqlconnect = new SqlConnection(varConnectionString);
                varSqlconnect.Open();
                returnValue = true;
            }
            catch (Exception Ex)
            {
                returnValue = false;
                throw Ex;
            }

            return returnValue; 
        }

        public bool InsertNewLead(DateTime RecordDate, string JobTitle, string Description, string EmploymentType
            , string Location, out int LeadID)
        {
            LeadID = 0;
            bool returnValue = false;

            // Insert the specified information as a new job lead
            try
            {
                if (DBConnect())
                {
                    //Create new command for stored procedure
                    SqlCommand insertIntoLeads = new SqlCommand("InsertLeads", varSqlconnect);
                    insertIntoLeads.CommandType = CommandType.StoredProcedure;

                    //Link the Paramaters with the column names from Sql
                    insertIntoLeads.Parameters.AddWithValue("@RecordDate", RecordDate);
                    insertIntoLeads.Parameters.AddWithValue("@JobTitle", JobTitle);
                    insertIntoLeads.Parameters.AddWithValue("@Description", Description);
                    insertIntoLeads.Parameters.AddWithValue("@EmploymentType", EmploymentType);
                    insertIntoLeads.Parameters.AddWithValue("@Location", Location);

                    //Output for LeadID
                    insertIntoLeads.Parameters.AddWithValue("@LeadID", LeadID).Direction = ParameterDirection.Output;

                    // Run command
                    insertIntoLeads.ExecuteNonQuery();

                    // Retieve LeadID Value
                    LeadID = int.Parse(insertIntoLeads.Parameters["@LeadID"].Value.ToString());

                    returnValue = true;
                }
                
            }
            catch (Exception Ex)
            {
                returnValue = false;
                throw Ex;
            }

            return returnValue;
        }

        public DataTable GetCallList()
        {
            // Define Datatable
            DataTable dtCallList = new DataTable();

            // Get data from jobsearch plus

            try
            {
                if (DBConnect())
                {
                    // Define Adapter, "dbo.ActiveContactList" is stored procedure
                    SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.ActiveContactList", varSqlconnect);
                    // Fill DataTable with storedProcedure results
                    sqlDA.Fill(dtCallList);
                }
                else
                {
                    throw new Exception("Could not connext to JobSearch Plus database");
                }
                
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            return dtCallList;
        }

        public DataTable GetLeadsBySource()
        {
            // Define DataTable
            DataTable dtLeadsBySource = new DataTable();

            try
            {
                if (DBConnect())
                {
                    // Define Adapter, "dbo.ActiveContactList" is stored procedure
                    SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.LeadsbySource", varSqlconnect);
                    // Fill DataTable with storedProcedure results
                    sqlDA.Fill(dtLeadsBySource);
                }
                else
                {
                    throw new Exception("Could not connext to JobSearch Plus database");
                }

            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            return dtLeadsBySource;
        }

    }
}
