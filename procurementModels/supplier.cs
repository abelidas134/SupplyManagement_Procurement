
namespace procurementModels
{
    public class Supplier
    {
        public string supplierID { get; set; }
        public string supplierName { get; set; }
        public bool isActive { get; set; }
        public int productCount { get; set; }
        public char category { get; set; }
        public List<Product> products { get; set; } = new List<Product>();
    }
}