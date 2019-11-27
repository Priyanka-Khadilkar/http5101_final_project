using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace http5101_final_project
{
    public class CMSDB
    {
        //user of the database
        private static string User { get { return "root"; } }

        //password of the database
        private static string Password { get { return ""; } }

        //Name of database
        private static string Database { get { return "cms"; } }
        
        //Server of database
        private static string Server { get { return "localhost"; } }

        //Port of the database
        private static string Port { get { return "3306"; } }

      //Connection string to connect database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        //public ContentPage Find_Page(int page_id)
        //{
        //    //Utilize the connection string
        //    MySqlConnection Connect = new MySqlConnection(ConnectionString);

        //    //create a "blank" page
        //    ContentPage Result_Page = new ContentPage();

        //    try
        //    {
        //        string query = "select * from ";
        //        query = String.Format(query, new_student.GetFname(), new_student.GetLname(), new_student.GetNumber(), studentid);

        //    }
        //    catch(Exception ex)
        //    {

        //    }
        


        //}
    }
}