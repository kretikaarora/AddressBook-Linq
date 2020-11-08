// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookManagement.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinq
{
    public class AddressBookManagement
    {
        public DataTable table = new DataTable();

        /// <summary>
        /// Creating Data Table 
        /// Uc1
        /// </summary>
        public static void CreateDataTable()
        {
            ///adding columns
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            addressBookManagement.table.Columns.Add("FirstName", typeof(string));
            addressBookManagement.table.Columns.Add("LastName", typeof(string));
            addressBookManagement.table.Columns.Add("Address", typeof(string));
            addressBookManagement.table.Columns.Add("City", typeof(string));
            addressBookManagement.table.Columns.Add("State", typeof(string));
            addressBookManagement.table.Columns.Add("Zip", typeof(string));
            addressBookManagement.table.Columns.Add("PhoneNumber", typeof(string));
            addressBookManagement.table.Columns.Add("EmailId", typeof(string));
            ///adding rows
            addressBookManagement.table.Rows.Add("Kretika", "Arora", "Street1", "Faridabad", "Haryana", 121001, "9650925666", "kretikaarora@gmail.com");
            addressBookManagement.table.Rows.Add("katrina", "kres", "Street2", "Mumbai", "Maharashtra", 878001, "890925666", "katrinakres@gmail.com");
            addressBookManagement.table.Rows.Add("kajal", "klei", "Street3", "hyderabad", "Telangana", 841001, "7412925666", "kajalklei@gmail.com");
            addressBookManagement.table.Rows.Add("Kim", "Kadash", "Street4", "Paris", "France", 7894551, "4569925666", "kimkadash@gmail.com");
        }
    }
}
