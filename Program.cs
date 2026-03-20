using System;
using System.Collections.Generic;

namespace SupplyManagement_Procurement
{
    internal class Program
    {
        static char click;
        static List<string>[] suppliers = suppliersList();
        static string supplierName = "Mickey";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPROCUREMENT");
                Console.WriteLine("Proceeding to Supply Management Section...");

                Console.WriteLine("\nA — Inventory Status: ");
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
                        Console.WriteLine("\nSUPPLIERS:");
                        crudFeatures();
                        click = choiceLetter();

                        if (click == 'A')
                        {
                            Console.WriteLine("\nCreating/Adding a Supplier: ");
                            suppliersProducts();
                            click = choiceLetter();

                            if (click == 'A')
                            {
                                inputSuppliers();
                                addSupplier();
                            }
                            else if (click == 'B')
                            {
                                inputSuppliers();
                                addSupplier();
                            }
                            else if (click == 'C')
                            {
                                inputSuppliers();
                                addSupplier();
                            }
                            else if (click == 'D')
                            {
                                inputSuppliers();
                                addSupplier();
                            }
                            else if (click == 'E')
                            {
                                inputSuppliers();
                                addSupplier();
                            }

                        }
                        else if (click == 'B')
                        {
                            Console.WriteLine("\nView List of Suppliers: ");
                            suppliersProducts();
                            click = choiceLetter();

                            if (click == 'A')
                            {
                                viewSupplier();
                            }
                            else if (click == 'B')
                            {
                                viewSupplier();
                            }
                            else if (click == 'C')
                            {
                                viewSupplier();
                            }
                            else if (click == 'D')
                            {
                                viewSupplier();
                            }
                            else if (click == 'E')
                            {
                                viewSupplier();
                            }

                        }
                        else if (click == 'C')
                        {
                            Console.WriteLine("\nUpdate a Supplier: ");
                            //Hihirapan ako dito wait lang po hehe

                        }
                        else if (click == 'D')
                        {
                            Console.WriteLine("\nDelete a Supplier: ");
                            deleteSupplierOption();
                            choiceLetter();

                            switch (click)
                            {
                                case 'A':
                                    suppliersProducts();
                                    click = choiceLetter();
                                    deleteElem();
                                    break;
                                case 'B':
                                    suppliersProducts();
                                    click = choiceLetter();
                                    if (click == 'A')
                                    {
                                        suppliers[0].Clear();
                                    }
                                    else if (click == 'B')
                                    {
                                        suppliers[1].Clear();
                                    }
                                    else if (click == 'C')
                                    {
                                        suppliers[2].Clear();
                                    }
                                    else if (click == 'D')
                                    {
                                        suppliers[3].Clear();
                                    }
                                    else if (click == 'E')
                                    {
                                        suppliers[4].Clear();
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again!");
                                    break;
                            }

                        }
                        break;
                    case 'C':
                        break;
                    case 'D':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again!");
                        break;
                }

            }

        }

        static char choiceLetter()
        {
            Console.WriteLine("\nEnter: ");
            click = Console.ReadLine()[0];
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
            Console.WriteLine("\nPRODUCTS CATEGORY:");
            Console.WriteLine("A. CANNED GOODS" + "\nB. HYGIENE PRODUCTS" + "\nC. NOODLES"
            + "\nD. BISCUITS/CHICHIRYA" + "\nE. SOFTDRINKS");

        }

        static List<string>[] suppliersList()
        {
            List<string>[] suppliers = new List<string>[5];

            suppliers[0] = new List<string>
            {
                 "Century Pacific Food, Inc.",
                "Mega Prime Foods Inc.",
                "CDO Foodsphere, Inc.",
                "San Miguel Foods Inc.",
                "Delimondo Food Specialties Inc."
            };

            suppliers[1] = new List<string>
            {
                "Unilab, Inc.",
                "Splash Corporation",
                "Peerless Products Manufacturing Corporation",
                "Gandang Kalikasan Inc. (Human Nature)",
                "Procter & Gamble Philippines"
            };

            suppliers[2] = new List<string>
            {
                "Monde Nissin Corporation",
                "Universal Robina Corporation",
                "Nissin Foods Philippines",
                "San Miguel Foods Inc.",
                "Century Pacific Foods, Inc."
            };

            suppliers[3] = new List<string>
            {
                "Rebisco",
                "Universal Robina Corporation",
                "Liwayway Marketing Corporation (Oishi)",
                "JBC Food Corporation",
                "Jack 'n Jill (URC Brand)"
            };

            suppliers[4] = new List<string>
            {
                "Coca-Cola Beverages Philippines",
                "Pepsi-Cola Products Philippines, Inc.",
                "ABC Refreshments Corporation",
                "Asia Bravery, Inc.",
                "San Miguel Corporation"
            };

            return suppliers;
        }

        static void inputSuppliers()
        {
            Console.Write("\nEnter Supplier's Name: ");
            supplierName = Console.ReadLine();
        }

        static void addSupplier()
        {
            if (click == 'A')
            {
                suppliers[0].Add(supplierName);
                Console.WriteLine("\nAdded Successfully!");
            }
            else if (click == 'B')
            {
                suppliers[1].Add(supplierName);
                Console.WriteLine("\nAdded Successfully!");
            }
            else if (click == 'C')
            {
                suppliers[2].Add(supplierName);
                Console.WriteLine("\nAdded Successfully!");
            }
            else if (click == 'D')
            {
                suppliers[3].Add(supplierName);
                Console.WriteLine("\nAdded Successfully!");
            }
            else if (click == 'E')
            {
                suppliers[4].Add(supplierName);
                Console.WriteLine("\nAdded Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Category!");
            }
        }

        static void viewSupplier()
        {
            if (click == 'A')
            {
                Console.WriteLine("\nCanned Goods Suppliers:");
                foreach (var supplier in suppliers[0])
                {
                    Console.WriteLine(supplier);
                }

            }
            else if (click == 'B')
            {
                Console.WriteLine("\nHygiene Products Suppliers:");
                foreach (var supplier in suppliers[1])
                {
                    Console.WriteLine(supplier);
                }
            }
            else if (click == 'C')
            {
                Console.WriteLine("\nNoodles Suppliers:");
                foreach (var supplier in suppliers[2])
                {
                    Console.WriteLine(supplier);
                }
            }
            else if (click == 'D')
            {
                Console.WriteLine("\nBiscuits Suppliers:");
                foreach (var supplier in suppliers[3])
                {
                    Console.WriteLine(supplier);
                }
            }
            else if (click == 'E')
            {
                Console.WriteLine("\nBeverages Suppliers:");
                foreach (var supplier in suppliers[4])
                {
                    Console.WriteLine(supplier);
                }
            }
            else
            {
                Console.WriteLine("Invalid Category!");
            }

        }

        static void deleteSupplierOption()
        {
            Console.WriteLine("\nDELETE OPTION:");
            Console.WriteLine("A. An element" + "\nB. All elements");
        }

        static void deleteElem()
        {
            string fullName;
            Console.Write("\nEnter Supplier's Full Name: ");
            fullName = Console.ReadLine();

            if (click == 'A')
            {
                suppliers[0].Remove(fullName);
                Console.WriteLine("\nDeleted Successfully!");
            }
            else if (click == 'B')
            {
                suppliers[1].Remove(fullName);
                Console.WriteLine("\nDeleted Successfully!");
            }
            else if (click == 'C')
            {
                suppliers[2].Remove(fullName);
                Console.WriteLine("\nDeleted Successfully!");
            }
            else if (click == 'D')
            {
                suppliers[3].Remove(fullName);
                Console.WriteLine("\nDeleted Successfully!");
            }
            else if (click == 'E')
            {
                suppliers[4].Remove(fullName);
                Console.WriteLine("\nDeleted Successfully!");
            }
        }
    }
}