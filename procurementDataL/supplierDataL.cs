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
            suppliersDB.Add(new Supplier { supplierID = "SP1", supplierName = "Century Pacific Food, Inc.", isActive = true, productCount = 10, category ='A' });
            suppliersDB.Add(new Supplier { supplierID = "SP2", supplierName = "Mega Prime Foods Inc.", isActive = true, productCount = 10, category = 'A' });
            suppliersDB.Add(new Supplier { supplierID = "SP3", supplierName = "CDO Foodsphere, Inc.", isActive = true, productCount = 10, category = 'A' });
            suppliersDB.Add(new Supplier { supplierID = "SP4", supplierName = "San Miguel Foods Inc.", isActive = true, productCount = 10, category = 'A' });
            suppliersDB.Add(new Supplier { supplierID = "SP5", supplierName = "Delimondo Food Specialties Inc.", isActive = true, productCount = 10 , category = 'A' });

            suppliersDB.Add(new Supplier { supplierID = "SP6", supplierName = "Unilab, Inc.", isActive = true, productCount = 10, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP7", supplierName = "Splash Corporation", isActive = true, productCount = 10, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP8", supplierName = "Peerless Products Manufacturing Corporation", isActive = true, productCount = 10, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP9", supplierName = "Gandang Kalikasan Inc. (Human Nature)", isActive = true, productCount = 10, category = 'B' });
            suppliersDB.Add(new Supplier { supplierID = "SP10", supplierName = "Procter & Gamble Philippines", isActive = true, productCount = 10, category = 'B' });

            suppliersDB.Add(new Supplier { supplierID = "SP11", supplierName = "Monde Nissin Corporation", isActive = true, productCount = 10, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP12", supplierName = "Universal Robina Corporation", isActive = true, productCount = 10, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP13", supplierName = "Nissin Foods Philippines", isActive = true, productCount = 10, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP14", supplierName = "San Miguel Foods Inc.", isActive = true, productCount = 10, category = 'C' });
            suppliersDB.Add(new Supplier { supplierID = "SP15", supplierName = "Century Pacific Foods, Inc.", isActive = true, productCount = 10, category = 'C' });

            suppliersDB.Add(new Supplier { supplierID = "SP16", supplierName = "Rebisco", isActive = true, productCount = 10, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP17", supplierName = "Universal Robina Corporation", isActive = true, productCount = 10, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP18", supplierName = "Liwayway Marketing Corporation (Oishi)", isActive = true, productCount = 10, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP19", supplierName = "JBC Food Corporation", isActive = true, productCount = 10, category = 'D' });
            suppliersDB.Add(new Supplier { supplierID = "SP20", supplierName = "Jack 'n Jill (URC Brand)", isActive = true, productCount = 10, category = 'D' });

            suppliersDB.Add(new Supplier { supplierID = "SP21", supplierName = "Coca-Cola Beverages Philippines", isActive = true, productCount = 10, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP22", supplierName = "Pepsi-Cola Products Philippines, Inc.", isActive = true, productCount = 10, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP23", supplierName = "ABC Refreshments Corporation", isActive = true, productCount = 10, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP24", supplierName = "Asia Bravery, Inc.", isActive = true, productCount = 10, category = 'E' });
            suppliersDB.Add(new Supplier { supplierID = "SP25", supplierName = "San Miguel Corporation", isActive = true, productCount = 10, category = 'E' });

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
        public void DeleteSupplier(string id) {
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
        
    }
}