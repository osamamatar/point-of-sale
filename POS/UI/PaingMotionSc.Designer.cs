namespace POS.UI
{
    partial class PaingMotionSc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cاسمالعميلDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cالقيمةالمسددهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cاسمالمحصلDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cملاحظاتDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cتاريخالدفعDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getCustPayingResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.اسمالموردDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.القيمةالمسددةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cاسمالمحصلDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cملاحظاتDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاريخالدفعDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getVendPayingResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustPayingResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getVendPayingResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cاسمالعميلDataGridViewTextBoxColumn,
            this.cالقيمةالمسددهDataGridViewTextBoxColumn,
            this.cاسمالمحصلDataGridViewTextBoxColumn,
            this.cملاحظاتDataGridViewTextBoxColumn,
            this.cتاريخالدفعDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getCustPayingResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(721, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "C_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "رقم العميل";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Width = 113;
            // 
            // cاسمالعميلDataGridViewTextBoxColumn
            // 
            this.cاسمالعميلDataGridViewTextBoxColumn.DataPropertyName = "C_اسم_العميل";
            this.cاسمالعميلDataGridViewTextBoxColumn.HeaderText = "اسم_العميل";
            this.cاسمالعميلDataGridViewTextBoxColumn.Name = "cاسمالعميلDataGridViewTextBoxColumn";
            this.cاسمالعميلDataGridViewTextBoxColumn.Width = 113;
            // 
            // cالقيمةالمسددهDataGridViewTextBoxColumn
            // 
            this.cالقيمةالمسددهDataGridViewTextBoxColumn.DataPropertyName = "C_القيمة_المسدده";
            this.cالقيمةالمسددهDataGridViewTextBoxColumn.HeaderText = "القيمة_المسدده";
            this.cالقيمةالمسددهDataGridViewTextBoxColumn.Name = "cالقيمةالمسددهDataGridViewTextBoxColumn";
            this.cالقيمةالمسددهDataGridViewTextBoxColumn.Width = 113;
            // 
            // cاسمالمحصلDataGridViewTextBoxColumn
            // 
            this.cاسمالمحصلDataGridViewTextBoxColumn.DataPropertyName = "C_اسم_المحصل";
            this.cاسمالمحصلDataGridViewTextBoxColumn.HeaderText = "اسم_المحصل";
            this.cاسمالمحصلDataGridViewTextBoxColumn.Name = "cاسمالمحصلDataGridViewTextBoxColumn";
            this.cاسمالمحصلDataGridViewTextBoxColumn.Width = 113;
            // 
            // cملاحظاتDataGridViewTextBoxColumn
            // 
            this.cملاحظاتDataGridViewTextBoxColumn.DataPropertyName = "C_ملاحظات";
            this.cملاحظاتDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.cملاحظاتDataGridViewTextBoxColumn.Name = "cملاحظاتDataGridViewTextBoxColumn";
            this.cملاحظاتDataGridViewTextBoxColumn.Width = 113;
            // 
            // cتاريخالدفعDataGridViewTextBoxColumn
            // 
            this.cتاريخالدفعDataGridViewTextBoxColumn.DataPropertyName = "C_تاريخ_الدفع";
            this.cتاريخالدفعDataGridViewTextBoxColumn.HeaderText = "تاريخ_الدفع";
            this.cتاريخالدفعDataGridViewTextBoxColumn.Name = "cتاريخالدفعDataGridViewTextBoxColumn";
            this.cتاريخالدفعDataGridViewTextBoxColumn.Width = 113;
            // 
            // getCustPayingResultBindingSource
            // 
            this.getCustPayingResultBindingSource.DataSource = typeof(POS.DB.getCustPaying_Result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "العملاء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "الموردين";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.اسمالموردDataGridViewTextBoxColumn,
            this.القيمةالمسددةDataGridViewTextBoxColumn,
            this.cاسمالمحصلDataGridViewTextBoxColumn1,
            this.cملاحظاتDataGridViewTextBoxColumn1,
            this.تاريخالدفعDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.getVendPayingResultBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 279);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(721, 197);
            this.dataGridView2.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "رقم المورد";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 113;
            // 
            // اسمالموردDataGridViewTextBoxColumn
            // 
            this.اسمالموردDataGridViewTextBoxColumn.DataPropertyName = "اسم_المورد";
            this.اسمالموردDataGridViewTextBoxColumn.HeaderText = "اسم_المورد";
            this.اسمالموردDataGridViewTextBoxColumn.Name = "اسمالموردDataGridViewTextBoxColumn";
            this.اسمالموردDataGridViewTextBoxColumn.Width = 113;
            // 
            // القيمةالمسددةDataGridViewTextBoxColumn
            // 
            this.القيمةالمسددةDataGridViewTextBoxColumn.DataPropertyName = "القيمة_المسددة";
            this.القيمةالمسددةDataGridViewTextBoxColumn.HeaderText = "القيمة_المسددة";
            this.القيمةالمسددةDataGridViewTextBoxColumn.Name = "القيمةالمسددةDataGridViewTextBoxColumn";
            this.القيمةالمسددةDataGridViewTextBoxColumn.Width = 113;
            // 
            // cاسمالمحصلDataGridViewTextBoxColumn1
            // 
            this.cاسمالمحصلDataGridViewTextBoxColumn1.DataPropertyName = "C_اسم_المحصل";
            this.cاسمالمحصلDataGridViewTextBoxColumn1.HeaderText = "اسم_المحصل";
            this.cاسمالمحصلDataGridViewTextBoxColumn1.Name = "cاسمالمحصلDataGridViewTextBoxColumn1";
            this.cاسمالمحصلDataGridViewTextBoxColumn1.Width = 113;
            // 
            // cملاحظاتDataGridViewTextBoxColumn1
            // 
            this.cملاحظاتDataGridViewTextBoxColumn1.DataPropertyName = "C_ملاحظات";
            this.cملاحظاتDataGridViewTextBoxColumn1.HeaderText = "ملاحظات";
            this.cملاحظاتDataGridViewTextBoxColumn1.Name = "cملاحظاتDataGridViewTextBoxColumn1";
            this.cملاحظاتDataGridViewTextBoxColumn1.Width = 113;
            // 
            // تاريخالدفعDataGridViewTextBoxColumn
            // 
            this.تاريخالدفعDataGridViewTextBoxColumn.DataPropertyName = "تاريخ_الدفع";
            this.تاريخالدفعDataGridViewTextBoxColumn.HeaderText = "تاريخ_الدفع";
            this.تاريخالدفعDataGridViewTextBoxColumn.Name = "تاريخالدفعDataGridViewTextBoxColumn";
            this.تاريخالدفعDataGridViewTextBoxColumn.Width = 113;
            // 
            // getVendPayingResultBindingSource
            // 
            this.getVendPayingResultBindingSource.DataSource = typeof(POS.DB.getVendPaying_Result);
            // 
            // PaingMotionSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(754, 507);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaingMotionSc";
            this.Text = "حركة السداد";
            this.Load += new System.EventHandler(this.PaingMotionSc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustPayingResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getVendPayingResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cاسمالعميلDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cالقيمةالمسددهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cاسمالمحصلDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cملاحظاتDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cتاريخالدفعDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getCustPayingResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn اسمالموردDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn القيمةالمسددةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cاسمالمحصلDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cملاحظاتDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاريخالدفعDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getVendPayingResultBindingSource;
    }
}