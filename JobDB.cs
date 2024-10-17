using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobTrackerWinForm
{
    internal class JobDB
    {

        //connecting application to local MAMP server for database
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=job applications;";
        #region GetApplications
        //creating list of all items in database
        public List<JobApplication> GetApplications()
        {
            //start with an empty list
            List<JobApplication> returnList = new List<JobApplication>();
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand("SELECT * FROM application", connection);
            //
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JobApplication applicationOne = new JobApplication
                    {
                        applicationNumber = reader.GetInt32(0),
                        jobTitle = reader.GetString(1),
                        location = reader.GetString(2),
                        status = reader.GetString(3),
                        jobUrl = reader.GetString(4),
                        appCo = (reader.GetString(5)),
                        coID = reader.GetInt32(6),
                    };
                    
                    returnList.Add(applicationOne);
                }
            }
            connection.Close();
            return returnList;
        }
        #endregion
        #region SearchJobs
        public List<JobApplication> SearchJobs(string searchItem)
        {
            //start with an empty list
            List<JobApplication> returnList = new List<JobApplication>();
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //
            string searchWildPhrase = "%" + searchItem + "%";
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM application WHERE Title LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            //
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JobApplication applicationOne = new JobApplication
                    {
                        applicationNumber = reader.GetInt32(0),
                        jobTitle = reader.GetString(1),
                        location = reader.GetString(2),
                        status = reader.GetString(3),
                        jobUrl = reader.GetString(4),
                        appCo = reader.GetString(5),
                        coID = reader.GetInt32(6),
                    };
                    returnList.Add(applicationOne);
                }
            }
            connection.Close();
            return returnList;
        }
        #endregion
        #region SearchCompany
        public List<JobApplication> SearchCompany(string searchItem)
        {
            //start with an empty list
            List<JobApplication> returnList = new List<JobApplication>();
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //
            string searchWildPhrase = "%" + searchItem + "%";
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM application WHERE Company LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            //
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JobApplication applicationOne = new JobApplication
                    {
                        applicationNumber = reader.GetInt32(0),
                        jobTitle = reader.GetString(1),
                        location = reader.GetString(2),
                        status = reader.GetString(3),
                        jobUrl = reader.GetString(4),
                        appCo = (reader.GetString(5)),
                        coID = reader.GetInt32(6),
                    };
                    returnList.Add(applicationOne);
                }
            }
            connection.Close();
            return returnList;
        }
        #endregion
        #region SearchLocation
        public List<JobApplication> SearchLocation(string searchItem)
        {
            //start with an empty list
            List<JobApplication> returnList = new List<JobApplication>();
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //
            string searchWildPhrase = "%" + searchItem + "%";
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM application WHERE Location LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            //
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JobApplication applicationOne = new JobApplication
                    {
                        applicationNumber = reader.GetInt32(0),
                        jobTitle = reader.GetString(1),
                        location = reader.GetString(2),
                        status = reader.GetString(3),
                        jobUrl = reader.GetString(4),
                        appCo = (reader.GetString(5)),
                        coID = reader.GetInt32(6),
                    };
                    returnList.Add(applicationOne);
                }
            }
            connection.Close();
            return returnList;
        }
        #endregion
        #region SearchStatus
        public List<JobApplication> SearchStatus(string searchItem)
        {
            //start with an empty list
            List<JobApplication> returnList = new List<JobApplication>();
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //
            string searchWildPhrase = "%" + searchItem + "%";
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM application WHERE Status LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            //
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JobApplication applicationOne = new JobApplication
                    {
                        applicationNumber = reader.GetInt32(0),
                        jobTitle = reader.GetString(1),
                        location = reader.GetString(2),
                        status = reader.GetString(3),
                        jobUrl = reader.GetString(4),
                        appCo = (reader.GetString(5)),
                        coID = reader.GetInt32(6),
                    };
                    returnList.Add(applicationOne);
                }
            }
            connection.Close();
            return returnList;
        }
        #endregion
        #region addOneJob
        internal int addOneJob(JobApplication newApp)
        {

            
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand("INSERT INTO `application`(`Title`, `Location`, `Status`, `Website`, `Company`,`Company_ID`) VALUES (@jobTitle, @location, @status, @jobUrl, @appCo, @coID)", connection);
            //
            command.Parameters.AddWithValue("@jobTitle", newApp.jobTitle);
            command.Parameters.AddWithValue("@location", newApp.location);
            command.Parameters.AddWithValue("@status", newApp.status);
            command.Parameters.AddWithValue("@jobUrl", newApp.jobUrl);
            command.Parameters.AddWithValue("@appCo", newApp.appCo);
            command.Parameters.AddWithValue("@coID", newApp.coID);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }
        #endregion
        #region GetCompanyForApp
        public List<Company> GetCompanyForApp(int AppID)
        {
            //start with an empty list
            List<Company> returnList = new List<Company>();
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //
            
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM company WHERE ID = @comID";
            command.Parameters.AddWithValue("@comID", AppID);
            command.Connection = connection;
            //
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Company companyOne = new Company
                    {
                       ID = reader.GetInt32(0),
                       name = reader.GetString(1),
                       website = reader.GetString(2),
                       clearedRoles = reader.GetString(3),
                       location = reader.GetString(4)
                    };
                    returnList.Add(companyOne);
                }
            }
            connection.Close();
            return returnList;

        }


        #endregion
        #region deleteApp
        internal int deleteApp(int rowID)
        {
            int result = -1;
            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {
                // SQL statement to retrieve items from database
                MySqlCommand command = new MySqlCommand("DELETE FROM `application` WHERE `application`.Number = @appID;", connection);
                //
                command.Parameters.AddWithValue("@appID", rowID);

                result = command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            { 
                //do noting
            }
            return result;
        }
        #endregion
        #region updateApplicaiton
        internal int updateApplication(JobApplication app)
        {
            //connect database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //sql command to update
            MySqlCommand command = new MySqlCommand("UPDATE `application` SET `Title` = @title, `Location` = @location ,`Status` = @status, `Website` = @website, `Company` = @comp, `Company_ID` = @coID WHERE `application`.`Number` = @number", connection);
           
            command.Parameters.AddWithValue("@title", app.jobTitle);
            command.Parameters.AddWithValue("@location", app.location);
            command.Parameters.AddWithValue("@status", app.status);
            command.Parameters.AddWithValue("@website", app.jobUrl);
            command.Parameters.AddWithValue("@comp", app.appCo);
            command.Parameters.AddWithValue("@coID", app.coID);
            command.Parameters.AddWithValue("@number", app.applicationNumber);
            //
            int updatedRows = command.ExecuteNonQuery();
            connection.Close();

            return updatedRows;
        }
        #endregion
        internal int addOneCompany(Company newCo)
        {


            //connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // SQL statement to retrieve items from database
            MySqlCommand command = new MySqlCommand("INSERT INTO `company`(`Company_Name`, `Company_Url`, `Cleared_Roles`, `Co_Location`) VALUES (@coname, @coUrl, @cleared, @hq)", connection);
            //
            command.Parameters.AddWithValue("@coname", newCo.name);
            command.Parameters.AddWithValue("@coUrl", newCo.website);
            command.Parameters.AddWithValue("@cleared", newCo.clearedRoles);
            command.Parameters.AddWithValue("@hq", newCo.location);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }
    }
}
