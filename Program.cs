using System;
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
            click = choice();

            switch (click)
            {
                case 'A':
                    //call ang class/project about inventory status.
                    break;
                case 'B':
                    Console.WriteLine("============================");
                    Console.WriteLine("\nSUPPLY MANAGEMENT OPTION:");
                    crudFeatures();
                    click = choice();

                    if (click == 'A')
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("\nCreating/Adding an Item: ");
                        Console.WriteLine("============================");
                        suppliersList();
                        click = choice();
                        if (click == 'A')
                        {

                        }

                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again!");
                    break;
            }



        }
        static char choice()
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

        static void suppliersList()
        {
            Console.WriteLine("\n============================");
            Console.WriteLine("Products Category:");
            Console.WriteLine("============================");
            Console.WriteLine("A. CANS" + "\nB. HYGIENE PRODUCTS" + "\nC. "
            + "\nD. BISCUITS/CHICHIRYA" + "\nE. SOFTDRINKS");
        }


    }
}
