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
            //Whole Frame
            panelMain.Visible = true;
            panelMain.BringToFront();
            panelSupplier.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //PROCUREMENT
        }

        private void button1_Click(object sender, EventArgs e)
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
            //purchase
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back 


        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add
        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {
            //SUPPLIERS
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

        private void btnBackSupplierPanel_Click(object sender, EventArgs e)
        {
            //back
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2
            
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
