using System.Collections.Generic;
using procurementModels;

namespace procurementDataL
{
    public class SupplierDataL
    {
        public List<Supplier> suppliersDB = new List<Supplier>();

        public SupplierDataL()
        {
            suppliersDB.Add(new Supplier { supplierID = "SP001", supplierName = "Datu Puti Company", isActive = true, productCount = 10 });
            suppliersDB.Add(new Supplier { supplierID = "SP002", supplierName = "Payless Noodles, Inc", isActive = false, productCount = 5 });
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
            }
        }
        public void DeleteSupplier(string id) {
            suppliersDB.RemoveAll(x => x.supplierID == id);
        }
        public List<Supplier> RetrieveSuppliers()
        {
            return suppliersDB.ToList();
        }
    }
}