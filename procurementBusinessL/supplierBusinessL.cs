using System.Linq;
using procurementDataL;
using procurementModels;

namespace procurementBusinessL
{
    public class Business
    {
        SupplierDataL splDataBusiness = new SupplierDataL();

        public bool SupplierActivity(string supplierID)
        {
            Supplier actSupplier = splDataBusiness.RetrieveSuppliers().FirstOrDefault(s => s.supplierID == supplierID);

            if (actSupplier == null)
                return false;

            return actSupplier.isActive;
        }

        public bool CanAddSupplier(Supplier supplier)
        {
            return supplier.productCount >= 5;
        }
    }
}