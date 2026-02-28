using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;

namespace SupplyManagement_Procurement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PROCUREMENT");

            Console.WriteLine("\nProceeding to Supply Management Section (yes/no)...");
            string Opt = Console.ReadLine();

            while (Opt == "yes")
            {

                Console.WriteLine("\nITEMS AVAILABILITY (A):");
                Console.WriteLine("PURCHASE (B):");
                Console.WriteLine("SUPPLIERS (C):");

                Console.Write("CLICK: ");
                string click = Console.ReadLine();

                if (click == "A")
                {
                    ItemsAvail();
                    continue;
                }
                else if (click == "B")
                {
                    Purchase();
                    continue;
                }
                else if (click == "C")
                {
                    Suppliers();
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
                }




            }
        }


        static void ItemsAvail()
        {
            Console.WriteLine("\nCATEGORY:");
            Console.WriteLine("\nFresh Produce (F):");
            Console.WriteLine("Protein (P):");
            Console.WriteLine("Canned Goods (C):");

            Console.Write("CLICK: ");
            string click = Console.ReadLine();

            if (click == "F")
            {

                List<String> sampleFreshProd;
                sampleFreshProd = new List<String>() { "Fruits", "Vegetables" };

                foreach (var log in sampleFreshProd)
                {
                    Console.WriteLine(log);
                }

            }
            else if (click == "P")
            {

                List<String> sampleProtein;
                sampleProtein = new List<String>() { "Meat", "Fish", "Eggs" };

                foreach (var log in sampleProtein)
                {
                    Console.WriteLine(log);
                }

            }
            else if (click == "C")
            {

                List<String> sampleCanned;
                sampleCanned = new List<String>() { "Sardines", "Pork Goods", "Beef Goods" };

                foreach (var log in sampleCanned)
                {
                    Console.WriteLine(log);
                }
            }
        }

        static void Purchase()
        {
            ////Output = List of Items
            ////C - Create a New Item
            //R - Searching / Finding an Item
            //U - Add an item
            //D - DeleteDirectoryOption
        }

        static void Suppliers()
        {
            //Output = Name of Suppliers
            //
        }




    }
}