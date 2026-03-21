using procurementBusinessL;
using procurementModels;
using System.Windows.Forms;

namespace forms
{
    public partial class procurementPanel : Form
    {
        public procurementPanel()
        {
            InitializeComponent();
        }

        private void procurementPanel_Load(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelMain.BringToFront();
            panelSupplier.Visible = false;
            panelCategory.Visible = false;
            panelAdd.Visible = false;
        }


        //MAIN PANEL
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblProcurement_Click(object sender, EventArgs e)
        {
            //PROCUREMENT
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            //Inventory Status
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            //suppliers
            panelSupplier.Visible = true;
            panelMain.Visible = false;
            panelSupplier.BringToFront();

        }

        private void purchase_Click(object sender, EventArgs e)
        {
            //purchase - wala pa to code sa console hehe
        }

        private void btnBackMainPanel_Click(object sender, EventArgs e)
        {
            //Back from the code before me (ABAD)

        }


        //SECOND PANEL
        private void panelSupplier_Paint(object sender, PaintEventArgs e)
        {
            //panel2

        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {
            //SUPPLIERS
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add
            panelCategory.Visible = true;
            panelCategory.BringToFront();
            panelSupplier.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //View
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete
        }
        private void lblAddSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnBackSupplierPanel_Click(object sender, EventArgs e)
        {
            //back
            panelMain.Visible = true;
            panelMain.BringToFront();
            panelSupplier.Visible = false;
        }



        //CATEGORY PANEL
        private void panelCategory_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblCategories_Click(object sender, EventArgs e)
        {

        }
        private void btnNoodles_Click(object sender, EventArgs e)
        {

        }

        private void btnCannedGoods_Click(object sender, EventArgs e)
        {
            //ADD
            panelAdd.Visible = true;
            panelAdd.BringToFront();
            panelCategory.Visible = false;

        }

        private void btnHygieneProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnBiscuits_Click(object sender, EventArgs e)
        {

        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {

        }

        private void btnBackCategoryPanel_Click(object sender, EventArgs e)
        {

        }

        private void lblAddSupplierName_Click(object sender, EventArgs e)
        {

        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplierContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSupplierName_Click(object sender, EventArgs e)
        {
            String suppliersName = txtSupplierName.Text;
            String supplierContact = txtSupplierContact.Text;
            String productCount = numericAddProductCount.Text;
            String supplierStatus = comboBoxAddSupplier.Text;
            int prodCount = int.Parse(productCount);

            var suppliersInfo = new Supplier
            {
                supplierID = "SP00" + DateTime.Now.Second,
                supplierName = suppliersName,
                isActive = (supplierStatus == "ACTIVE") ? true : false,
                productCount = prodCount
            };

            Business business = new Business();
            bool res = business.CanAddSupplier(suppliersInfo);
            if (res)
            {
                MessageBox.Show("ADDED SUCCESSFULLY");
            } else
            {
                MessageBox.Show("DID NOT MEET THE REQUIREMENTS");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddProductsAvailability_Click(object sender, EventArgs e)
        {

        }
    }
}
