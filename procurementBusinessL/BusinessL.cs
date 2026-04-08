using procurementDataL;
using procurementModels;

namespace procurementBusinessL
{
    public class Business
    {
        SupplierDataL splDataBusiness = new SupplierDataL();

        public Business()
        {
            supplyManagementDatabase database = new supplyManagementDatabase();
        }
        public bool CanAddSupplier(int productCount)
        {
            return productCount >= 5;
        }
    }
}