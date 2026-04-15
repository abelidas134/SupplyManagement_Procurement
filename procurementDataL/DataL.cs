using procurementModels;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace procurementDataL
{
    public class SupplierDataL
    {
        public List<Supplier> suppliersDB = new List<Supplier>();

        public SupplierDataL()
        {
            suppliersDB.Add(new Supplier { supplierID = "SP1", supplierName = "Century Pacific Food, Inc.", isActive = true, productCount = 6, category = 'A' });
            suppliersDB.Add(new Supplier { supplierID = "SP2", supplierName = "Mega Prime Foods Inc.", isActive = true, productCount = 6, category = 'A' });
            suppliersDB.Add(new Supplier { supplierID = "SP3", supplierName = "CDO Foodsphere, Inc.", isActive = true, productCount = 6, category = 'A' });
            suppliersDB.Add(new Supplier { supplierID = "SP4", supplierName = "San Miguel Foods Inc.", isActive = true, productCount = 6, category = 'A' });
            suppliersDB.Add(new Supplier { supplierID = "SP5", supplierName = "Delimondo Food Specialties Inc.", isActive = true, productCount = 6, category = 'A' });

            suppliersDB.Add(new Supplier { supplierID = "SP6", supplierName = "Unilab, Inc.", isActive = true, productCount = 6, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP7", supplierName = "Splash Corporation", isActive = true, productCount = 6, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP8", supplierName = "Peerless Products Manufacturing Corporation", isActive = true, productCount = 6, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP9", supplierName = "Gandang Kalikasan Inc. (Human Nature)", isActive = true, productCount = 6, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP10", supplierName = "Procter & Gamble Philippines", isActive = true, productCount = 6, category = 'B' });

            suppliersDB.Add(new Supplier { supplierID = "SP11", supplierName = "Monde Nissin Corporation", isActive = true, productCount = 6, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP12", supplierName = "Universal Robina Corporation", isActive = true, productCount = 6, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP13", supplierName = "Nissin Foods Philippines", isActive = true, productCount = 6, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP14", supplierName = "San Miguel Foods Inc.", isActive = true, productCount = 6, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP15", supplierName = "Century Pacific Foods, Inc.", isActive = true, productCount = 6, category = 'C' });

            suppliersDB.Add(new Supplier { supplierID = "SP16", supplierName = "Rebisco", isActive = true, productCount = 6, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP17", supplierName = "Universal Robina Corporation", isActive = true, productCount = 6, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP18", supplierName = "Liwayway Marketing Corporation (Oishi)", isActive = true, productCount = 6, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP19", supplierName = "JBC Food Corporation", isActive = true, productCount = 6, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP20", supplierName = "Jack 'n Jill (URC Brand)", isActive = true, productCount = 6, category = 'D' });

            suppliersDB.Add(new Supplier { supplierID = "SP21", supplierName = "Coca-Cola Beverages Philippines", isActive = true, productCount = 6, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP22", supplierName = "Pepsi-Cola Products Philippines, Inc.", isActive = true, productCount = 6, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP23", supplierName = "ABC Refreshments Corporation", isActive = true, productCount = 6, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP24", supplierName = "Asia Bravery, Inc.", isActive = true, productCount = 6, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP25", supplierName = "San Miguel Corporation", isActive = true, productCount = 6, category = 'E' });

            SuppliersProduct();
        }

        public void AddSupplier(Supplier s)
        {
            suppliersDB.Add(s);
        }
        public void UpdateSupplier(Supplier s)
        {
            var existing = suppliersDB.Find(x => x.supplierID == s.supplierID);
            if (existing != null)
            {
                existing.supplierName = s.supplierName;
                existing.isActive = s.isActive;
                existing.productCount = s.productCount;
                existing.category = s.category;
            }
        }
        public void DeleteSupplier(string id)
        {
            suppliersDB.RemoveAll(x => x.supplierID == id);
        }

        public void DeleteAll(char category)
        {
            suppliersDB.RemoveAll(s => s.category == category);
        }
        public List<Supplier> RetrieveSuppliers()
        {
            return suppliersDB.ToList();
        }

        public List<Supplier> GetByCategory(char category)
        {
            return suppliersDB.Where(s => s.category == category).ToList();
        }

        public void SuppliersProduct()
        {
            var sp1 = suppliersDB.Find(s => s.supplierID == "SP1");
            if (sp1 != null)
            {
                sp1.products.Add(new Product { productID = "PR01", productName = "Tuna", productCategory = 'A', price = 20 });
                sp1.products.Add(new Product { productID = "PR02", productName = "Sardines", productCategory = 'A', price = 21 });
                sp1.products.Add(new Product { productID = "PR03", productName = "Meat Loaf", productCategory = 'A', price = 22 });
                sp1.products.Add(new Product { productID = "PR04", productName = "Corned Beef", productCategory = 'A', price = 23 });
                sp1.products.Add(new Product { productID = "PR05", productName = "Chicken Spread", productCategory = 'A', price = 24 });
                sp1.products.Add(new Product { productID = "PR06", productName = "Flakes", productCategory = 'A', price = 25 });
            }

            var sp2 = suppliersDB.Find(s => s.supplierID == "SP2");
            if (sp2 != null)
            {
                sp2.products.Add(new Product { productID = "PR07", productName = "Mushroom", productCategory = 'A', price = 20 });
                sp2.products.Add(new Product { productID = "PR08", productName = "Whole Corn", productCategory = 'A', price = 21 });
                sp2.products.Add(new Product { productID = "PR09", productName = "Green Peas", productCategory = 'A', price = 22 });
                sp2.products.Add(new Product { productID = "PR010", productName = "Fruit Cocktail", productCategory = 'A', price = 23 });
                sp2.products.Add(new Product { productID = "PR011", productName = "Pineapple Tidbits", productCategory = 'A', price = 24 });
                sp2.products.Add(new Product { productID = "PR012", productName = "Tuna Chunks", productCategory = 'A', price = 25 });
            }

            var sp3 = suppliersDB.Find(s => s.supplierID == "SP3");
            if (sp3 != null)
            {
                sp3.products.Add(new Product { productID = "PR013", productName = "Hotdog", productCategory = 'A', price = 20 });
                sp3.products.Add(new Product { productID = "PR014", productName = "Corned Beef", productCategory = 'A', price = 21 });
                sp3.products.Add(new Product { productID = "PR015", productName = "Beef Tapa", productCategory = 'A', price = 22 });
                sp3.products.Add(new Product { productID = "PR016", productName = "Tocino", productCategory = 'A', price = 23 });
                sp3.products.Add(new Product { productID = "PR017", productName = "Longganisa", productCategory = 'A', price = 24 });
                sp3.products.Add(new Product { productID = "PR018", productName = "Ham", productCategory = 'A', price = 25 });
            }

            var sp4 = suppliersDB.Find(s => s.supplierID == "SP4");
            if (sp4 != null)
            {
                sp4.products.Add(new Product { productID = "PR019", productName = "Hotdog", productCategory = 'A', price = 20 });
                sp4.products.Add(new Product { productID = "PR020", productName = "Corned Beef", productCategory = 'A', price = 21 });
                sp4.products.Add(new Product { productID = "PR021", productName = "Chicken Nuggets", productCategory = 'A', price = 22 });
                sp4.products.Add(new Product { productID = "PR022", productName = "Bacon", productCategory = 'A', price = 23 });
                sp4.products.Add(new Product { productID = "PR023", productName = "Ham", productCategory = 'A', price = 24 });
                sp4.products.Add(new Product { productID = "PR024", productName = "Tocino", productCategory = 'A', price = 25 });
            }

            var sp5 = suppliersDB.Find(s => s.supplierID == "SP5");
            if (sp5 != null)
            {
                sp5.products.Add(new Product { productID = "PR025", productName = "Corned Beef Classic", productCategory = 'A', price = 20 });
                sp5.products.Add(new Product { productID = "PR026", productName = "Garlic Corned Beef", productCategory = 'A', price = 21 });
                sp5.products.Add(new Product { productID = "PR027", productName = "Chili Corned Beef", productCategory = 'A', price = 22 });
                sp5.products.Add(new Product { productID = "PR028", productName = "Racnh Corned Beef", productCategory = 'A', price = 23 });
                sp5.products.Add(new Product { productID = "PR029", productName = "Caldereta", productCategory = 'A', price = 24 });
                sp5.products.Add(new Product { productID = "PR030", productName = "Mechado", productCategory = 'A', price = 25 });
            }

            var sp6 = suppliersDB.Find(s => s.supplierID == "SP6");
            if (sp6 != null)
            {
                sp6.products.Add(new Product { productID = "PR031", productName = "Paracetamol", productCategory = 'B', price = 20 });
                sp6.products.Add(new Product { productID = "PR032", productName = "Vitamin C", productCategory = 'B', price = 21 });
                sp6.products.Add(new Product { productID = "PR033", productName = "Multivitamins", productCategory = 'B', price = 22 });
                sp6.products.Add(new Product { productID = "PR034", productName = "Cough Syrup", productCategory = 'B', price = 23 });
                sp6.products.Add(new Product { productID = "PR035", productName = "Antacid", productCategory = 'B', price = 24 });
                sp6.products.Add(new Product { productID = "PR036", productName = "Allergy Medicine", productCategory = 'B', price = 25 });
            }

            var sp7 = suppliersDB.Find(s => s.supplierID == "SP7");
            if (sp7 != null)
            {
                sp7.products.Add(new Product { productID = "PR037", productName = "Shampoo", productCategory = 'B', price = 20 });
                sp7.products.Add(new Product { productID = "PR038", productName = "Conditioner", productCategory = 'B', price = 21 });
                sp7.products.Add(new Product { productID = "PR039", productName = "Body Wash", productCategory = 'B', price = 22 });
                sp7.products.Add(new Product { productID = "PR040", productName = "Facial Cleanser", productCategory = 'B', price = 23 });
                sp7.products.Add(new Product { productID = "PR041", productName = "Lotion", productCategory = 'B', price = 24 });
                sp7.products.Add(new Product { productID = "PR042", productName = "Cologne", productCategory = 'B', price = 25 });
            }

            var sp8 = suppliersDB.Find(s => s.supplierID == "SP8");
            if (sp8 != null)
            {
                sp8.products.Add(new Product { productID = "PR043", productName = "Laundry Detergent", productCategory = 'B', price = 20 });
                sp8.products.Add(new Product { productID = "PR044", productName = "Fabric Conditioner", productCategory = 'B', price = 21 });
                sp8.products.Add(new Product { productID = "PR045", productName = "Dishwashing Liquid", productCategory = 'B', price = 22 });
                sp8.products.Add(new Product { productID = "PR046", productName = "Bath Soap", productCategory = 'B', price = 23 });
                sp8.products.Add(new Product { productID = "PR047", productName = "Bleach", productCategory = 'B', price = 24 });
                sp8.products.Add(new Product { productID = "PR048", productName = "Toilet Cleaner", productCategory = 'B', price = 25 });
            }

            var sp9 = suppliersDB.Find(s => s.supplierID == "SP9");
            if (sp9 != null)
            {
                sp9.products.Add(new Product { productID = "PR049", productName = "Natural Shampoo", productCategory = 'B', price = 20 });
                sp9.products.Add(new Product { productID = "PR050", productName = "Conditioner", productCategory = 'B', price = 21 });
                sp9.products.Add(new Product { productID = "PR051", productName = "Body Wash", productCategory = 'B', price = 22 });
                sp9.products.Add(new Product { productID = "PR052", productName = "Facial Wash", productCategory = 'B', price = 23 });
                sp9.products.Add(new Product { productID = "PR053", productName = "Lotion", productCategory = 'B', price = 24 });
                sp9.products.Add(new Product { productID = "PR054", productName = "Lip Balm", productCategory = 'B', price = 25 });
            }

            var sp10 = suppliersDB.Find(s => s.supplierID == "SP10");
            if (sp10 != null)
            {
                sp10.products.Add(new Product { productID = "PR055", productName = "Shampoo", productCategory = 'B', price = 20 });
                sp10.products.Add(new Product { productID = "PR056", productName = "Conditioner", productCategory = 'B', price = 21 });
                sp10.products.Add(new Product { productID = "PR057", productName = "Laundry Detergent", productCategory = 'B', price = 22 });
                sp10.products.Add(new Product { productID = "PR058", productName = "Toothpaste", productCategory = 'B', price = 23 });
                sp10.products.Add(new Product { productID = "PR059", productName = "Diapers", productCategory = 'B', price = 24 });
                sp10.products.Add(new Product { productID = "PR060", productName = "Body Wash", productCategory = 'B', price = 25 });
            }

            var sp11 = suppliersDB.Find(s => s.supplierID == "SP11");
            if (sp11 != null)
            {
                sp11.products.Add(new Product { productID = "PR061", productName = "Instant Noodles", productCategory = 'C', price = 20 });
                sp11.products.Add(new Product { productID = "PR062", productName = "Cup Noodles", productCategory = 'C', price = 21 });
                sp11.products.Add(new Product { productID = "PR063", productName = "Pancit Canton", productCategory = 'C', price = 22 });
                sp11.products.Add(new Product { productID = "PR064", productName = "Biscuits", productCategory = 'C', price = 23 });
                sp11.products.Add(new Product { productID = "PR065", productName = "Crackers", productCategory = 'C', price = 24 });
                sp11.products.Add(new Product { productID = "PR066", productName = "Wafer Rolls", productCategory = 'C', price = 25 });
            }

            var sp12 = suppliersDB.Find(s => s.supplierID == "SP12");
            if (sp12 != null)
            {
                sp12.products.Add(new Product { productID = "PR067", productName = "Instant Noodles", productCategory = 'C', price = 20 });
                sp12.products.Add(new Product { productID = "PR068", productName = "Cup Noodles", productCategory = 'C', price = 21 });
                sp12.products.Add(new Product { productID = "PR069", productName = "Pancit Canton", productCategory = 'C', price = 22 });
                sp12.products.Add(new Product { productID = "PR070", productName = "Crackers", productCategory = 'C', price = 23 });
                sp12.products.Add(new Product { productID = "PR071", productName = "Biscuits", productCategory = 'C', price = 24 });
                sp12.products.Add(new Product { productID = "PR072", productName = "Wafer Rolls", productCategory = 'C', price = 25 });
            }

            var sp13 = suppliersDB.Find(s => s.supplierID == "SP13");
            if (sp13 != null)
            {
                sp13.products.Add(new Product { productID = "PR073", productName = "Cup Noodles", productCategory = 'C', price = 20 });
                sp13.products.Add(new Product { productID = "PR074", productName = "Instant Ramen", productCategory = 'C', price = 21 });
                sp13.products.Add(new Product { productID = "PR075", productName = "Seafood Noodles", productCategory = 'C', price = 22 });
                sp13.products.Add(new Product { productID = "PR076", productName = "Chicken Noodles", productCategory = 'C', price = 23 });
                sp13.products.Add(new Product { productID = "PR077", productName = "Beef Noodles", productCategory = 'C', price = 24 });
                sp13.products.Add(new Product { productID = "PR078", productName = "Spicy Noodles", productCategory = 'C', price = 25 });
            }

            var sp14 = suppliersDB.Find(s => s.supplierID == "SP14");
            if (sp14 != null)
            {
                sp14.products.Add(new Product { productID = "PR079", productName = "Flour", productCategory = 'C', price = 20 });
                sp14.products.Add(new Product { productID = "PR080", productName = "Bread Mix", productCategory = 'C', price = 21 });
                sp14.products.Add(new Product { productID = "PR081", productName = "Cake Mix", productCategory = 'C', price = 22 });
                sp14.products.Add(new Product { productID = "PR082", productName = "Pancake Mix", productCategory = 'C', price = 23 });
                sp14.products.Add(new Product { productID = "PR083", productName = "Pasta", productCategory = 'C', price = 24 });
                sp14.products.Add(new Product { productID = "PR084", productName = "Spaghetti Sauce", productCategory = 'C', price = 25 });
            }

            var sp15 = suppliersDB.Find(s => s.supplierID == "SP15");
            if (sp15 != null)
            {
                sp15.products.Add(new Product { productID = "PR085", productName = "Instant Tuna Meals", productCategory = 'C', price = 20 });
                sp15.products.Add(new Product { productID = "PR086", productName = "Tuna Flakes", productCategory = 'C', price = 21 });
                sp15.products.Add(new Product { productID = "PR087", productName = "Sardines", productCategory = 'C', price = 22 });
                sp15.products.Add(new Product { productID = "PR088", productName = "Canned Chicken", productCategory = 'C', price = 23 });
                sp15.products.Add(new Product { productID = "PR089", productName = "Meat Loaf", productCategory = 'C', price = 24 });
                sp15.products.Add(new Product { productID = "PR090", productName = "Pasta Sauce", productCategory = 'C', price = 25 });
            }

            var sp16 = suppliersDB.Find(s => s.supplierID == "SP16");
            if (sp16 != null)
            {
                sp16.products.Add(new Product { productID = "PR091", productName = "Crackers", productCategory = 'D', price = 20 });
                sp16.products.Add(new Product { productID = "PR092", productName = "Sandwich Crackers", productCategory = 'D', price = 21 });
                sp16.products.Add(new Product { productID = "PR093", productName = "Biscuits", productCategory = 'D', price = 22 });
                sp16.products.Add(new Product { productID = "PR094", productName = "Wafers", productCategory = 'D', price = 23 });
                sp16.products.Add(new Product { productID = "PR095", productName = "Chocolate Wafers", productCategory = 'D', price = 24 });
                sp16.products.Add(new Product { productID = "PR096", productName = "Cream Biscuits", productCategory = 'D', price = 25 });
            }

            var sp17 = suppliersDB.Find(s => s.supplierID == "SP17");
            if (sp17 != null)
            {
                sp17.products.Add(new Product { productID = "PR097", productName = "Potato Chips", productCategory = 'D', price = 20 });
                sp17.products.Add(new Product { productID = "PR098", productName = "Corn Chips", productCategory = 'D', price = 21 });
                sp17.products.Add(new Product { productID = "PR099", productName = "Cheese Balls", productCategory = 'D', price = 22 });
                sp17.products.Add(new Product { productID = "PR100", productName = "Chocolate Bars", productCategory = 'D', price = 23 });
                sp17.products.Add(new Product { productID = "PR101", productName = "Candies", productCategory = 'D', price = 24 });
                sp17.products.Add(new Product { productID = "PR102", productName = "Gummies", productCategory = 'D', price = 25 });
            }

            var sp18 = suppliersDB.Find(s => s.supplierID == "SP18");
            if (sp18 != null)
            {
                sp18.products.Add(new Product { productID = "PR103", productName = "Prawn Crackers", productCategory = 'D', price = 20 });
                sp18.products.Add(new Product { productID = "PR104", productName = "Potato Chips", productCategory = 'D', price = 21 });
                sp18.products.Add(new Product { productID = "PR105", productName = "Cheese Rings", productCategory = 'D', price = 22 });
                sp18.products.Add(new Product { productID = "PR106", productName = "Bread Pan Snacks", productCategory = 'D', price = 23 });
                sp18.products.Add(new Product { productID = "PR107", productName = "Sponge Crunch", productCategory = 'D', price = 24 });
                sp18.products.Add(new Product { productID = "PR108", productName = "Wafer Rolls", productCategory = 'D', price = 25 });
            }

            var sp19 = suppliersDB.Find(s => s.supplierID == "SP19");
            if (sp19 != null)
            {
                sp19.products.Add(new Product { productID = "PR109", productName = "Potato Chips", productCategory = 'D', price = 20 });
                sp19.products.Add(new Product { productID = "PR110", productName = "Corn Snacks", productCategory = 'D', price = 21 });
                sp19.products.Add(new Product { productID = "PR111", productName = "Crackers", productCategory = 'D', price = 22 });
                sp19.products.Add(new Product { productID = "PR112", productName = "Biscuits", productCategory = 'D', price = 23 });
                sp19.products.Add(new Product { productID = "PR113", productName = "Chocolate Snacks", productCategory = 'D', price = 24 });
                sp19.products.Add(new Product { productID = "PR114", productName = "Wafer Bars", productCategory = 'D', price = 25 });
            }

            var sp20 = suppliersDB.Find(s => s.supplierID == "SP20");
            if (sp20 != null)
            {
                sp20.products.Add(new Product { productID = "PR115", productName = "Piattos", productCategory = 'D', price = 20 });
                sp20.products.Add(new Product { productID = "PR116", productName = "Nova", productCategory = 'D', price = 21 });
                sp20.products.Add(new Product { productID = "PR117", productName = "VCut", productCategory = 'D', price = 22 });
                sp20.products.Add(new Product { productID = "PR118", productName = "Chippy", productCategory = 'D', price = 23 });
                sp20.products.Add(new Product { productID = "PR119", productName = "Pretzels", productCategory = 'D', price = 24 });
                sp20.products.Add(new Product { productID = "PR120", productName = "Cookies", productCategory = 'D', price = 25 });
            }

            var sp21 = suppliersDB.Find(s => s.supplierID == "SP21");
            if (sp21 != null)
            {
                sp21.products.Add(new Product { productID = "PR121", productName = "Coca-Cola", productCategory = 'E', price = 20 });
                sp21.products.Add(new Product { productID = "PR122", productName = "Coke Zero", productCategory = 'E', price = 21 });
                sp21.products.Add(new Product { productID = "PR123", productName = "Sprite", productCategory = 'E', price = 22 });
                sp21.products.Add(new Product { productID = "PR124", productName = "Royal", productCategory = 'E', price = 23 });
                sp21.products.Add(new Product { productID = "PR125", productName = "Minute Maid Juice", productCategory = 'E', price = 24 });
                sp21.products.Add(new Product { productID = "PR126", productName = "Iced Tea", productCategory = 'E', price = 25 });
            }

            var sp22 = suppliersDB.Find(s => s.supplierID == "SP22");
            if (sp22 != null)
            {
                sp22.products.Add(new Product { productID = "PR127", productName = "Pepsi", productCategory = 'E', price = 20 });
                sp22.products.Add(new Product { productID = "PR128", productName = "Pepsi Zero", productCategory = 'E', price = 21 });
                sp22.products.Add(new Product { productID = "PR129", productName = "Mountain Dew", productCategory = 'E', price = 22 });
                sp22.products.Add(new Product { productID = "PR130", productName = "7UP", productCategory = 'E', price = 23 });
                sp22.products.Add(new Product { productID = "PR131", productName = "Mirinda", productCategory = 'E', price = 24 });
                sp22.products.Add(new Product { productID = "PR132", productName = "Iced Tea", productCategory = 'E', price = 25 });
            }

            var sp23 = suppliersDB.Find(s => s.supplierID == "SP23");
            if (sp23 != null)
            {
                sp23.products.Add(new Product { productID = "PR133", productName = "Orange Juice", productCategory = 'E', price = 20 });
                sp23.products.Add(new Product { productID = "PR134", productName = "Apple Juice", productCategory = 'E', price = 21 });
                sp23.products.Add(new Product { productID = "PR135", productName = "Grape Juice", productCategory = 'E', price = 22 });
                sp23.products.Add(new Product { productID = "PR136", productName = "Iced Tea", productCategory = 'E', price = 23 });
                sp23.products.Add(new Product { productID = "PR137", productName = "Lemonade", productCategory = 'E', price = 24 });
                sp23.products.Add(new Product { productID = "PR138", productName = "Bottled Water", productCategory = 'E', price = 25 });
            }

            var sp24 = suppliersDB.Find(s => s.supplierID == "SP24");
            if (sp24 != null)
            {
                sp24.products.Add(new Product { productID = "PR139", productName = "Bottled Water", productCategory = 'E', price = 20 });
                sp24.products.Add(new Product { productID = "PR140", productName = "Flavored Water", productCategory = 'E', price = 21 });
                sp24.products.Add(new Product { productID = "PR141", productName = "Energy Drink", productCategory = 'E', price = 22 });
                sp24.products.Add(new Product { productID = "PR142", productName = "Iced Tea", productCategory = 'E', price = 23 });
                sp24.products.Add(new Product { productID = "PR143", productName = "Juice Drink", productCategory = 'E', price = 24 });
                sp24.products.Add(new Product { productID = "PR144", productName = "Coffee Drink", productCategory = 'E', price = 25 });
            }

            var sp25 = suppliersDB.Find(s => s.supplierID == "SP25");
            if (sp25 != null)
            {
                sp25.products.Add(new Product { productID = "PR145", productName = "Beer", productCategory = 'E', price = 20 });
                sp25.products.Add(new Product { productID = "PR146", productName = "Flavored Beer", productCategory = 'E', price = 21 });
                sp25.products.Add(new Product { productID = "PR147", productName = "Iced Tea", productCategory = 'E', price = 22 });
                sp25.products.Add(new Product { productID = "PR148", productName = "Juice Drink", productCategory = 'E', price = 23 });
                sp25.products.Add(new Product { productID = "PR149", productName = "Bottled Water", productCategory = 'E', price = 24 });
                sp25.products.Add(new Product { productID = "PR150", productName = "Energy Drink", productCategory = 'E', price = 25 });
            }
        }

        public void AddProducts(Product p, string id)
        {
            var supplier = suppliersDB.Find(s=>s.supplierID == id);
            if (supplier != null)
            {
                supplier.products.Add(p);
            }
        }

        public void UpdateProducts(Product p, string id)
        {
            var existingSupplier = suppliersDB.Find(x => x.supplierID == id);
            if (existingSupplier != null)
            {
                var existingProduct = existingSupplier.products.Find(p => p.productID == id);
                if (existingProduct != null)
                {
                    existingProduct.productName = p.productName;
                    existingProduct.productCategory = p.productCategory;
                    existingProduct.price = p.price;
                }
            }
        }

        public void DeleteProduct(string supplierID, string productID)
        {
            var existingSupplier = suppliersDB.Find (s=>s.supplierID== supplierID);
            if (existingSupplier != null)
            {
                existingSupplier.products.RemoveAll(p => p.productID == productID);
            }
        }

        public void DeleteAllProducts(char category)
        {
            var existingSupplier = suppliersDB.Find(s => s.category == category);
            if (existingSupplier != null)
            {
                existingSupplier.products.RemoveAll(p => p.productCategory == category);
            }
        }

        public List<Product> RetrieveProducts()
        {
            return suppliersDB.SelectMany(p=>p.products).ToList();
        }

        public List<Product> GetByCategoryProd(char category)
        {
            return suppliersDB.Where(s => s.category == category).SelectMany(p=>p.products).ToList();
        }

    }

}