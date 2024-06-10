namespace JRsweet.UI
{
    partial class FrmPayment
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
            this.dtdatepayment = new System.Windows.Forms.DateTimePicker();
            this.nmamountpayment = new System.Windows.Forms.NumericUpDown();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnamecustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdetailproduct = new System.Windows.Forms.TextBox();
            this.txtexplanationpay = new System.Windows.Forms.Label();
            this.cbpaymenttype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmamountpayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtdatepayment
            // 
            this.dtdatepayment.Location = new System.Drawing.Point(135, 110);
            this.dtdatepayment.Name = "dtdatepayment";
            this.dtdatepayment.Size = new System.Drawing.Size(265, 26);
            this.dtdatepayment.TabIndex = 2;
            // 
            // nmamountpayment
            // 
            this.nmamountpayment.Location = new System.Drawing.Point(135, 151);
            this.nmamountpayment.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmamountpayment.Name = "nmamountpayment";
            this.nmamountpayment.Size = new System.Drawing.Size(265, 26);
            this.nmamountpayment.TabIndex = 3;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(317, 374);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(83, 35);
            this.btncancel.TabIndex = 37;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(220, 374);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(79, 35);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Amount";
            // 
            // txtnamecustomer
            // 
            this.txtnamecustomer.Location = new System.Drawing.Point(135, 65);
            this.txtnamecustomer.Name = "txtnamecustomer";
            this.txtnamecustomer.ReadOnly = true;
            this.txtnamecustomer.Size = new System.Drawing.Size(265, 26);
            this.txtnamecustomer.TabIndex = 1;
            this.txtnamecustomer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Customer";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(135, 22);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(265, 26);
            this.txtid.TabIndex = 0;
            this.txtid.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // txtdetailproduct
            // 
            this.txtdetailproduct.Location = new System.Drawing.Point(135, 242);
            this.txtdetailproduct.Multiline = true;
            this.txtdetailproduct.Name = "txtdetailproduct";
            this.txtdetailproduct.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdetailproduct.Size = new System.Drawing.Size(265, 106);
            this.txtdetailproduct.TabIndex = 5;
            // 
            // txtexplanationpay
            // 
            this.txtexplanationpay.AutoSize = true;
            this.txtexplanationpay.Location = new System.Drawing.Point(37, 245);
            this.txtexplanationpay.Name = "txtexplanationpay";
            this.txtexplanationpay.Size = new System.Drawing.Size(92, 20);
            this.txtexplanationpay.TabIndex = 44;
            this.txtexplanationpay.Text = "Explanation";
            // 
            // cbpaymenttype
            // 
            this.cbpaymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpaymenttype.FormattingEnabled = true;
            this.cbpaymenttype.Items.AddRange(new object[] {
            "Cash",
            "Credit card",
            "Exchange"});
            this.cbpaymenttype.Location = new System.Drawing.Point(135, 194);
            this.cbpaymenttype.Name = "cbpaymenttype";
            this.cbpaymenttype.Size = new System.Drawing.Size(265, 28);
            this.cbpaymenttype.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Payment Type";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPayment
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(437, 441);
            this.Controls.Add(this.cbpaymenttype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdetailproduct);
            this.Controls.Add(this.txtexplanationpay);
            this.Controls.Add(this.dtdatepayment);
            this.Controls.Add(this.nmamountpayment);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnamecustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPayment";
            ((System.ComponentModel.ISupportInitialize)(this.nmamountpayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtdatepayment;
        private System.Windows.Forms.NumericUpDown nmamountpayment;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnamecustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdetailproduct;
        private System.Windows.Forms.Label txtexplanationpay;
        private System.Windows.Forms.ComboBox cbpaymenttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}