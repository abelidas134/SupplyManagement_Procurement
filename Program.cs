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
        static char click, category, productCategory;
        static int productCount;
        static string id, choice, supplierName, isActiveChoice, productName;
        static bool activity;
        static double price;
        static supplyManagementJSONFile data = new supplyManagementJSONFile();
        static Business business = new Business();
        static SupplierDataL dataL = new SupplierDataL();

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
                            addSupplier(dataL);
                        }
                        else if (click == 'B')
                        {
                            Console.WriteLine("\nView List of Suppliers: ");
                            Console.WriteLine("\nA. By Category"+ "\nB. All Suppliers");
                            choiceLetter();

                            switch (click)
                            {
                                case 'A':
                                    viewSupplier(dataL);
                                    break;
                                case 'B':
                                    retrieveAllSuppliers();
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again!");
                                    break;
                            }
                        }
                        else if (click == 'C')
                        {
                            Console.WriteLine("\nUpdate a Supplier: ");
                            updateSuppliers(dataL);

                        }
                        else if (click == 'D')
                        {
                            Console.WriteLine("\nDelete a Supplier: ");
                            Console.WriteLine("\nDELETE OPTION:");
                            Console.WriteLine("A. Supplier" + "\nB. All suppliers");
                            choiceLetter();

                            switch (click)
                            {
                                case 'A':
                                    deleteSupplier(dataL);
                                    break;
                                case 'B':
                                    deleteAllSuppliers(dataL);
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again!");
                                    break;
                            }

                        }
                        break;
                    case 'C':
                        Console.WriteLine("\nPURCHASE:");
                        crudFeatures();
                        click = choiceLetter();

                        if (click == 'A')
                        {
                            Console.WriteLine("\nCreating/Adding Products: ");
                            addProduct(dataL); 
                        }
                        else if (click == 'B')
                        {
                            Console.WriteLine("\nView List of Products: ");
                            Console.WriteLine("\nA. By Category" + "\nB. All Products");
                            choiceLetter();

                            switch (click)
                            {
                                case 'A':
                                    viewProduct(dataL);
                                    break;
                                case 'B':
                                    viewAllProducts();
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again!");
                                    break;
                            }
                        }
                        else if (click == 'C')
                        {
                            Console.WriteLine("\nUpdate Products: ");
                            updateProduct(dataL);
                        }
                        else if (click == 'D')
                        {
                            Console.WriteLine("\nDelete a Product: ");
                            Console.WriteLine("\nDELETE OPTION:");
                            Console.WriteLine("A. Product" + "\nB. All products");
                            choiceLetter();

                            switch (click)
                            {
                                case 'A':
                                    deleteProduct(dataL);
                                    break;
                                case 'B':
                                    deleteAllProducts(dataL);
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again!");
                                    break;
                            }
                        }

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
        static void inputProducts()
        {
            Console.Write("\nProduct Name: ");
            productName = Console.ReadLine();
        }
        static void productPrice()
        {
            Console.Write("\nProduct Price: ");
            price = Double.Parse(Console.ReadLine());   
        }
        static void generateSuppliersID(SupplierDataL dataL)
        {
            id = "SP" + (dataL.RetrieveSuppliers().Count + 1);
        }
        static void generateProductsID(SupplierDataL dataL)
        {
            id = "PR0" + (dataL.RetrieveProducts().Count + 1);
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
        static void retrieveAllSuppliers()
        {
            var suppliersList = dataL.RetrieveSuppliers();
            foreach (var sl in suppliersList)
            {
                Console.WriteLine($"ID: {sl.supplierID} || Name: {sl.supplierName} || " +
                    $"Category: {sl.category} || Active: {sl.isActive} || Product Count: {sl.productCount}");
            }
        }
        static void addSupplier(SupplierDataL dataL)
        {
            generateSuppliersID(dataL); 
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

            dataL.AddSupplier(addSuppliers);

            Console.WriteLine("Supplier Added Successfully!");

        }
        static void viewSupplier(SupplierDataL dataL)
        {
            getCategory();
            var list = dataL.GetByCategory(category);

            if (list.Count == 0)
            {
                Console.WriteLine("There's no supplier in the inputted category.");
            }
            else
            {
                Console.WriteLine("SUPPLIERS' LIST:");
                foreach ( var item in list)
                {
                    Console.WriteLine($"SUPPLIERS ID: {item.supplierID} || SUPPLIER: {item.supplierName} || ACTIVE: {item.isActive} || PRODUCTS: {item.productCount}");
                }
            }

        }
        static void updateSuppliers(SupplierDataL dataL)
        {
            suppliersProducts();
            category = choiceLetter();
            var list = dataL.GetByCategory(category);
            foreach (var item in list)
            {
                Console.WriteLine("SUPPLIERS' LIST:");
                Console.WriteLine($"{item.supplierID} || {item.supplierName} || ACTIVE: {item.isActive} || PRODUCTS: {item.productCount}");
            }


            Console.Write("Enter Supplier's ID: ");
            id = Console.ReadLine();

            var supplier = dataL.RetrieveSuppliers().FirstOrDefault(s=> s.supplierID == id);
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

                dataL.UpdateSupplier(supplier);
                Console.WriteLine("Updated Successfully!");

            }
        }
        static void deleteSupplier(SupplierDataL dataL)
        {
            suppliersProducts();
            category = choiceLetter();
            var list = dataL.GetByCategory(category);
                foreach ( var item in list)
                {
                    Console.WriteLine("SUPPLIERS' LIST:");
                    Console.WriteLine($"{item.supplierID} || {item.supplierName} || ACTIVE: {item.isActive} || PRODUCTS: {item.productCount}");
                }


            Console.Write("Enter Supplier's ID: ");
            id = Console.ReadLine();
            if (dataL.RetrieveSuppliers().Any(s => s.supplierID == id))
            {
                dataL.DeleteSupplier(id);
                Console.WriteLine("Deleted Supplier!");
            }
            else
            {
                Console.WriteLine("Invalid Supplier's ID.");
            }


        }
        static void deleteAllSuppliers(SupplierDataL dataL)
        {
            suppliersProducts();
            category = choiceLetter();
            var list = dataL.GetByCategory(category);
            dataL.DeleteAll(category);
            Console.WriteLine("Deleted All Suppliers!");
        }
        static void addProduct(SupplierDataL dataL)
        {
            Console.Write("Enter Supplier ID to add product to: ");
            string supplierID = Console.ReadLine();
            var supplier = dataL.RetrieveSuppliers().FirstOrDefault(s => s.supplierID == supplierID);
            if (supplier == null)
            {
                Console.WriteLine("Supplier not found!");
                return;
            } 
            inputProducts();
            generateProductsID(dataL);
            productPrice();
            suppliersProducts();
            productCategory = choiceLetter();


            Product newProducts = new Product
            {
                productID = id,
                productName = productName,
                productCategory = productCategory,
                price = price
            };

            dataL.AddProducts(newProducts, supplierID);

            Console.WriteLine("Product Added Successfully!");           
        }
        static void viewAllProducts ()
        {
            var prods = dataL.RetrieveProducts();
            if (prods.Count==0)
            {
                Console.WriteLine("No products!");
                return;
            } 
            foreach (var sl in prods)
            {
                Console.WriteLine($"ID: {sl.productID} || Name: {sl.productName} || " +
                    $"Category: {sl.productCategory} || Price: {sl.price}");
            }
            
        }
        static void viewProduct(SupplierDataL dataL)
        {
            getCategory();
            var list = dataL.GetByCategoryProd(category);

            if (list.Count == 0)
            {
                Console.WriteLine("There's no product in the inputted category.");
            }
            else
            {
                Console.WriteLine("PRODUCTS' LIST:");
                foreach (var item in list)
                {
                    Console.WriteLine($"PRODUCTS ID: {item.productID} || PRODUCT NAME: {item.productName} || CATEGORY: {item.productCategory} || PRICE: {item.price}");
                }
            }

        }
        static void updateProduct(SupplierDataL dataL)
        {
            Console.Write("Enter Supplier ID: ");
            string supplierID = Console.ReadLine();

            Console.Write("Enter Product ID: ");
            string productID = Console.ReadLine();

            var supplier = dataL.RetrieveSuppliers().FirstOrDefault(s => s.supplierID == supplierID);

            if (supplier != null)
            {
                var product = supplier.products.Find(p => p.productID == productID);

                if (product != null)
                {
                    Console.Write("Options:\nA — Name\nB — Price\nC — Category");
                    category = choiceLetter();

                    switch (category)
                    {
                        case 'A':
                            Console.Write("Updated Name: ");
                            product.productName = Console.ReadLine();
                            break;

                        case 'B':
                            Console.Write("Updated Price: ");
                            product.price = Double.Parse(Console.ReadLine());
                            break;

                        case 'C':
                            Console.Write("Updated Category: ");
                            product.productCategory = choiceLetter();
                            break;

                        default:
                            Console.WriteLine("Invalid input.");
                            return;
                    }

                    dataL.UpdateProducts(product, supplierID, productID);
                    Console.WriteLine("Updated Successfully!");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
            else
            {
                Console.WriteLine("Supplier not found.");
            }
        }
        static void deleteAllProducts(SupplierDataL dataL)
        {
            suppliersProducts();
            category = choiceLetter();
            dataL.DeleteAllProducts(category);
            Console.WriteLine("Deleted All Products!");
        }
        static void deleteProduct(SupplierDataL dataL)
        {
            Console.Write("Enter Supplier ID: ");
            string supplierID = Console.ReadLine();

            var supplier = dataL.RetrieveSuppliers().FirstOrDefault(s => s.supplierID == supplierID);
            if (supplier == null)
            {
                Console.WriteLine("No supplier!");
                return;
            }

            Console.Write("Enter Product ID: ");
            string productID = Console.ReadLine();
            var product = supplier.products.FirstOrDefault(p => p.productID == productID);
            if (product == null)
            {
                Console.WriteLine("No product/s in this supplier!");
                return;
            }
            dataL.DeleteProduct(supplierID, productID);
            Console.WriteLine("Product deleted!");

        }
    }
}