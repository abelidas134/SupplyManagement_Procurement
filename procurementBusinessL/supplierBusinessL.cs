using procurementDataL;
using procurementModels;

namespace procurementBusinessL
{
    public class Business
    {
        supplierDataL splDataBusiness = new supplierDataL();

        public bool SupplierActivity(string supplierID)
        {
            suppliers actSupplier = splDataBusiness.retrieveSuppliers().FirstOrDefault(s => s.SupplierID == supplierID);

            if (actSupplier==null)
            {
                return false;
            }
            return actSupplier.isActive;
        }

        public bool CanAddSupplier(suppliers supplier)
        {
            return supplier.productCount >= 5;
        }

    }
    
}
