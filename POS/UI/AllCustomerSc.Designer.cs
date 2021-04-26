namespace POS.UI
{
    partial class AllCustomerSc
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreInput = new System.Windows.Forms.NumericUpDown();
            this.noteText = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(55, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 39);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(143, 139);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 39);
            this.DeleteBtn.TabIndex = 78;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(52, 94);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(165, 39);
            this.AddBtn.TabIndex = 77;
            this.AddBtn.Text = "اضافة عميل جديد";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn,
            this.custaddressDataGridViewTextBoxColumn,
            this.custbalanceDataGridViewTextBoxColumn,
            this.custscoreDataGridViewTextBoxColumn,
            this.custnoteDataGridViewTextBoxColumn,
            this.custphoneDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.customerBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 195);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.Size = new System.Drawing.Size(693, 282);
            this.dataGridView.TabIndex = 76;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "id";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.ReadOnly = true;
            this.custidDataGridViewTextBoxColumn.Width = 50;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custaddressDataGridViewTextBoxColumn
            // 
            this.custaddressDataGridViewTextBoxColumn.DataPropertyName = "cust_address";
            this.custaddressDataGridViewTextBoxColumn.HeaderText = "عنوان العميل";
            this.custaddressDataGridViewTextBoxColumn.Name = "custaddressDataGridViewTextBoxColumn";
            this.custaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custbalanceDataGridViewTextBoxColumn
            // 
            this.custbalanceDataGridViewTextBoxColumn.DataPropertyName = "cust_balance";
            this.custbalanceDataGridViewTextBoxColumn.HeaderText = "حساب العميل";
            this.custbalanceDataGridViewTextBoxColumn.Name = "custbalanceDataGridViewTextBoxColumn";
            this.custbalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custscoreDataGridViewTextBoxColumn
            // 
            this.custscoreDataGridViewTextBoxColumn.DataPropertyName = "cust_score";
            this.custscoreDataGridViewTextBoxColumn.HeaderText = "التقييم";
            this.custscoreDataGridViewTextBoxColumn.Name = "custscoreDataGridViewTextBoxColumn";
            this.custscoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnoteDataGridViewTextBoxColumn
            // 
            this.custnoteDataGridViewTextBoxColumn.DataPropertyName = "cust_note";
            this.custnoteDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.custnoteDataGridViewTextBoxColumn.Name = "custnoteDataGridViewTextBoxColumn";
            this.custnoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custphoneDataGridViewTextBoxColumn
            // 
            this.custphoneDataGridViewTextBoxColumn.DataPropertyName = "cust_phone";
            this.custphoneDataGridViewTextBoxColumn.HeaderText = "رقم الهاتف";
            this.custphoneDataGridViewTextBoxColumn.Name = "custphoneDataGridViewTextBoxColumn";
            this.custphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(POS.DB.Customer);
            // 
            // scoreInput
            // 
            this.scoreInput.Location = new System.Drawing.Point(52, 56);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(158, 20);
            this.scoreInput.TabIndex = 90;
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(408, 94);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(170, 46);
            this.noteText.TabIndex = 89;
            this.noteText.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "تقييم العميل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "أسم العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "عنوان العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "ملاحظات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "تليفون";
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(408, 63);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(170, 20);
            this.addText.TabIndex = 82;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(55, 20);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(155, 20);
            this.phoneText.TabIndex = 81;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(408, 20);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(170, 20);
            this.nameText.TabIndex = 80;
            // 
            // AllCustomerSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(722, 517);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "AllCustomerSc";
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.AllCustomerSc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown scoreInput;
        private System.Windows.Forms.RichTextBox noteText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}