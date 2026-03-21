namespace forms
{
    partial class procurementPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSupplier = new Panel();
            btnBackSupplierPanel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnView = new Button();
            btnAdd = new Button();
            lblSupplier = new Label();
            panelMain = new Panel();
            btnBackMainPanel = new Button();
            btnPurchase = new Button();
            btnSuppliers = new Button();
            btnInventory = new Button();
            lblProcurement = new Label();
            panelAdd = new Panel();
            btnAddSupplierName = new Button();
            txtSupplierContact = new TextBox();
            txtSupplierName = new TextBox();
            lblcontactSupplier = new Label();
            lblAddSupplier = new Label();
            lblAddSupplierName = new Label();
            btnBackAddSupplier = new Button();
            panelCategory = new Panel();
            btnBeverages = new Button();
            btnBiscuits = new Button();
            btnNoodles = new Button();
            btnHygieneProducts = new Button();
            btnCannedGoods = new Button();
            btnBackCategoryPanel = new Button();
            lblCategories = new Label();
            panelView = new Panel();
            lblViewSupplier = new Label();
            btnBackViewSupplier = new Button();
            panelDelete = new Panel();
            lblDeleteSupplier = new Label();
            btnBackDeleteSupplier = new Button();
            panelUpdate = new Panel();
            lblUpdateSupplier = new Label();
            btnBackUpdateSupplier = new Button();
            lblAddProductsAvailability = new Label();
            numericAddProductCount = new NumericUpDown();
            lblAddSupplierStatus = new Label();
            comboBoxAddSupplier = new ComboBox();
            panelSupplier.SuspendLayout();
            panelMain.SuspendLayout();
            panelAdd.SuspendLayout();
            panelCategory.SuspendLayout();
            panelView.SuspendLayout();
            panelDelete.SuspendLayout();
            panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAddProductCount).BeginInit();
            SuspendLayout();
            // 
            // panelSupplier
            // 
            panelSupplier.Controls.Add(btnBackSupplierPanel);
            panelSupplier.Controls.Add(btnDelete);
            panelSupplier.Controls.Add(btnUpdate);
            panelSupplier.Controls.Add(btnView);
            panelSupplier.Controls.Add(btnAdd);
            panelSupplier.Controls.Add(lblSupplier);
            panelSupplier.Location = new Point(0, -5);
            panelSupplier.Name = "panelSupplier";
            panelSupplier.Size = new Size(797, 446);
            panelSupplier.TabIndex = 5;
            // 
            // btnBackSupplierPanel
            // 
            btnBackSupplierPanel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBackSupplierPanel.Location = new Point(9, 393);
            btnBackSupplierPanel.Name = "btnBackSupplierPanel";
            btnBackSupplierPanel.Size = new Size(87, 43);
            btnBackSupplierPanel.TabIndex = 6;
            btnBackSupplierPanel.Text = "Back";
            btnBackSupplierPanel.UseVisualStyleBackColor = true;
            btnBackSupplierPanel.Click += btnBackSupplierPanel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnDelete.Location = new Point(451, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 73);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(134, 263);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(193, 73);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnView
            // 
            btnView.AccessibleRole = AccessibleRole.None;
            btnView.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnView.Location = new Point(451, 159);
            btnView.Name = "btnView";
            btnView.Size = new Size(193, 73);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnAdd.Location = new Point(134, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(193, 73);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.CausesValidation = false;
            lblSupplier.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(312, 78);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(183, 35);
            lblSupplier.TabIndex = 1;
            lblSupplier.Text = "SUPPLIERS";
            lblSupplier.Click += lblSupplier_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(btnBackMainPanel);
            panelMain.Controls.Add(btnPurchase);
            panelMain.Controls.Add(btnSuppliers);
            panelMain.Controls.Add(btnInventory);
            panelMain.Controls.Add(lblProcurement);
            panelMain.Location = new Point(3, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(797, 446);
            panelMain.TabIndex = 7;
            panelMain.Paint += panelMain_Paint;
            // 
            // btnBackMainPanel
            // 
            btnBackMainPanel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBackMainPanel.Location = new Point(9, 393);
            btnBackMainPanel.Name = "btnBackMainPanel";
            btnBackMainPanel.Size = new Size(87, 43);
            btnBackMainPanel.TabIndex = 5;
            btnBackMainPanel.Text = "Back";
            btnBackMainPanel.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.Location = new Point(535, 187);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(193, 73);
            btnPurchase.TabIndex = 4;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnSuppliers.Location = new Point(302, 187);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(193, 73);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += suppliers_Click;
            // 
            // btnInventory
            // 
            btnInventory.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnInventory.Location = new Point(63, 187);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(193, 73);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory Status";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // lblProcurement
            // 
            lblProcurement.AutoSize = true;
            lblProcurement.CausesValidation = false;
            lblProcurement.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcurement.Location = new Point(254, 81);
            lblProcurement.Name = "lblProcurement";
            lblProcurement.Size = new Size(255, 35);
            lblProcurement.TabIndex = 1;
            lblProcurement.Text = "PROCUREMENT";
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(comboBoxAddSupplier);
            panelAdd.Controls.Add(lblAddSupplierStatus);
            panelAdd.Controls.Add(numericAddProductCount);
            panelAdd.Controls.Add(lblAddProductsAvailability);
            panelAdd.Controls.Add(btnAddSupplierName);
            panelAdd.Controls.Add(txtSupplierContact);
            panelAdd.Controls.Add(txtSupplierName);
            panelAdd.Controls.Add(lblcontactSupplier);
            panelAdd.Controls.Add(lblAddSupplier);
            panelAdd.Controls.Add(lblAddSupplierName);
            panelAdd.Controls.Add(btnBackAddSupplier);
            panelAdd.Location = new Point(0, 0);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(797, 446);
            panelAdd.TabIndex = 6;
            // 
            // btnAddSupplierName
            // 
            btnAddSupplierName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnAddSupplierName.Location = new Point(700, 393);
            btnAddSupplierName.Name = "btnAddSupplierName";
            btnAddSupplierName.Size = new Size(87, 43);
            btnAddSupplierName.TabIndex = 13;
            btnAddSupplierName.Text = "Add";
            btnAddSupplierName.UseVisualStyleBackColor = true;
            btnAddSupplierName.Click += btnAddSupplierName_Click;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Location = new Point(312, 220);
            txtSupplierContact.Multiline = true;
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.Size = new Size(391, 52);
            txtSupplierContact.TabIndex = 12;
            txtSupplierContact.TextChanged += txtSupplierContact_TextChanged;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(312, 141);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(391, 52);
            txtSupplierName.TabIndex = 11;
            txtSupplierName.TextChanged += txtSupplierName_TextChanged;
            // 
            // lblcontactSupplier
            // 
            lblcontactSupplier.AutoSize = true;
            lblcontactSupplier.CausesValidation = false;
            lblcontactSupplier.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontactSupplier.Location = new Point(90, 238);
            lblcontactSupplier.Name = "lblcontactSupplier";
            lblcontactSupplier.Size = new Size(190, 25);
            lblcontactSupplier.TabIndex = 10;
            lblcontactSupplier.Text = "Contact Number:";
            // 
            // lblAddSupplier
            // 
            lblAddSupplier.AutoSize = true;
            lblAddSupplier.CausesValidation = false;
            lblAddSupplier.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSupplier.Location = new Point(257, 73);
            lblAddSupplier.Name = "lblAddSupplier";
            lblAddSupplier.Size = new Size(256, 35);
            lblAddSupplier.TabIndex = 8;
            lblAddSupplier.Text = "ADD SUPPLIERS";
            lblAddSupplier.Click += lblAddSupplier_Click;
            // 
            // lblAddSupplierName
            // 
            lblAddSupplierName.AutoSize = true;
            lblAddSupplierName.CausesValidation = false;
            lblAddSupplierName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSupplierName.Location = new Point(39, 155);
            lblAddSupplierName.Name = "lblAddSupplierName";
            lblAddSupplierName.Size = new Size(246, 25);
            lblAddSupplierName.TabIndex = 9;
            lblAddSupplierName.Text = "Name of Organization: ";
            lblAddSupplierName.Click += lblAddSupplierName_Click;
            // 
            // btnBackAddSupplier
            // 
            btnBackAddSupplier.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBackAddSupplier.Location = new Point(9, 393);
            btnBackAddSupplier.Name = "btnBackAddSupplier";
            btnBackAddSupplier.Size = new Size(87, 43);
            btnBackAddSupplier.TabIndex = 7;
            btnBackAddSupplier.Text = "Back";
            btnBackAddSupplier.UseVisualStyleBackColor = true;
            // 
            // panelCategory
            // 
            panelCategory.Controls.Add(btnBeverages);
            panelCategory.Controls.Add(btnBiscuits);
            panelCategory.Controls.Add(btnNoodles);
            panelCategory.Controls.Add(btnHygieneProducts);
            panelCategory.Controls.Add(btnCannedGoods);
            panelCategory.Controls.Add(btnBackCategoryPanel);
            panelCategory.Controls.Add(lblCategories);
            panelCategory.Location = new Point(0, 0);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(797, 446);
            panelCategory.TabIndex = 9;
            panelCategory.Paint += panelCategory_Paint;
            // 
            // btnBeverages
            // 
            btnBeverages.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBeverages.Location = new Point(227, 304);
            btnBeverages.Name = "btnBeverages";
            btnBeverages.Size = new Size(304, 73);
            btnBeverages.TabIndex = 15;
            btnBeverages.Text = "E. BEVERAGES";
            btnBeverages.UseVisualStyleBackColor = true;
            btnBeverages.Click += btnBeverages_Click;
            // 
            // btnBiscuits
            // 
            btnBiscuits.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBiscuits.Location = new Point(418, 199);
            btnBiscuits.Name = "btnBiscuits";
            btnBiscuits.Size = new Size(304, 73);
            btnBiscuits.TabIndex = 14;
            btnBiscuits.Text = "D. BISCUITS";
            btnBiscuits.UseVisualStyleBackColor = true;
            btnBiscuits.Click += btnBiscuits_Click;
            // 
            // btnNoodles
            // 
            btnNoodles.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnNoodles.Location = new Point(418, 93);
            btnNoodles.Name = "btnNoodles";
            btnNoodles.Size = new Size(304, 73);
            btnNoodles.TabIndex = 13;
            btnNoodles.Text = "C. NOODLES";
            btnNoodles.UseVisualStyleBackColor = true;
            btnNoodles.Click += btnNoodles_Click;
            // 
            // btnHygieneProducts
            // 
            btnHygieneProducts.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnHygieneProducts.Location = new Point(23, 199);
            btnHygieneProducts.Name = "btnHygieneProducts";
            btnHygieneProducts.Size = new Size(304, 73);
            btnHygieneProducts.TabIndex = 12;
            btnHygieneProducts.Text = "B. HYGIENE PRODUCTS";
            btnHygieneProducts.UseVisualStyleBackColor = true;
            btnHygieneProducts.Click += btnHygieneProducts_Click;
            // 
            // btnCannedGoods
            // 
            btnCannedGoods.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnCannedGoods.Location = new Point(23, 93);
            btnCannedGoods.Name = "btnCannedGoods";
            btnCannedGoods.Size = new Size(304, 73);
            btnCannedGoods.TabIndex = 11;
            btnCannedGoods.Text = "A. CANNED GOODS";
            btnCannedGoods.UseVisualStyleBackColor = true;
            btnCannedGoods.Click += btnCannedGoods_Click;
            // 
            // btnBackCategoryPanel
            // 
            btnBackCategoryPanel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBackCategoryPanel.Location = new Point(9, 393);
            btnBackCategoryPanel.Name = "btnBackCategoryPanel";
            btnBackCategoryPanel.Size = new Size(87, 43);
            btnBackCategoryPanel.TabIndex = 10;
            btnBackCategoryPanel.Text = "Back";
            btnBackCategoryPanel.UseVisualStyleBackColor = true;
            btnBackCategoryPanel.Click += btnBackCategoryPanel_Click;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.CausesValidation = false;
            lblCategories.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategories.Location = new Point(217, 38);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(388, 35);
            lblCategories.TabIndex = 9;
            lblCategories.Text = "PRODUCTS CATEGORIES";
            lblCategories.Click += lblCategories_Click;
            // 
            // panelView
            // 
            panelView.Controls.Add(lblViewSupplier);
            panelView.Controls.Add(btnBackViewSupplier);
            panelView.Location = new Point(0, 0);
            panelView.Name = "panelView";
            panelView.Size = new Size(797, 446);
            panelView.TabIndex = 9;
            // 
            // lblViewSupplier
            // 
            lblViewSupplier.AutoSize = true;
            lblViewSupplier.CausesValidation = false;
            lblViewSupplier.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewSupplier.Location = new Point(257, 73);
            lblViewSupplier.Name = "lblViewSupplier";
            lblViewSupplier.Size = new Size(271, 35);
            lblViewSupplier.TabIndex = 8;
            lblViewSupplier.Text = "VIEW SUPPLIERS";
            // 
            // btnBackViewSupplier
            // 
            btnBackViewSupplier.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBackViewSupplier.Location = new Point(9, 393);
            btnBackViewSupplier.Name = "btnBackViewSupplier";
            btnBackViewSupplier.Size = new Size(87, 43);
            btnBackViewSupplier.TabIndex = 7;
            btnBackViewSupplier.Text = "Back";
            btnBackViewSupplier.UseVisualStyleBackColor = true;
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(lblDeleteSupplier);
            panelDelete.Controls.Add(btnBackDeleteSupplier);
            panelDelete.Location = new Point(0, 0);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(797, 446);
            panelDelete.TabIndex = 10;
            // 
            // lblDeleteSupplier
            // 
            lblDeleteSupplier.AutoSize = true;
            lblDeleteSupplier.CausesValidation = false;
            lblDeleteSupplier.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeleteSupplier.Location = new Point(257, 73);
            lblDeleteSupplier.Name = "lblDeleteSupplier";
            lblDeleteSupplier.Size = new Size(313, 35);
            lblDeleteSupplier.TabIndex = 8;
            lblDeleteSupplier.Text = "DELETE SUPPLIERS";
            // 
            // btnBackDeleteSupplier
            // 
            btnBackDeleteSupplier.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBackDeleteSupplier.Location = new Point(9, 393);
            btnBackDeleteSupplier.Name = "btnBackDeleteSupplier";
            btnBackDeleteSupplier.Size = new Size(87, 43);
            btnBackDeleteSupplier.TabIndex = 7;
            btnBackDeleteSupplier.Text = "Back";
            btnBackDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(lblUpdateSupplier);
            panelUpdate.Controls.Add(btnBackUpdateSupplier);
            panelUpdate.Location = new Point(0, 0);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(797, 446);
            panelUpdate.TabIndex = 10;
            // 
            // lblUpdateSupplier
            // 
            lblUpdateSupplier.AutoSize = true;
            lblUpdateSupplier.CausesValidation = false;
            lblUpdateSupplier.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateSupplier.Location = new Point(257, 73);
            lblUpdateSupplier.Name = "lblUpdateSupplier";
            lblUpdateSupplier.Size = new Size(313, 35);
            lblUpdateSupplier.TabIndex = 8;
            lblUpdateSupplier.Text = "UPDATE SUPPLIERS";
            // 
            // btnBackUpdateSupplier
            // 
            btnBackUpdateSupplier.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBackUpdateSupplier.Location = new Point(9, 393);
            btnBackUpdateSupplier.Name = "btnBackUpdateSupplier";
            btnBackUpdateSupplier.Size = new Size(87, 43);
            btnBackUpdateSupplier.TabIndex = 7;
            btnBackUpdateSupplier.Text = "Back";
            btnBackUpdateSupplier.UseVisualStyleBackColor = true;
            // 
            // lblAddProductsAvailability
            // 
            lblAddProductsAvailability.AutoSize = true;
            lblAddProductsAvailability.CausesValidation = false;
            lblAddProductsAvailability.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddProductsAvailability.Location = new Point(55, 328);
            lblAddProductsAvailability.Name = "lblAddProductsAvailability";
            lblAddProductsAvailability.Size = new Size(222, 25);
            lblAddProductsAvailability.TabIndex = 14;
            lblAddProductsAvailability.Text = "Products Availability:";
            lblAddProductsAvailability.Click += lblAddProductsAvailability_Click;
            // 
            // numericAddProductCount
            // 
            numericAddProductCount.Location = new Point(283, 323);
            numericAddProductCount.Name = "numericAddProductCount";
            numericAddProductCount.Size = new Size(150, 30);
            numericAddProductCount.TabIndex = 15;
            // 
            // lblAddSupplierStatus
            // 
            lblAddSupplierStatus.AutoSize = true;
            lblAddSupplierStatus.CausesValidation = false;
            lblAddSupplierStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSupplierStatus.Location = new Point(470, 323);
            lblAddSupplierStatus.Name = "lblAddSupplierStatus";
            lblAddSupplierStatus.Size = new Size(83, 25);
            lblAddSupplierStatus.TabIndex = 16;
            lblAddSupplierStatus.Text = "Status:";
            // 
            // comboBoxAddSupplier
            // 
            comboBoxAddSupplier.FormattingEnabled = true;
            comboBoxAddSupplier.Items.AddRange(new object[] { "ACTIVE", "INACTIVE" });
            comboBoxAddSupplier.Location = new Point(571, 317);
            comboBoxAddSupplier.Name = "comboBoxAddSupplier";
            comboBoxAddSupplier.Size = new Size(151, 31);
            comboBoxAddSupplier.TabIndex = 17;
            // 
            // procurementPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 452);
            Controls.Add(panelAdd);
            Controls.Add(panelUpdate);
            Controls.Add(panelDelete);
            Controls.Add(panelView);
            Controls.Add(panelCategory);
            Controls.Add(panelSupplier);
            Controls.Add(panelMain);
            Name = "procurementPanel";
            Text = "Supply Management";
            Load += procurementPanel_Load;
            panelSupplier.ResumeLayout(false);
            panelSupplier.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelCategory.ResumeLayout(false);
            panelCategory.PerformLayout();
            panelView.ResumeLayout(false);
            panelView.PerformLayout();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAddProductCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSupplier;
        private Button btnAdd;
        private Label lblSupplier;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBackSupplierPanel;
        private Panel panelMain;
        private Button btnBackMainPanel;
        private Button btnPurchase;
        private Button btnSuppliers;
        private Button btnInventory;
        private Label lblProcurement;
        private Panel panelAdd;
        private Label lblAddSupplier;
        private Button btnBackAddSupplier;
        private Panel panelCategory;
        private Button btnHygieneProducts;
        private Button btnCannedGoods;
        private Button btnBackCategoryPanel;
        private Label lblCategories;
        private Button btnNoodles;
        private Button btnBiscuits;
        private Button btnBeverages;
        private Panel panelView;
        private Label lblViewSupplier;
        private Button btnBackViewSupplier;
        private Panel panelDelete;
        private Panel panelUpdate;
        private Label lblUpdateSupplier;
        private Button btnBackUpdateSupplier;
        private Label lblDeleteSupplier;
        private Button btnBackDeleteSupplier;
        private Label addSupplierName;
        private Label lblAddSupplierName;
        private Label lblcontactSupplier;
        private TextBox txtSupplierName;
        private TextBox txtSupplierContact;
        private Button btnAddSupplierName;
        private Label lblAddProductsAvailability;
        private NumericUpDown numericAddProductCount;
        private ComboBox comboBoxAddSupplier;
        private Label lblAddSupplierStatus;
    }
}
