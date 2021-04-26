namespace POS.UI
{
    partial class VendorLateSc
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ven_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vennameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "الاجمالي";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ven_id,
            this.vennameDataGridViewTextBoxColumn,
            this.venbalanceDataGridViewTextBoxColumn,
            this.venphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendorDtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(464, 256);
            this.dataGridView1.TabIndex = 5;
            // 
            // ven_id
            // 
            this.ven_id.DataPropertyName = "ven_id";
            this.ven_id.HeaderText = "id";
            this.ven_id.Name = "ven_id";
            this.ven_id.ReadOnly = true;
            // 
            // vennameDataGridViewTextBoxColumn
            // 
            this.vennameDataGridViewTextBoxColumn.DataPropertyName = "ven_name";
            this.vennameDataGridViewTextBoxColumn.HeaderText = "اسم المورد";
            this.vennameDataGridViewTextBoxColumn.Name = "vennameDataGridViewTextBoxColumn";
            this.vennameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venbalanceDataGridViewTextBoxColumn
            // 
            this.venbalanceDataGridViewTextBoxColumn.DataPropertyName = "ven_balance";
            this.venbalanceDataGridViewTextBoxColumn.HeaderText = "الحساب الصافي";
            this.venbalanceDataGridViewTextBoxColumn.Name = "venbalanceDataGridViewTextBoxColumn";
            this.venbalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venphoneDataGridViewTextBoxColumn
            // 
            this.venphoneDataGridViewTextBoxColumn.DataPropertyName = "ven_phone";
            this.venphoneDataGridViewTextBoxColumn.HeaderText = "رقم الهاتف";
            this.venphoneDataGridViewTextBoxColumn.Name = "venphoneDataGridViewTextBoxColumn";
            this.venphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendorDtoBindingSource
            // 
            this.vendorDtoBindingSource.DataSource = typeof(POS.dto.VendorDto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "متأخرات الموردين";
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.LightGreen;
            this.printBtn.Location = new System.Drawing.Point(12, 349);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(90, 51);
            this.printBtn.TabIndex = 8;
            this.printBtn.Text = "طباعة";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(148, 360);
            this.total.Multiline = true;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(81, 34);
            this.total.TabIndex = 9;
            this.total.Text = "0";
            // 
            // VendorLateSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(497, 411);
            this.Controls.Add(this.total);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "VendorLateSc";
            this.Text = "VendorLateSc";
            this.Load += new System.EventHandler(this.VendorLateSc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vennameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vendorDtoBindingSource;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.TextBox total;
    }
}