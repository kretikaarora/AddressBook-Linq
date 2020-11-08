// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Before Editing");
            AddressBookManagement.CreateDataTable();
            AddressBookManagement.DisplayDataTable();
            Console.WriteLine("************************************************************");
            AddressBookManagement.EditExistingContactDetail();
            Console.WriteLine("After Editing");
            AddressBookManagement.DisplayDataTable();
            Console.WriteLine("************************************************************");
            AddressBookManagement.DeletePersonContactUsingName();
            Console.WriteLine("After Deleting");
            AddressBookManagement.DisplayDataTable();
           
        }
    }
}
