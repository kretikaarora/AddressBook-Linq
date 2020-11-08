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
            //Console.WriteLine("Before Editing");
            AddressBookManagement.CreateDataTable();
            
            Console.WriteLine("Contacts by a city Faridabad");
            AddressBookManagement.RetrievingContactDetailsByCity();
            AddressBookManagement.CountByCity();
            Console.WriteLine();
            Console.WriteLine("Contacts by a state Maharastra");
            AddressBookManagement.RetrievingContactDetailsByState();
            AddressBookManagement.CountByState();
            

        }
    }
}
