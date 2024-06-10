namespace JRsweet.UI
{
    partial class FrmSale
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
            this.nmpricesale = new System.Windows.Forms.NumericUpDown();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnamecustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproductsale = new System.Windows.Forms.TextBox();
            this.dtdatesale = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnselectcustomer = new System.Windows.Forms.Button();
            this.btnselectproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmpricesale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmpricesale
            // 
            this.nmpricesale.Location = new System.Drawing.Point(117, 149);
            this.nmpricesale.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmpricesale.Name = "nmpricesale";
            this.nmpricesale.Size = new System.Drawing.Size(289, 26);
            this.nmpricesale.TabIndex = 3;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(261, 243);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(83, 35);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(164, 243);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(79, 35);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Product";
            // 
            // txtnamecustomer
            // 
            this.txtnamecustomer.Location = new System.Drawing.Point(117, 63);
            this.txtnamecustomer.Name = "txtnamecustomer";
            this.txtnamecustomer.ReadOnly = true;
            this.txtnamecustomer.Size = new System.Drawing.Size(289, 26);
            this.txtnamecustomer.TabIndex = 1;
            this.txtnamecustomer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Customer";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(117, 20);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(289, 26);
            this.txtid.TabIndex = 0;
            this.txtid.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // txtproductsale
            // 
            this.txtproductsale.Location = new System.Drawing.Point(117, 106);
            this.txtproductsale.Name = "txtproductsale";
            this.txtproductsale.ReadOnly = true;
            this.txtproductsale.Size = new System.Drawing.Size(289, 26);
            this.txtproductsale.TabIndex = 2;
            this.txtproductsale.TabStop = false;
            // 
            // dtdatesale
            // 
            this.dtdatesale.Location = new System.Drawing.Point(117, 194);
            this.dtdatesale.Name = "dtdatesale";
            this.dtdatesale.Size = new System.Drawing.Size(289, 26);
            this.dtdatesale.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnselectcustomer
            // 
            this.btnselectcustomer.Location = new System.Drawing.Point(436, 52);
            this.btnselectcustomer.Name = "btnselectcustomer";
            this.btnselectcustomer.Size = new System.Drawing.Size(160, 37);
            this.btnselectcustomer.TabIndex = 31;
            this.btnselectcustomer.Text = "Select Customer";
            this.btnselectcustomer.UseVisualStyleBackColor = true;
            this.btnselectcustomer.Click += new System.EventHandler(this.btnselectcustomer_Click);
            // 
            // btnselectproduct
            // 
            this.btnselectproduct.Location = new System.Drawing.Point(436, 97);
            this.btnselectproduct.Name = "btnselectproduct";
            this.btnselectproduct.Size = new System.Drawing.Size(160, 35);
            this.btnselectproduct.TabIndex = 31;
            this.btnselectproduct.Text = "Select Product";
            this.btnselectproduct.UseVisualStyleBackColor = true;
            this.btnselectproduct.Click += new System.EventHandler(this.btnselectproduct_Click);
            // 
            // FrmSale
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(624, 302);
            this.Controls.Add(this.btnselectproduct);
            this.Controls.Add(this.btnselectcustomer);
            this.Controls.Add(this.dtdatesale);
            this.Controls.Add(this.nmpricesale);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnamecustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproductsale);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSale";
            ((System.ComponentModel.ISupportInitialize)(this.nmpricesale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nmpricesale;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnamecustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproductsale;
        private System.Windows.Forms.DateTimePicker dtdatesale;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnselectproduct;
        private System.Windows.Forms.Button btnselectcustomer;
    }
}