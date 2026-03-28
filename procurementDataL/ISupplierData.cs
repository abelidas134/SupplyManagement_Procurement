using procurementModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace procurementDataL
{
    public interface ISupplierData
    {
        void AddSupplier(Supplier s);
        void UpdateSupplier(Supplier s);
        void DeleteSupplier(string id);
        void DeleteAll(char category);
        List<Supplier> RetrieveSuppliers();
        List<Supplier> GetByCategory(char category);

    }
}
