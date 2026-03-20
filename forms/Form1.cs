namespace forms
{
    public partial class procurementPanel : Form
    {
        public procurementPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Whole Frame
            panel1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //PROCUREMENT
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inventory Status
        }/**/

        private void suppliers_Click(object sender, EventArgs e)
        {
            //suppliers
            panel1.Visible = true;
            panel1.BringToFront();

        }

        private void purchase_Click(object sender, EventArgs e)
        {
            //purchase
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back 


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Add
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //SUPPLIERS
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //View
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Update
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Delete
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //back
            panel1.Visible = false;
            panel1.SendToBack();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2
        }
    }
}
