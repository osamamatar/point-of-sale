namespace WatchesShop.View
{
    partial class frm_AllProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AllProducts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_all_products = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProductSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProductCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.TxtBrandName = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEndUserPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CkIsExpiring = new System.Windows.Forms.CheckBox();
            this.DtpProductExpireDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ComboProductCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_products)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_all_products);
            this.groupBox1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1052, 453);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتجات";
            // 
            // dgv_all_products
            // 
            this.dgv_all_products.AllowUserToAddRows = false;
            this.dgv_all_products.AllowUserToDeleteRows = false;
            this.dgv_all_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_all_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_all_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all_products.Location = new System.Drawing.Point(8, 37);
            this.dgv_all_products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_all_products.Name = "dgv_all_products";
            this.dgv_all_products.ReadOnly = true;
            this.dgv_all_products.RowHeadersWidth = 62;
            this.dgv_all_products.RowTemplate.Height = 28;
            this.dgv_all_products.Size = new System.Drawing.Size(1016, 404);
            this.dgv_all_products.TabIndex = 0;
            this.dgv_all_products.DoubleClick += new System.EventHandler(this.dgv_all_products_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(388, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "بحث عن";
            // 
            // TxtProductSearch
            // 
            this.TxtProductSearch.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductSearch.Location = new System.Drawing.Point(8, 16);
            this.TxtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductSearch.Name = "TxtProductSearch";
            this.TxtProductSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtProductSearch.Size = new System.Drawing.Size(364, 39);
            this.TxtProductSearch.TabIndex = 1;
            this.TxtProductSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TxtProductSearch);
            this.groupBox3.Location = new System.Drawing.Point(18, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(541, 68);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(889, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 34);
            this.label6.TabIndex = 39;
            this.label6.Text = "سعر المنتج";
            // 
            // TxtProductPrice
            // 
            this.TxtProductPrice.BackColor = System.Drawing.Color.White;
            this.TxtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductPrice.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtProductPrice.Location = new System.Drawing.Point(861, 185);
            this.TxtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductPrice.Name = "TxtProductPrice";
            this.TxtProductPrice.Size = new System.Drawing.Size(172, 41);
            this.TxtProductPrice.TabIndex = 32;
            this.TxtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(401, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 34);
            this.label4.TabIndex = 38;
            this.label4.Text = "تكلفة المنتج";
            // 
            // TxtProductCost
            // 
            this.TxtProductCost.BackColor = System.Drawing.Color.White;
            this.TxtProductCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductCost.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtProductCost.Location = new System.Drawing.Point(364, 61);
            this.TxtProductCost.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductCost.Name = "TxtProductCost";
            this.TxtProductCost.Size = new System.Drawing.Size(190, 41);
            this.TxtProductCost.TabIndex = 31;
            this.TxtProductCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(954, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 34);
            this.label3.TabIndex = 37;
            this.label3.Text = "كود المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(875, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 34);
            this.label2.TabIndex = 36;
            this.label2.Text = "اسم المنتج";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(659, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "البراند";
            // 
            // TxtProductId
            // 
            this.TxtProductId.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductId.ForeColor = System.Drawing.Color.Red;
            this.TxtProductId.Location = new System.Drawing.Point(831, 32);
            this.TxtProductId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.ReadOnly = true;
            this.TxtProductId.Size = new System.Drawing.Size(105, 41);
            this.TxtProductId.TabIndex = 27;
            this.TxtProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBrandName
            // 
            this.TxtBrandName.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBrandName.ForeColor = System.Drawing.Color.Red;
            this.TxtBrandName.Location = new System.Drawing.Point(583, 61);
            this.TxtBrandName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBrandName.Name = "TxtBrandName";
            this.TxtBrandName.Size = new System.Drawing.Size(222, 41);
            this.TxtBrandName.TabIndex = 29;
            this.TxtBrandName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductName.ForeColor = System.Drawing.Color.Red;
            this.TxtProductName.Location = new System.Drawing.Point(813, 61);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(225, 41);
            this.TxtProductName.TabIndex = 28;
            this.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(695, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 34);
            this.label7.TabIndex = 41;
            this.label7.Text = "سعر المستهلك";
            // 
            // TxtEndUserPrice
            // 
            this.TxtEndUserPrice.BackColor = System.Drawing.Color.White;
            this.TxtEndUserPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEndUserPrice.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEndUserPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtEndUserPrice.Location = new System.Drawing.Point(699, 185);
            this.TxtEndUserPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEndUserPrice.Name = "TxtEndUserPrice";
            this.TxtEndUserPrice.Size = new System.Drawing.Size(154, 41);
            this.TxtEndUserPrice.TabIndex = 40;
            this.TxtEndUserPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(523, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 34);
            this.label8.TabIndex = 42;
            this.label8.Text = "تاريخ الانتهاء";
            // 
            // CkIsExpiring
            // 
            this.CkIsExpiring.AutoSize = true;
            this.CkIsExpiring.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkIsExpiring.ForeColor = System.Drawing.Color.White;
            this.CkIsExpiring.Location = new System.Drawing.Point(324, 145);
            this.CkIsExpiring.Name = "CkIsExpiring";
            this.CkIsExpiring.Size = new System.Drawing.Size(196, 38);
            this.CkIsExpiring.TabIndex = 43;
            this.CkIsExpiring.Text = "يوجد تاريخ انتهاء";
            this.CkIsExpiring.UseVisualStyleBackColor = true;
            // 
            // DtpProductExpireDate
            // 
            this.DtpProductExpireDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpProductExpireDate.Location = new System.Drawing.Point(324, 198);
            this.DtpProductExpireDate.Name = "DtpProductExpireDate";
            this.DtpProductExpireDate.Size = new System.Drawing.Size(337, 28);
            this.DtpProductExpireDate.TabIndex = 44;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.ComboProductCategory);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.DtpProductExpireDate);
            this.groupBox4.Controls.Add(this.CkIsExpiring);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TxtEndUserPrice);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.TxtProductPrice);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TxtProductCost);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TxtBrandName);
            this.groupBox4.Controls.Add(this.TxtProductName);
            this.groupBox4.Location = new System.Drawing.Point(18, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1044, 240);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(6, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 122);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClose.Location = new System.Drawing.Point(7, 27);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(136, 87);
            this.BtnClose.TabIndex = 48;
            this.BtnClose.Text = "خروج";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSave.Location = new System.Drawing.Point(151, 27);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 87);
            this.BtnSave.TabIndex = 47;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // ComboProductCategory
            // 
            this.ComboProductCategory.FormattingEnabled = true;
            this.ComboProductCategory.Location = new System.Drawing.Point(36, 61);
            this.ComboProductCategory.Name = "ComboProductCategory";
            this.ComboProductCategory.Size = new System.Drawing.Size(230, 24);
            this.ComboProductCategory.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(116, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 34);
            this.label9.TabIndex = 45;
            this.label9.Text = "الفئة";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.Location = new System.Drawing.Point(683, 9);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(102, 82);
            this.BtnEdit.TabIndex = 49;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDelete.Location = new System.Drawing.Point(577, 13);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(102, 78);
            this.BtnDelete.TabIndex = 50;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // frm_AllProducts
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1085, 801);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtProductId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1103, 848);
            this.Name = "frm_AllProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتجات";
            this.Load += new System.EventHandler(this.frm_AllProducts_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_products)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_all_products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProductSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtProductPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtProductCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtProductId;
        public System.Windows.Forms.TextBox TxtBrandName;
        public System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtEndUserPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CkIsExpiring;
        private System.Windows.Forms.DateTimePicker DtpProductExpireDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox ComboProductCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
    }
}