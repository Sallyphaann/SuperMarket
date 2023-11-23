namespace Synthesis_assignment
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpProduct = new System.Windows.Forms.TabControl();
            this.tPInfor = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tpAddProduct = new System.Windows.Forms.TabPage();
            this.cbxProductcategory = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxProductSub = new System.Windows.Forms.ComboBox();
            this.tbAQuantity = new System.Windows.Forms.TextBox();
            this.tbAUnit = new System.Windows.Forms.TextBox();
            this.tbAPrice = new System.Windows.Forms.TextBox();
            this.tbAnameCategory = new System.Windows.Forms.TextBox();
            this.lblSubcategoryP = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.tPUpdateProduct = new System.Windows.Forms.TabPage();
            this.lblD = new System.Windows.Forms.Label();
            this.tbIDProduct = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbUpdateSubCategory = new System.Windows.Forms.ComboBox();
            this.tbUpdateQuantity = new System.Windows.Forms.TextBox();
            this.tbUpdateUnit = new System.Windows.Forms.TextBox();
            this.tbUpdataPrice = new System.Windows.Forms.TextBox();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.lblUpdateUnit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.gbxAddSubCate = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbAddSubcategory = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxAddCategory = new System.Windows.Forms.GroupBox();
            this.tbNameCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategoryname = new System.Windows.Forms.Label();
            this.tpProduct.SuspendLayout();
            this.tPInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tpAddProduct.SuspendLayout();
            this.tPUpdateProduct.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.gbxAddSubCate.SuspendLayout();
            this.gbxAddCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.tPInfor);
            this.tpProduct.Controls.Add(this.tpAddProduct);
            this.tpProduct.Controls.Add(this.tPUpdateProduct);
            this.tpProduct.Controls.Add(this.tpCategory);
            this.tpProduct.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpProduct.Location = new System.Drawing.Point(0, 0);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.SelectedIndex = 0;
            this.tpProduct.Size = new System.Drawing.Size(1249, 503);
            this.tpProduct.TabIndex = 0;
            // 
            // tPInfor
            // 
            this.tPInfor.Controls.Add(this.btnUpdate);
            this.tPInfor.Controls.Add(this.tbSearch);
            this.tPInfor.Controls.Add(this.button1);
            this.tPInfor.Controls.Add(this.btnSearch);
            this.tPInfor.Controls.Add(this.dgvProduct);
            this.tPInfor.Location = new System.Drawing.Point(4, 29);
            this.tPInfor.Name = "tPInfor";
            this.tPInfor.Padding = new System.Windows.Forms.Padding(3);
            this.tPInfor.Size = new System.Drawing.Size(1241, 470);
            this.tPInfor.TabIndex = 0;
            this.tPInfor.Text = "Information";
            this.tPInfor.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(519, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 37);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(493, 345);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(289, 27);
            this.tbSearch.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 340);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(1235, 315);
            this.dgvProduct.TabIndex = 0;
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.Controls.Add(this.cbxProductcategory);
            this.tpAddProduct.Controls.Add(this.lblProductCategory);
            this.tpAddProduct.Controls.Add(this.button2);
            this.tpAddProduct.Controls.Add(this.cbxProductSub);
            this.tpAddProduct.Controls.Add(this.tbAQuantity);
            this.tpAddProduct.Controls.Add(this.tbAUnit);
            this.tpAddProduct.Controls.Add(this.tbAPrice);
            this.tpAddProduct.Controls.Add(this.tbAnameCategory);
            this.tpAddProduct.Controls.Add(this.lblSubcategoryP);
            this.tpAddProduct.Controls.Add(this.lblQuantity);
            this.tpAddProduct.Controls.Add(this.label3);
            this.tpAddProduct.Controls.Add(this.lblPrice);
            this.tpAddProduct.Controls.Add(this.lblNameProduct);
            this.tpAddProduct.Location = new System.Drawing.Point(4, 29);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddProduct.Size = new System.Drawing.Size(1241, 470);
            this.tpAddProduct.TabIndex = 1;
            this.tpAddProduct.Text = "Add Product";
            this.tpAddProduct.UseVisualStyleBackColor = true;
            // 
            // cbxProductcategory
            // 
            this.cbxProductcategory.FormattingEnabled = true;
            this.cbxProductcategory.Location = new System.Drawing.Point(836, 132);
            this.cbxProductcategory.Name = "cbxProductcategory";
            this.cbxProductcategory.Size = new System.Drawing.Size(151, 28);
            this.cbxProductcategory.TabIndex = 12;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(720, 132);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(70, 20);
            this.lblProductCategory.TabIndex = 11;
            this.lblProductCategory.Text = "Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbxProductSub
            // 
            this.cbxProductSub.FormattingEnabled = true;
            this.cbxProductSub.Location = new System.Drawing.Point(836, 64);
            this.cbxProductSub.Name = "cbxProductSub";
            this.cbxProductSub.Size = new System.Drawing.Size(151, 28);
            this.cbxProductSub.TabIndex = 9;
            // 
            // tbAQuantity
            // 
            this.tbAQuantity.Location = new System.Drawing.Point(251, 273);
            this.tbAQuantity.Name = "tbAQuantity";
            this.tbAQuantity.Size = new System.Drawing.Size(175, 27);
            this.tbAQuantity.TabIndex = 8;
            // 
            // tbAUnit
            // 
            this.tbAUnit.Location = new System.Drawing.Point(251, 196);
            this.tbAUnit.Name = "tbAUnit";
            this.tbAUnit.Size = new System.Drawing.Size(175, 27);
            this.tbAUnit.TabIndex = 7;
            // 
            // tbAPrice
            // 
            this.tbAPrice.Location = new System.Drawing.Point(251, 125);
            this.tbAPrice.Name = "tbAPrice";
            this.tbAPrice.Size = new System.Drawing.Size(175, 27);
            this.tbAPrice.TabIndex = 6;
            // 
            // tbAnameCategory
            // 
            this.tbAnameCategory.Location = new System.Drawing.Point(251, 64);
            this.tbAnameCategory.Name = "tbAnameCategory";
            this.tbAnameCategory.Size = new System.Drawing.Size(175, 27);
            this.tbAnameCategory.TabIndex = 5;
            // 
            // lblSubcategoryP
            // 
            this.lblSubcategoryP.AutoSize = true;
            this.lblSubcategoryP.Location = new System.Drawing.Point(720, 67);
            this.lblSubcategoryP.Name = "lblSubcategoryP";
            this.lblSubcategoryP.Size = new System.Drawing.Size(95, 20);
            this.lblSubcategoryP.TabIndex = 4;
            this.lblSubcategoryP.Text = "SubCategory";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(123, 273);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(123, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Location = new System.Drawing.Point(123, 67);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(49, 20);
            this.lblNameProduct.TabIndex = 0;
            this.lblNameProduct.Text = "Name";
            // 
            // tPUpdateProduct
            // 
            this.tPUpdateProduct.Controls.Add(this.lblD);
            this.tPUpdateProduct.Controls.Add(this.tbIDProduct);
            this.tPUpdateProduct.Controls.Add(this.comboBox2);
            this.tPUpdateProduct.Controls.Add(this.label1);
            this.tPUpdateProduct.Controls.Add(this.button3);
            this.tPUpdateProduct.Controls.Add(this.cbUpdateSubCategory);
            this.tPUpdateProduct.Controls.Add(this.tbUpdateQuantity);
            this.tPUpdateProduct.Controls.Add(this.tbUpdateUnit);
            this.tPUpdateProduct.Controls.Add(this.tbUpdataPrice);
            this.tPUpdateProduct.Controls.Add(this.tbUpdateName);
            this.tPUpdateProduct.Controls.Add(this.label2);
            this.tPUpdateProduct.Controls.Add(this.lblUpdateQuantity);
            this.tPUpdateProduct.Controls.Add(this.lblUpdateUnit);
            this.tPUpdateProduct.Controls.Add(this.label6);
            this.tPUpdateProduct.Controls.Add(this.lblUpdate);
            this.tPUpdateProduct.Location = new System.Drawing.Point(4, 29);
            this.tPUpdateProduct.Name = "tPUpdateProduct";
            this.tPUpdateProduct.Size = new System.Drawing.Size(1241, 470);
            this.tPUpdateProduct.TabIndex = 2;
            this.tPUpdateProduct.Text = "Update Product";
            this.tPUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(131, 32);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(24, 20);
            this.lblD.TabIndex = 27;
            this.lblD.Text = "ID";
            // 
            // tbIDProduct
            // 
            this.tbIDProduct.Location = new System.Drawing.Point(247, 32);
            this.tbIDProduct.Name = "tbIDProduct";
            this.tbIDProduct.ReadOnly = true;
            this.tbIDProduct.Size = new System.Drawing.Size(175, 27);
            this.tbIDProduct.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(861, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Category";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 42);
            this.button3.TabIndex = 23;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // cbUpdateSubCategory
            // 
            this.cbUpdateSubCategory.FormattingEnabled = true;
            this.cbUpdateSubCategory.Location = new System.Drawing.Point(861, 53);
            this.cbUpdateSubCategory.Name = "cbUpdateSubCategory";
            this.cbUpdateSubCategory.Size = new System.Drawing.Size(151, 28);
            this.cbUpdateSubCategory.TabIndex = 22;
            // 
            // tbUpdateQuantity
            // 
            this.tbUpdateQuantity.Location = new System.Drawing.Point(247, 287);
            this.tbUpdateQuantity.Name = "tbUpdateQuantity";
            this.tbUpdateQuantity.Size = new System.Drawing.Size(175, 27);
            this.tbUpdateQuantity.TabIndex = 21;
            // 
            // tbUpdateUnit
            // 
            this.tbUpdateUnit.Location = new System.Drawing.Point(247, 210);
            this.tbUpdateUnit.Name = "tbUpdateUnit";
            this.tbUpdateUnit.Size = new System.Drawing.Size(175, 27);
            this.tbUpdateUnit.TabIndex = 20;
            // 
            // tbUpdataPrice
            // 
            this.tbUpdataPrice.Location = new System.Drawing.Point(247, 139);
            this.tbUpdataPrice.Name = "tbUpdataPrice";
            this.tbUpdataPrice.Size = new System.Drawing.Size(175, 27);
            this.tbUpdataPrice.TabIndex = 19;
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.Location = new System.Drawing.Point(247, 78);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(175, 27);
            this.tbUpdateName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "SubCategory";
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(119, 287);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(65, 20);
            this.lblUpdateQuantity.TabIndex = 16;
            this.lblUpdateQuantity.Text = "Quantity";
            // 
            // lblUpdateUnit
            // 
            this.lblUpdateUnit.AutoSize = true;
            this.lblUpdateUnit.Location = new System.Drawing.Point(119, 217);
            this.lblUpdateUnit.Name = "lblUpdateUnit";
            this.lblUpdateUnit.Size = new System.Drawing.Size(36, 20);
            this.lblUpdateUnit.TabIndex = 15;
            this.lblUpdateUnit.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(119, 81);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(49, 20);
            this.lblUpdate.TabIndex = 13;
            this.lblUpdate.Text = "Name";
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.gbxAddSubCate);
            this.tpCategory.Controls.Add(this.gbxAddCategory);
            this.tpCategory.Location = new System.Drawing.Point(4, 29);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(1241, 470);
            this.tpCategory.TabIndex = 3;
            this.tpCategory.Text = "Category";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // gbxAddSubCate
            // 
            this.gbxAddSubCate.Controls.Add(this.lblCategory);
            this.gbxAddSubCate.Controls.Add(this.cbxCategory);
            this.gbxAddSubCate.Controls.Add(this.tbAddSubcategory);
            this.gbxAddSubCate.Controls.Add(this.button4);
            this.gbxAddSubCate.Controls.Add(this.label5);
            this.gbxAddSubCate.Location = new System.Drawing.Point(410, 18);
            this.gbxAddSubCate.Name = "gbxAddSubCate";
            this.gbxAddSubCate.Size = new System.Drawing.Size(349, 202);
            this.gbxAddSubCate.TabIndex = 5;
            this.gbxAddSubCate.TabStop = false;
            this.gbxAddSubCate.Text = "Add  SubCategory";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 107);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(134, 99);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(151, 28);
            this.cbxCategory.TabIndex = 4;
            // 
            // tbAddSubcategory
            // 
            this.tbAddSubcategory.Location = new System.Drawing.Point(134, 39);
            this.tbAddSubcategory.Name = "tbAddSubcategory";
            this.tbAddSubcategory.Size = new System.Drawing.Size(151, 27);
            this.tbAddSubcategory.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnAddSubcategory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // gbxAddCategory
            // 
            this.gbxAddCategory.Controls.Add(this.tbNameCategory);
            this.gbxAddCategory.Controls.Add(this.btnAddCategory);
            this.gbxAddCategory.Controls.Add(this.lblCategoryname);
            this.gbxAddCategory.Location = new System.Drawing.Point(22, 18);
            this.gbxAddCategory.Name = "gbxAddCategory";
            this.gbxAddCategory.Size = new System.Drawing.Size(349, 202);
            this.gbxAddCategory.TabIndex = 3;
            this.gbxAddCategory.TabStop = false;
            this.gbxAddCategory.Text = "Add Category";
            // 
            // tbNameCategory
            // 
            this.tbNameCategory.Location = new System.Drawing.Point(134, 39);
            this.tbNameCategory.Name = "tbNameCategory";
            this.tbNameCategory.Size = new System.Drawing.Size(151, 27);
            this.tbNameCategory.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(91, 122);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(94, 29);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategoryname
            // 
            this.lblCategoryname.AutoSize = true;
            this.lblCategoryname.Location = new System.Drawing.Point(18, 39);
            this.lblCategoryname.Name = "lblCategoryname";
            this.lblCategoryname.Size = new System.Drawing.Size(49, 20);
            this.lblCategoryname.TabIndex = 0;
            this.lblCategoryname.Text = "Name";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 508);
            this.Controls.Add(this.tpProduct);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.tpProduct.ResumeLayout(false);
            this.tPInfor.ResumeLayout(false);
            this.tPInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tpAddProduct.ResumeLayout(false);
            this.tpAddProduct.PerformLayout();
            this.tPUpdateProduct.ResumeLayout(false);
            this.tPUpdateProduct.PerformLayout();
            this.tpCategory.ResumeLayout(false);
            this.gbxAddSubCate.ResumeLayout(false);
            this.gbxAddSubCate.PerformLayout();
            this.gbxAddCategory.ResumeLayout(false);
            this.gbxAddCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tpProduct;
        private TabPage tPInfor;
        private TextBox tbSearch;
        private Button button1;
        private Button btnSearch;
        private DataGridView dgvProduct;
        private TabPage tpAddProduct;
        private Label lblQuantity;
        private Label label3;
        private Label lblPrice;
        private Label lblNameProduct;
        private TabPage tPUpdateProduct;
        private TextBox tbAQuantity;
        private TextBox tbAUnit;
        private TextBox tbAPrice;
        private TextBox tbAnameCategory;
        private Label lblSubcategoryP;
        private TabPage tpCategory;
        private Button btnAddCategory;
        private TextBox tbNameCategory;
        private Label lblCategoryname;
        private GroupBox gbxAddCategory;
        private Label lblCategory;
        private ComboBox cbxCategory;
        private Button button2;
        private ComboBox cbxProductSub;
        private ComboBox cbxProductcategory;
        private Label lblProductCategory;
        private ComboBox comboBox2;
        private Label label1;
        private Button button3;
        private ComboBox cbUpdateSubCategory;
        private TextBox tbUpdateQuantity;
        private TextBox tbUpdateUnit;
        private TextBox tbUpdataPrice;
        private TextBox tbUpdateName;
        private Label label2;
        private Label lblUpdateQuantity;
        private Label lblUpdateUnit;
        private Label label6;
        private Label lblUpdate;
        private Button btnUpdate;
        private Label lblD;
        private TextBox tbIDProduct;
        private GroupBox gbxAddSubCate;
        private TextBox tbAddSubcategory;
        private Button button4;
        private Label label5;
    }
}