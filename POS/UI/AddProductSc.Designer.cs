namespace POS.UI
{
    partial class AddProductSc
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorText = new System.Windows.Forms.TextBox();
            this.brandText = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.quntInput = new System.Windows.Forms.NumericUpDown();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.costInput = new System.Windows.Forms.NumericUpDown();
            this.catText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endPriceInput = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "أسم المنتج";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "اللون";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "اضافة  منتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "الماركة";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // colorText
            // 
            this.colorText.Location = new System.Drawing.Point(482, 217);
            this.colorText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(220, 26);
            this.colorText.TabIndex = 20;
            // 
            // brandText
            // 
            this.brandText.Location = new System.Drawing.Point(482, 158);
            this.brandText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.brandText.Name = "brandText";
            this.brandText.Size = new System.Drawing.Size(220, 26);
            this.brandText.TabIndex = 19;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(482, 103);
            this.nametext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(220, 26);
            this.nametext.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(75, 345);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 54);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // quntInput
            // 
            this.quntInput.Location = new System.Drawing.Point(75, 103);
            this.quntInput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.quntInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.quntInput.Name = "quntInput";
            this.quntInput.Size = new System.Drawing.Size(180, 26);
            this.quntInput.TabIndex = 27;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(75, 218);
            this.priceInput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.priceInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(180, 26);
            this.priceInput.TabIndex = 28;
            // 
            // costInput
            // 
            this.costInput.Location = new System.Drawing.Point(75, 163);
            this.costInput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.costInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(180, 26);
            this.costInput.TabIndex = 29;
            // 
            // catText
            // 
            this.catText.FormattingEnabled = true;
            this.catText.Location = new System.Drawing.Point(482, 277);
            this.catText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.catText.Name = "catText";
            this.catText.Size = new System.Drawing.Size(220, 28);
            this.catText.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "الكمية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "سعر البيع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "سعر الشراء";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "سعر البيع النهائي";
            // 
            // endPriceInput
            // 
            this.endPriceInput.Location = new System.Drawing.Point(75, 274);
            this.endPriceInput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.endPriceInput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.endPriceInput.Name = "endPriceInput";
            this.endPriceInput.Size = new System.Drawing.Size(180, 26);
            this.endPriceInput.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(771, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "الصنف";
            // 
            // dateTimeInput
            // 
            this.dateTimeInput.Location = new System.Drawing.Point(313, 352);
            this.dateTimeInput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(298, 26);
            this.dateTimeInput.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 352);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "تاريخ انتهاء الصلاحية";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AddProductSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 471);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.endPriceInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catText);
            this.Controls.Add(this.costInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.quntInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorText);
            this.Controls.Add(this.brandText);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddProductSc";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddProductSc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colorText;
        private System.Windows.Forms.TextBox brandText;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown quntInput;
        private System.Windows.Forms.NumericUpDown priceInput;
        private System.Windows.Forms.ComboBox catText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown endPriceInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown costInput;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}