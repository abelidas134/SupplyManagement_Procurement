using procurementDataL;
using procurementModels;
using System.Collections.Generic;
using System.Linq;

namespace procurementBusinessL
{
    public class Business
    {
        SupplierDataL dataL = new SupplierDataL();

        public bool CanAddSupplier(int productCount)
        {
            return productCount >= 5;
        }

        public List<Supplier> GetSuppliers()
        {
            return dataL.RetrieveSuppliers();
        }
        public Supplier GetSupplierById(string id)
        {
            return dataL.RetrieveSuppliers().FirstOrDefault(s => s.supplierID == id);
        }

        public List<Product> GetProducts()
        {
            return dataL.RetrieveProducts();
        }

        public Product GetProductById(string id)
        {
            return dataL.RetrieveProducts().FirstOrDefault(p => p.productID == id);
        }

        public void AddSupplier(Supplier supplier)
        {
            dataL.AddSupplier(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            dataL.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(string id)
        {
            dataL.DeleteSupplier(id);
        }

        public void AddProduct(Product product, string supplierID)
        {
            dataL.AddProducts(product, supplierID);
        }

        public void UpdateProduct(Product product,
                                  string supplierID,
                                  string productID)
        {
            dataL.UpdateProducts(product, supplierID, productID);
        }

        public void DeleteProduct(string supplierID,
                                  string productID)
        {
            dataL.DeleteProduct(supplierID, productID);
        }
    }
}