using procurementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;

namespace procurementDataL
{
    public class supplyManagementJSONFile : ISupplierData
    {

        public List<Supplier> suppliers = new List<Supplier>();

        private string _jsonFile;
        SupplierDataL data = new SupplierDataL();

        public supplyManagementJSONFile()
        {
            _jsonFile = $"{AppDomain.CurrentDomain.BaseDirectory}/SupplierManagement.json";

            PopulateJsonFile();
        }

        private void PopulateJsonFile()
        {
            RetrieveData();

            if (suppliers.Count<=0)
            {
                suppliers = data.RetrieveSuppliers();

                SaveData();
                }
        }

        private void SaveData()
        {
            using (var jsonOutput = File.OpenWrite(_jsonFile))
            {
                JsonSerializer.Serialize<List<Supplier>>(
                    new Utf8JsonWriter (jsonOutput, new JsonWriterOptions
                    { SkipValidation = true, Indented = true})
                    , suppliers);
            }
        }

        private void RetrieveData()
        {
            using (var jsonFileReader = File.OpenText(_jsonFile))
            {
                suppliers = JsonSerializer.Deserialize<List<Supplier>>(
                    jsonFileReader.ReadToEnd(),new JsonSerializerOptions
                    {PropertyNameCaseInsensitive = true});
                suppliers = suppliers ?? new List<Supplier>();
            }
        }

        public void AddSupplier(Supplier s)
        {
            suppliers.Add(s);
            SaveData();
        }

        public void UpdateSupplier(Supplier s)
        {
            var existing = suppliers.Find(x => x.supplierID == s.supplierID);
            if (existing != null)
            {
                existing.supplierName = s.supplierName;
                existing.isActive = s.isActive;
                existing.productCount = s.productCount;
                existing.category = s.category;
            }
            SaveData();
        }

        public void DeleteSupplier(string id)
        {
            suppliers.RemoveAll(x => x.supplierID == id);
            SaveData();
        }

        public void DeleteAll(char category)
        {
            suppliers.RemoveAll(s => s.category == category);
            SaveData(); ;
        }

        public List<Supplier> RetrieveSuppliers()
        {
            return suppliers.ToList();
        }

        public List<Supplier> GetByCategory(char category)
        {
            return suppliers.Where(s => s.category == category).ToList();
        }

    }
}
