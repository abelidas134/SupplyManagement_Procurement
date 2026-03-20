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
            label1 = new Label();
            inventory = new Button();
            suppliers = new Button();
            purchase = new Button();
            back = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            view = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 93);
            label1.Name = "label1";
            label1.Size = new Size(255, 35);
            label1.TabIndex = 0;
            label1.Text = "PROCUREMENT";
            label1.Click += label1_Click;
            // 
            // inventory
            // 
            inventory.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            inventory.Location = new Point(60, 198);
            inventory.Name = "inventory";
            inventory.Size = new Size(193, 73);
            inventory.TabIndex = 1;
            inventory.Text = "Inventory Status";
            inventory.UseVisualStyleBackColor = true;
            inventory.Click += button1_Click;
            // 
            // suppliers
            // 
            suppliers.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            suppliers.Location = new Point(304, 198);
            suppliers.Name = "suppliers";
            suppliers.Size = new Size(193, 73);
            suppliers.TabIndex = 2;
            suppliers.Text = "Suppliers";
            suppliers.UseVisualStyleBackColor = true;
            suppliers.Click += suppliers_Click;
            // 
            // purchase
            // 
            purchase.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchase.Location = new Point(558, 198);
            purchase.Name = "purchase";
            purchase.Size = new Size(193, 73);
            purchase.TabIndex = 3;
            purchase.Text = "Purchase";
            purchase.UseVisualStyleBackColor = true;
            purchase.Click += purchase_Click;
            // 
            // back
            // 
            back.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            back.Location = new Point(12, 395);
            back.Name = "back";
            back.Size = new Size(87, 43);
            back.TabIndex = 4;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(view);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 446);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 446);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button2.Location = new Point(9, 393);
            button2.Name = "button2";
            button2.Size = new Size(87, 43);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button6.Location = new Point(451, 263);
            button6.Name = "button6";
            button6.Size = new Size(193, 73);
            button6.TabIndex = 5;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button7.Location = new Point(134, 263);
            button7.Name = "button7";
            button7.Size = new Size(193, 73);
            button7.TabIndex = 4;
            button7.Text = "Update";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.AccessibleRole = AccessibleRole.None;
            button8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button8.Location = new Point(451, 159);
            button8.Name = "button8";
            button8.Size = new Size(193, 73);
            button8.TabIndex = 3;
            button8.Text = "View";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button9.Location = new Point(134, 159);
            button9.Name = "button9";
            button9.Size = new Size(193, 73);
            button9.TabIndex = 2;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.CausesValidation = false;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(312, 78);
            label3.Name = "label3";
            label3.Size = new Size(183, 35);
            label3.TabIndex = 1;
            label3.Text = "SUPPLIERS";
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button5.Location = new Point(9, 393);
            button5.Name = "button5";
            button5.Size = new Size(87, 43);
            button5.TabIndex = 6;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button4.Location = new Point(451, 263);
            button4.Name = "button4";
            button4.Size = new Size(193, 73);
            button4.TabIndex = 5;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button3.Location = new Point(134, 263);
            button3.Name = "button3";
            button3.Size = new Size(193, 73);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // view
            // 
            view.AccessibleRole = AccessibleRole.None;
            view.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            view.Location = new Point(451, 159);
            view.Name = "view";
            view.Size = new Size(193, 73);
            view.TabIndex = 3;
            view.Text = "View";
            view.UseVisualStyleBackColor = true;
            view.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button1.Location = new Point(134, 159);
            button1.Name = "button1";
            button1.Size = new Size(193, 73);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.CausesValidation = false;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 78);
            label2.Name = "label2";
            label2.Size = new Size(183, 35);
            label2.TabIndex = 1;
            label2.Text = "SUPPLIERS";
            label2.Click += label2_Click;
            // 
            // procurementPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 452);
            Controls.Add(back);
            Controls.Add(purchase);
            Controls.Add(suppliers);
            Controls.Add(inventory);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "procurementPanel";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button inventory;
        private Button suppliers;
        private Button purchase;
        private Button back;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private Button view;
        private Button button4;
        private Button button3;
        private Button button5;
        private Panel panel2;
        private Button button2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label3;
    }
}
