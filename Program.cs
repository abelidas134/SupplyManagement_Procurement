using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace SupplyManagement_Procurement
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char click;
            Console.WriteLine("PROCUREMENT");
            Console.WriteLine("=======================================================");
            Console.WriteLine("Proceeding to Supply Management Section...");
            Console.WriteLine("=======================================================");

            Console.WriteLine("\nA — Inventory Status: ");//Dito parang for viewing lang sa user
            Console.WriteLine("\nB — Suppliers: ");
            Console.WriteLine("\nC — Purchase: ");
            Console.WriteLine("\nD – Exit: ");
            click = choiceLetter();

            switch (click)
            {
                case 'A':
                    //call ang class/project about inventory status.
                    break;
                case 'B':
                    Console.WriteLine("============================");
                    Console.WriteLine("\nSUPPLIERS:");
                    crudFeatures();
                    click = choiceLetter();

                    if (click == 'A')
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("\nCreating/Adding a Supplier: ");
                        Console.WriteLine("============================");
                        suppliersProducts();
                        click = choiceLetter();
                        if (click == 'A')
                        {
                            
                        } else if (click == 'B')
                        {
                            

                        }

                    } else if (click=='B')
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("\nView List of Suppliers: ");
                        Console.WriteLine("============================");


                    } else if (click =='C')
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("\nUpdate a Supplier: ");
                        Console.WriteLine("============================");


                    } else if (click =='D')
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("\nDelete a Supplier: ");
                        Console.WriteLine("============================");

                    }
                    break;
                case 'C':
                    //If less than 10 na bibili ka from the list of suppliers.

                    break;
                case 'D':
                    Console.WriteLine("Ending the program...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again!");
                    break;
            }



        }
        static char choiceLetter()
        {
            Console.WriteLine("\n============================");
            Console.Write("\nEnter: ");
            char click = Console.ReadLine()[0];
            return click;
        }

        static void crudFeatures()
        {
            Console.WriteLine("\nA — Add: ");
            Console.WriteLine("\nB — View: ");
            Console.WriteLine("\nC — Update: ");
            Console.WriteLine("\nD – Delete: ");
        }

        static void suppliersProducts()
        {
            Console.WriteLine("\n============================");
            Console.WriteLine("PRODUCTS CATEGORY:");
            Console.WriteLine("============================");
            Console.WriteLine("A. CANNED GOODS" + "\nB. HYGIENE PRODUCTS" + "\nC. NOODLES"
            + "\nD. BISCUITS/CHICHIRYA" + "\nE. SOFTDRINKS");

        }

        static void suppliersList () 
        {
            List<string> suppliersListCans = new List<string>() {"\n1. Century Pacific Food, Inc.",
                "\n2. Mega Prime Foods Inc.", "\n3. CDO Foodsphere, Inc.",
                "\n4. San Miguel Foods Inc.", "\n5. Delimondo Food Specialties Inc."};

            List<string> suppliersListHygiene = new List<string>() {"\n1. Unilab, Inc.", "\n2. Splash Corporation",
                "\n3. Peerless Products Manufacturing Corporation", "\n4. Gandang Kalikasan Inc. (Human Nature)",
                "\n5. Procter & Gamble Philippines"};

            List<string> suppliersListNoodles = new List<string>() {"\n1. Monde Nissin Corporation", "\n2. Universal Robina Corporation",
                "\n3.Nissin Foods Philippines", "\n4. San Miguel Foods Inc.", "\n5. Century Pacific Foods, Inc."};

            List<string> suppliersListBiscuits = new List<string>() {"\n1. Rebisco", "\n2. Universal Robina Corporation",
                "\n3. LIwayway Marketing Corporation (Oishi)", "\n4. JBC Food Corporation", "\n5. Jack 'n Jill (URC Brand)"};

            List<string> suppliersListDrinks = new List<string>() {"\n1. Coca-Cola Beverages Philippines", "\n2. Pepsi-Cola Products Philippines, Inc.",
                "\n3 ABC Refreshements Corporation", "\n4. Asia Bravery, Inc.", "\n5. San Miguel Corporation"};

        }


    }
}
