// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookManagement.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookLinq
{
    public class AddressBookManagement
    {
        public static  DataTable table = new DataTable();
        

        /// <summary>
        /// Creating Data Table 
        /// Uc1
        /// </summary>
        public static void CreateDataTable()
        {
            
            ///adding columns           
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("EmailId", typeof(string));
            ///adding rows
            table.Rows.Add("Kretika", "Arora", "Street1", "Faridabad", "Haryana", "121001", "9650925666", "kretikaarora@gmail.com");
            table.Rows.Add("katrina", "kres", "Street2", "Mumbai", "Maharashtra", "878001", "890925666", "katrinakres@gmail.com");
            table.Rows.Add("kajal", "klei", "Street3", "hyderabad", "Telangana", "841001", "7412925666", "kajalklei@gmail.com");
            table.Rows.Add("Kim", "Kadash", "Street4", "Paris", "France", "7894551", "4569925666", "kimkadash@gmail.com");
        }

        /// <summary>
        /// Inserting a Row in DataTable
        /// UC2
        /// </summary>
        public static void InsertRowIntoTable()
        {
            DataRow dr = table.NewRow();
            dr[0] = "komal";
            dr[1] = "Sharma";
            dr[2] = "Street6";
            dr[3] = "Navi mumbai";
            dr[4] = "Maharashtra";
            dr[5] = 6665443;
            dr[6] = "87764478986";
            dr[7] = "komalsharma@gmail.com";
            table.Rows.Add(dr);
        }


        /// <summary>
        /// Displaying Data Table
        /// UC3
        /// </summary>
        public static void DisplayDataTable()
        {
            var records = table.AsEnumerable();
            foreach (var row in records)
            {
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<string>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Editing exiting Contact Details
        /// UC4
        /// </summary>
        public static void EditExistingContactDetail()
        {
            var record = table.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals("katrina")).FirstOrDefault();
            record["state"] = "Mahar.";
        }
    }
}
