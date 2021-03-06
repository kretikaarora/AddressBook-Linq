﻿// --------------------------------------------------------------------------------------------------------------------
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
            table.Columns.Add("AddressBookName", typeof(string));
            table.Columns.Add("AddressBookType", typeof(string));
            ///adding rows
            table.Rows.Add("Kretika", "Arora", "Street1", "Faridabad", "Haryana", "121001", "9650925666", "kretikaarora@gmail.com","A1","Friends");
            table.Rows.Add("alisha", "kres", "Street2", "Mumbai", "Maharashtra", "878001", "890925666", "katrinakres@gmail.com","B1","Family");
            table.Rows.Add("Priya", "klei", "Street3", "Mumbai", "Maharashtra", "841001", "7412925666", "kajalklei@gmail.com","C1","Proffesional");
            table.Rows.Add("Malviya", "Kadash", "Street4", "Faridabad", "Haryna", "7894551", "4569925666", "ash@gmail.com","D1","Family");
            table.Rows.Add("lary", "Kadash", "Street5", "Paris", "France", "7894551", "9925666", "adash@gmail.com","E1","Friends");
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
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<string>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID")+"AddressBookName :"+ row.Field<string>("AddressBookName")+"  AddressBookType :"+ row.Field<string>("AddressBookType"));
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

        /// <summary>
        /// Delete Person Contact Using Name
        /// UC5
        /// </summary>
        public static void DeletePersonContactUsingName()
        {
            var record = table.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals("katrina")).FirstOrDefault();
            record.Delete();
        }

        /// <summary>
        /// Retrieving Contact Details By City
        /// UC6
        /// </summary>
        public static void RetrievingContactDetailsByCity()
        {
            var records = table.AsEnumerable().Where(a => a.Field<string>("city").Equals("Faridabad"));
            foreach (var row in records)
            {
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<string>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Retrieving Contact Details By State
        /// UC6
        /// </summary>
        public static void RetrievingContactDetailsByState()
        {
            var records = table.AsEnumerable().Where(a => a.Field<string>("state")== "Maharashtra");
            var recordData = table.AsEnumerable().Where(r => r.Field<string>("city") == "Mumbai").OrderBy(r => r.Field<string>("firstName")).ThenBy(r => r.Field<string>("lastName"));
            foreach (var row in records)
            {
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<string>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Count by City
        /// UC7
        /// </summary>
        public static void CountByCity()
        {
            var records = table.AsEnumerable().Where(a => a.Field<string>("city").Equals("Faridabad"));
            Console.WriteLine("The count for records by city is  : "+ records.Count());
        }

        /// <summary>
        /// Count by City
        /// UC7
        /// </summary>
        public static void CountByState()
        {
            var records = table.AsEnumerable().Where(a => a.Field<string>("state").Equals("Maharastra"));
            Console.WriteLine("The count for records by state is  is : " + records.Count());
        }

        /// <summary>
        /// Sorted Contacts By Name For A given City
        /// UC8
        /// </summary>      
        public static void SortedContactsByNameForAgivenCity()
        {
            Console.WriteLine("Sorting by name for a Mumbai City");
            var records = table.AsEnumerable().Where(r => r.Field<string>("city") == "Mumbai").OrderBy(r => r.Field<string>("firstName")).ThenBy(r => r.Field<string>("lastName"));
            foreach (var row in records)
            {
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<string>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Sorted Contacts By Name For A given State
        /// UC8
        /// </summary>
        public static void SortedContactsByNameForAgivenState()
        {
            Console.WriteLine("Sorting by name for a Maharastra state");
            var records = table.AsEnumerable().Where(r => r.Field<string>("state") == "Maharashtra").OrderBy(r => r.Field<string>("firstName")).ThenBy(r => r.Field<string>("lastName"));
            foreach (var row in records)
            {
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<string>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Count By AddressBook Type
        /// UC10
        /// </summary>
        public static void CountByAddressBookType()
        {
            var records = table.AsEnumerable().GroupBy(a => a.Field<string>("AddressBookType")).Select(x => new{ type = x.Key, count = x.Count() });
            foreach (var row in records)
            {         
                Console.WriteLine("Type : "+row.type + " Count :"+row.count);
            }
        }
    }
}
