namespace POS.UI
{
    partial class AllVendorSc
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.noreText = new System.Windows.Forms.TextBox();
            this.venidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vennameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vennoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "الأسم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "التليفون";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "ملاحظات";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(366, 77);
            this.addressText.Multiline = true;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(175, 31);
            this.addressText.TabIndex = 68;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(34, 35);
            this.phoneText.Multiline = true;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(175, 32);
            this.phoneText.TabIndex = 67;
            this.phoneText.TextChanged += new System.EventHandler(this.phoneText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(366, 38);
            this.nameText.Multiline = true;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(175, 33);
            this.nameText.TabIndex = 66;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(34, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 39);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(135, 140);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 39);
            this.DeleteBtn.TabIndex = 64;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(366, 140);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(175, 39);
            this.AddBtn.TabIndex = 63;
            this.AddBtn.Text = "اضافة مورد جديد";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venidDataGridViewTextBoxColumn,
            this.vennameDataGridViewTextBoxColumn,
            this.venaddressDataGridViewTextBoxColumn,
            this.vennoteDataGridViewTextBoxColumn,
            this.venbalanceDataGridViewTextBoxColumn,
            this.venphoneDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.vendorDtoBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(14, 194);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.Size = new System.Drawing.Size(594, 331);
            this.dataGridView.TabIndex = 61;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // noreText
            // 
            this.noreText.Location = new System.Drawing.Point(34, 82);
            this.noreText.Multiline = true;
            this.noreText.Name = "noreText";
            this.noreText.Size = new System.Drawing.Size(175, 32);
            this.noreText.TabIndex = 75;
            // 
            // venidDataGridViewTextBoxColumn
            // 
            this.venidDataGridViewTextBoxColumn.DataPropertyName = "ven_id";
            this.venidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.venidDataGridViewTextBoxColumn.Name = "venidDataGridViewTextBoxColumn";
            this.venidDataGridViewTextBoxColumn.ReadOnly = true;
            this.venidDataGridViewTextBoxColumn.Width = 50;
            // 
            // vennameDataGridViewTextBoxColumn
            // 
            this.vennameDataGridViewTextBoxColumn.DataPropertyName = "ven_name";
            this.vennameDataGridViewTextBoxColumn.HeaderText = "اسم المورد";
            this.vennameDataGridViewTextBoxColumn.Name = "vennameDataGridViewTextBoxColumn";
            this.vennameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venaddressDataGridViewTextBoxColumn
            // 
            this.venaddressDataGridViewTextBoxColumn.DataPropertyName = "ven_address";
            this.venaddressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.venaddressDataGridViewTextBoxColumn.Name = "venaddressDataGridViewTextBoxColumn";
            this.venaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vennoteDataGridViewTextBoxColumn
            // 
            this.vennoteDataGridViewTextBoxColumn.DataPropertyName = "ven_note";
            this.vennoteDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.vennoteDataGridViewTextBoxColumn.Name = "vennoteDataGridViewTextBoxColumn";
            this.vennoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venbalanceDataGridViewTextBoxColumn
            // 
            this.venbalanceDataGridViewTextBoxColumn.DataPropertyName = "ven_balance";
            this.venbalanceDataGridViewTextBoxColumn.HeaderText = "الحساب";
            this.venbalanceDataGridViewTextBoxColumn.Name = "venbalanceDataGridViewTextBoxColumn";
            this.venbalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venphoneDataGridViewTextBoxColumn
            // 
            this.venphoneDataGridViewTextBoxColumn.DataPropertyName = "ven_phone";
            this.venphoneDataGridViewTextBoxColumn.HeaderText = "التليفون";
            this.venphoneDataGridViewTextBoxColumn.Name = "venphoneDataGridViewTextBoxColumn";
            this.venphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendorDtoBindingSource
            // 
            this.vendorDtoBindingSource.DataSource = typeof(POS.dto.VendorDto);
            // 
            // AllVendorSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 546);
            this.Controls.Add(this.noreText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "AllVendorSc";
            this.Text = "AllVendorSc";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AllVendorSc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox noreText;
        private System.Windows.Forms.BindingSource vendorDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn venidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vennameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vennoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venphoneDataGridViewTextBoxColumn;
    }
}