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
            panelSupplier.SuspendLayout();
            panelMain.SuspendLayout();
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
            btnBackMainPanel.Location = new Point(12, 396);
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
            // procurementPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 452);
            Name = "procurementPanel";
            Text = "Form1";
            Load += procurementPanel_Load;
            panelSupplier.ResumeLayout(false);
            panelSupplier.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);

            Controls.Add(panelMain);
            Controls.Add(panelSupplier);
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
    }
}
