using Microsoft.Data.SqlClient;
using procurementModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace procurementDataL
{
    public class supplyManagementDatabase : ISupplierData
    {
        private string connectionString 
            = "Data Source =.\\SQLEXPRESS; Initial Catalog = SupplierManagement; " +
            "Integrated Security = True; TrustServerCertificate=True;";

        private SqlConnection sqlConnection;

        public supplyManagementDatabase()
        {
            sqlConnection = new SqlConnection(connectionString);
            addSeeds();
        }


        private void addSeeds()
        {
            var existing = RetrieveSuppliers();

            if (existing.Count ==0)
            {

                AddSupplier(new Supplier { supplierID = "SP1", supplierName = "Century Pacific Food, Inc.", isActive = true, productCount = 10, category = 'A' });
                AddSupplier(new Supplier { supplierID = "SP2", supplierName = "Mega Prime Foods Inc.", isActive = true, productCount = 10, category = 'A' });
                AddSupplier(new Supplier { supplierID = "SP3", supplierName = "CDO Foodsphere, Inc.", isActive = true, productCount = 10, category = 'A' });
                AddSupplier(new Supplier { supplierID = "SP4", supplierName = "San Miguel Foods Inc.", isActive = true, productCount = 10, category = 'A' });
                AddSupplier(new Supplier { supplierID = "SP5", supplierName = "Delimondo Food Specialties Inc.", isActive = true, productCount = 10, category = 'A' });

                AddSupplier(new Supplier { supplierID = "SP6", supplierName = "Unilab, Inc.", isActive = true, productCount = 10, category = 'B' });
                AddSupplier(new Supplier { supplierID = "SP7", supplierName = "Splash Corporation", isActive = true, productCount = 10, category = 'B' });
                AddSupplier(new Supplier { supplierID = "SP8", supplierName = "Peerless Products Manufacturing Corporation", isActive = true, productCount = 10, category = 'B' });
                AddSupplier(new Supplier { supplierID = "SP9", supplierName = "Gandang Kalikasan Inc. (Human Nature)", isActive = true, productCount = 10, category = 'B' });
                AddSupplier(new Supplier { supplierID = "SP10", supplierName = "Procter & Gamble Philippines", isActive = true, productCount = 10, category = 'B' });

                AddSupplier(new Supplier { supplierID = "SP11", supplierName = "Monde Nissin Corporation", isActive = true, productCount = 10, category = 'C' });
                AddSupplier(new Supplier { supplierID = "SP12", supplierName = "Universal Robina Corporation", isActive = true, productCount = 10, category = 'C' });
                AddSupplier(new Supplier { supplierID = "SP13", supplierName = "Nissin Foods Philippines", isActive = true, productCount = 10, category = 'C' });
                AddSupplier(new Supplier { supplierID = "SP14", supplierName = "San Miguel Foods Inc.", isActive = true, productCount = 10, category = 'C' });
                AddSupplier(new Supplier { supplierID = "SP15", supplierName = "Century Pacific Foods, Inc.", isActive = true, productCount = 10, category = 'C' });

                AddSupplier(new Supplier { supplierID = "SP16", supplierName = "Rebisco", isActive = true, productCount = 10, category = 'D' });
                AddSupplier(new Supplier { supplierID = "SP17", supplierName = "Universal Robina Corporation", isActive = true, productCount = 10, category = 'D' });
                AddSupplier(new Supplier { supplierID = "SP18", supplierName = "Liwayway Marketing Corporation (Oishi)", isActive = true, productCount = 10, category = 'D' });
                AddSupplier(new Supplier { supplierID = "SP19", supplierName = "JBC Food Corporation", isActive = true, productCount = 10, category = 'D' });
                AddSupplier(new Supplier { supplierID = "SP20", supplierName = "Jack 'n Jill (URC Brand)", isActive = true, productCount = 10, category = 'D' });

                AddSupplier(new Supplier { supplierID = "SP21", supplierName = "Coca-Cola Beverages Philippines", isActive = true, productCount = 10, category = 'E' });
                AddSupplier(new Supplier { supplierID = "SP22", supplierName = "Pepsi-Cola Products Philippines, Inc.", isActive = true, productCount = 10, category = 'E' });
                AddSupplier(new Supplier { supplierID = "SP23", supplierName = "ABC Refreshments Corporation", isActive = true, productCount = 10, category = 'E' });
                AddSupplier(new Supplier { supplierID = "SP24", supplierName = "Asia Bravery, Inc.", isActive = true, productCount = 10, category = 'E' });
                AddSupplier(new Supplier { supplierID = "SP25", supplierName = "San Miguel Corporation", isActive = true, productCount = 10, category = 'E' });
            }
        }

        public void AddSupplier(Supplier s)
        {
            var insertStmnt = "INSERT INTO supplierTable VALUES (@supplierID, @supplierName, @isActive, " +
                "@productCount, @category)";

            SqlCommand insertCommand = new SqlCommand(insertStmnt, sqlConnection);

            insertCommand.Parameters.AddWithValue("@supplierID", s.supplierID);
            insertCommand.Parameters.AddWithValue("@supplierName", s.supplierName);
            insertCommand.Parameters.AddWithValue("@isActive", s.isActive);
            insertCommand.Parameters.AddWithValue("@productCount", s.productCount);
            insertCommand.Parameters.AddWithValue("@category", s.category);
            sqlConnection.Open();
            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void DeleteAll(char category)
        {
            var deleteAll = "DELETE FROM supplierTable WHERE category = @category";

            SqlCommand deleteAllCommand = new SqlCommand(deleteAll, sqlConnection);

            deleteAllCommand.Parameters.AddWithValue("@category",category);
            sqlConnection.Open();
            deleteAllCommand.ExecuteNonQuery ();
            sqlConnection.Close();  
        }

        public void DeleteSupplier(string id)
        {
            var delete = "DELETE FROM supplierTable WHERE supplierID = @supplierID";

            SqlCommand deleteCommand = new SqlCommand(delete, sqlConnection);

            deleteCommand.Parameters.AddWithValue("@supplierID", id);
            sqlConnection.Open();
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<Supplier> GetByCategory(char category)
        {
            var getByCategory = "SELECT supplierID, supplierName, isActive, productCount, category " +
                "FROM supplierTable WHERE category = @category";
            SqlCommand getByCategoryCommand = new SqlCommand(getByCategory, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = getByCategoryCommand.ExecuteReader();
            var suppliers = new List<Supplier>();

            while (dataReader.Read())
            {
                suppliers.Add(new Supplier()
                {
                    supplierID = dataReader["supplierID"].ToString(),
                    supplierName = dataReader["supplierName"].ToString(),
                    isActive = dataReader["isActive"].ToString() != "0",
                    productCount = (int)dataReader["productCount"],
                    category = dataReader["category"].ToString()[0],

                });
            }
            sqlConnection.Close();
            return suppliers;
        }

        public List<Supplier> RetrieveSuppliers()
        {
            var retrieveSuppliers = "SELECT supplierID, supplierName, isActive, productCount, category " +
                "FROM supplierTable";
            SqlCommand retrieveSuppliersCommand = new SqlCommand(retrieveSuppliers, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = retrieveSuppliersCommand.ExecuteReader();
            var suppliers = new List<Supplier>();

            while (dataReader.Read())
            {
                suppliers.Add(new Supplier()
                {
                    supplierID = dataReader["supplierID"].ToString(),
                    supplierName = dataReader["supplierName"].ToString(),
                    isActive = dataReader["isActive"].ToString() != "0",
                    productCount = (int)dataReader["productCount"],
                    category = dataReader["category"].ToString()[0],

                });
            }
            sqlConnection.Close();
            return suppliers;
        }

        public void UpdateSupplier(Supplier s)
        {
            sqlConnection.Open();
            var update = "UPDATE supplierTable SET supplierName = @supplierName, isActive = @isActive, " +
                "productCount = @productCount, category = @category WHERE supplierID = @supplierID";

            SqlCommand updateCommand = new SqlCommand(update, sqlConnection);

            updateCommand.Parameters.AddWithValue("@supplierName", s.supplierName);
            updateCommand.Parameters.AddWithValue("@isActive", s.isActive);
            updateCommand.Parameters.AddWithValue("@productCount", s.productCount);
            updateCommand.Parameters.AddWithValue("@category", s.category);
            updateCommand.Parameters.AddWithValue("@supplierID", s.supplierID);

            updateCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
