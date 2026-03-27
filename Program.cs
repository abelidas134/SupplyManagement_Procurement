using procurementBusinessL;
using procurementDataL;
using procurementModels;
using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SupplyManagement_Procurement
{
    internal class Program
    {
        static char click, category;
        static int productCount;
        static string id, choice, supplierName, isActiveChoice;
        static bool activity;
        static supplyManagementJSONFile data = new supplyManagementJSONFile();
        static Business business = new Business();

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
                            addSupplier(data);
                        }
                        else if (click == 'B')
                        {
                            Console.WriteLine("\nView List of Suppliers: ");
                            viewSupplier(data);
                        }
                        else if (click == 'C')
                        {
                            Console.WriteLine("\nUpdate a Supplier: ");
                            updateSuppliers(data);

                        }
                        else if (click == 'D')
                        {
                            Console.WriteLine("\nDelete a Supplier: ");
                            Console.WriteLine("\nDELETE OPTION:");
                            Console.WriteLine("A. An element" + "\nB. All elements");
                            choiceLetter();

                            switch (click)
                            {
                                case 'A':
                                    deleteElem(data);
                                    break;
                                case 'B':
                                    deleteAll(data);
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again!");
                                    break;
                            }

                        }
                        break;
                    case 'C':
                        //Purchase
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
            while (true)
            {
                Console.Write("\nEnter: ");
                choice = Console.ReadLine().Trim();
                if (choice != null)
                {
                    click = char.ToUpper(choice[0]);
                    return click;
                } else
                {
                    Console.WriteLine("Invalid choice. Please try again!");
                }
            }
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

       

        static void inputSuppliers()
        {
            Console.Write("\nEnter Supplier's Name: ");
            supplierName = Console.ReadLine();
        }

        static void generateSuppliersID(supplyManagementJSONFile data)
        {
            id = "SP" + (data.RetrieveSuppliers().Count + 1);
        }

        static void isActive()
        {
            Console.Write("Active/Inactive: ");
            isActiveChoice = Console.ReadLine().ToUpper();

            if (isActiveChoice != null)
            {
                switch(isActiveChoice)
                {
                    case "ACTIVE": activity = true; break;
                    case "INACTIVE":  activity = false; break;

                }
            } else
            {
                Console.WriteLine("Invalid input. Please try again!");
            }

        }

        static void prodCount(Business business)
        {
            Console.Write("Number of Products' Available (Must be a min. of 5): ");
            productCount = int.Parse(Console.ReadLine());

            if (!business.CanAddSupplier(productCount))
            { 
                Console.WriteLine("Products Availability is less than the requirement.");
            }
        }

        static void getCategory()
        {
            suppliersProducts();
            category = choiceLetter();
            
        }

        static void addSupplier(supplyManagementJSONFile data)
        {
            generateSuppliersID(data); 
            inputSuppliers();
            isActive();
            prodCount(business);
            getCategory();

            Supplier addSuppliers = new Supplier
            {
                supplierID = id,
                supplierName = supplierName,
                isActive = activity,
                productCount = productCount,
                category = category
            };

            data.AddSupplier(addSuppliers);

            Console.WriteLine("Supplier Added Successfully!");

        }

        static void viewSupplier(supplyManagementJSONFile data)
        {
            getCategory();
            var list = data.GetByCategory(category);

            if (list.Count == 0)
            {
                Console.WriteLine("There's no supplier in the inputted category.");
            }
            else
            {
                foreach ( var item in list)
                {
                    Console.WriteLine("SUPPLIERS' LIST:");
                    Console.WriteLine($"{item.supplierID} || {item.supplierName} || ACTIVE: {item.isActive} || PRODUCTS: {item.productCount}");
                }
            }

        }


        static void updateSuppliers(supplyManagementJSONFile data)
        {
            suppliersProducts();
            category = choiceLetter();
            var list = data.GetByCategory(category);
            foreach (var item in list)
            {
                Console.WriteLine("SUPPLIERS' LIST:");
                Console.WriteLine($"{item.supplierID} || {item.supplierName} || ACTIVE: {item.isActive} || PRODUCTS: {item.productCount}");
            }


            Console.Write("Enter Supplier's ID: ");
            id = Console.ReadLine();

            var supplier = data.RetrieveSuppliers().FirstOrDefault(s=> s.supplierID == id);
            if (supplier != null)
            {
                Console.Write("Options:" + "\nA — Name" + "\n B — Active" + "\nC — Products" + "\nD — Category");
                category = choiceLetter();

                switch (category)
                {
                    case 'A':
                        Console.Write("Updated Name: ");
                        supplierName = Console.ReadLine();
                        supplier.supplierName = supplierName;

                        break;

                    case 'B':
                        Console.Write("Updated ");
                        isActive();
                        supplier.isActive = activity;

                        break;

                    case 'C':
                        Console.Write("Updated ");
                        prodCount(business);
                        supplier.productCount = productCount;
                        break;

                    case 'D':
                        Console.Write("Updated ");
                        getCategory();
                        supplier.category = category;
                        break;
                    
                    default:
                        Console.WriteLine("Invalid input. Please try again!");
                        break;
                }

                data.UpdateSupplier(supplier);
                Console.WriteLine("Updated Successfully!");

            }
        }

        static void deleteElem(supplyManagementJSONFile data)
        {
            suppliersProducts();
            category = choiceLetter();
            var list = data.GetByCategory(category);
                foreach ( var item in list)
                {
                    Console.WriteLine("SUPPLIERS' LIST:");
                    Console.WriteLine($"{item.supplierID} || {item.supplierName} || ACTIVE: {item.isActive} || PRODUCTS: {item.productCount}");
                }


            Console.Write("Enter Supplier's ID: ");
            id = Console.ReadLine();
            if (data.RetrieveSuppliers().Any(s => s.supplierID == id))
            {
                data.DeleteSupplier(id);
                Console.WriteLine("Deleted Supplier!");
            }
            else
            {
                Console.WriteLine("Invalid Supplier's ID.");
            }


        }

        static void deleteAll(supplyManagementJSONFile data)
        {
            suppliersProducts();
            category = choiceLetter();
            var list = data.GetByCategory(category);
            data.DeleteAll(category);
            Console.WriteLine("Deleted All Suppliers!");
        }
    }
}