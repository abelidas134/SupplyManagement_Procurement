using System;
using System.Collections.Generic;
using System.Text;
using procurementModels;

namespace procurementDataL
{
    public class supplierDataL
    {
        public List<suppliers> suppliersDB = new List<suppliers>();

        public supplierDataL()
        {
            suppliersDB.Add(new suppliers { supplierID = "SP001", supplierName="Datu Puti Company", isActive = true, productCount = 10});
            suppliersDB.Add(new suppliers { supplierID = "SP002", supplierName="Payless Noodles, Inc", isActive = false, productCount = 5});
            suppliersDB.Add(new suppliers { supplierID = "SP003", supplierName="Tawas ni Mang Ben Company", isActive = true, productCount = 2});
            suppliersDB.Add(new suppliers { supplierID = "SP004", supplierName="Ajinomoto Company", isActive = false, productCount = 3});
        }

        public void addSuppliers(suppliers spl)
        {
            suppliersDB.Add(spl);
        }

        public void updateSupplier(suppliers spl)
        {
            var existing = suppliersDB.Find(s=>s.supplierID==spl.supplierID);
            if (existing != null)
            {
                existing.supplierName = spl.supplierName;
                existing.isActive = spl.isActive;
                existing.productCount = spl.productCount;
            }
        }

        public void deleteSupplier(string supplierID)
        {
            suppliersDB.RemoveAll(s=>s.supplierID==supplierID);
        }

        public List<suppliers> retrieveSuppliers()
        {
            return suppliersDB;
        }


    }
}
