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
            AddressBookManagement.CreateDataTable();
            AddressBookManagement.DisplayDataTable();
            //Console.WriteLine("*******************************************");
            //AddressBookManagement.SortedContactsByNameForAgivenCity();
            //Console.WriteLine("********************************************");
            //AddressBookManagement.SortedContactsByNameForAgivenState();
            

        }
    }
}
