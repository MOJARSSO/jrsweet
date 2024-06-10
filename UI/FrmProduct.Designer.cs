namespace JRsweet.UI
{
    partial class FrmProduct
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtdetailproduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnameproduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcategoreproduct = new System.Windows.Forms.ComboBox();
            this.nmpriceproduct = new System.Windows.Forms.NumericUpDown();
            this.nmstockproduct = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbunitproduct = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmpriceproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmstockproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(248, 429);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(83, 35);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(151, 429);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(79, 35);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtdetailproduct
            // 
            this.txtdetailproduct.Location = new System.Drawing.Point(114, 302);
            this.txtdetailproduct.Multiline = true;
            this.txtdetailproduct.Name = "txtdetailproduct";
            this.txtdetailproduct.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdetailproduct.Size = new System.Drawing.Size(252, 106);
            this.txtdetailproduct.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categore";
            // 
            // txtnameproduct
            // 
            this.txtnameproduct.Location = new System.Drawing.Point(114, 72);
            this.txtnameproduct.Name = "txtnameproduct";
            this.txtnameproduct.Size = new System.Drawing.Size(252, 26);
            this.txtnameproduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(114, 29);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(252, 26);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // cbcategoreproduct
            // 
            this.cbcategoreproduct.FormattingEnabled = true;
            this.cbcategoreproduct.Items.AddRange(new object[] {
            "Sweet shirts",
            "T-Shirts",
            "pantanols",
            "IceCaps",
            "Socks"});
            this.cbcategoreproduct.Location = new System.Drawing.Point(114, 112);
            this.cbcategoreproduct.Name = "cbcategoreproduct";
            this.cbcategoreproduct.Size = new System.Drawing.Size(252, 28);
            this.cbcategoreproduct.TabIndex = 2;
            // 
            // nmpriceproduct
            // 
            this.nmpriceproduct.Location = new System.Drawing.Point(114, 158);
            this.nmpriceproduct.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmpriceproduct.Name = "nmpriceproduct";
            this.nmpriceproduct.Size = new System.Drawing.Size(252, 26);
            this.nmpriceproduct.TabIndex = 3;
            // 
            // nmstockproduct
            // 
            this.nmstockproduct.DecimalPlaces = 2;
            this.nmstockproduct.Location = new System.Drawing.Point(114, 204);
            this.nmstockproduct.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmstockproduct.Name = "nmstockproduct";
            this.nmstockproduct.Size = new System.Drawing.Size(252, 26);
            this.nmstockproduct.TabIndex = 4;
            this.nmstockproduct.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unit";
            // 
            // cbunitproduct
            // 
            this.cbunitproduct.FormattingEnabled = true;
            this.cbunitproduct.Items.AddRange(new object[] {
            "Pieces",
            "Model",
            "KG"});
            this.cbunitproduct.Location = new System.Drawing.Point(114, 249);
            this.cbunitproduct.Name = "cbunitproduct";
            this.cbunitproduct.Size = new System.Drawing.Size(252, 28);
            this.cbunitproduct.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProduct
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(438, 519);
            this.Controls.Add(this.nmstockproduct);
            this.Controls.Add(this.nmpriceproduct);
            this.Controls.Add(this.cbunitproduct);
            this.Controls.Add(this.cbcategoreproduct);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtdetailproduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnameproduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmpriceproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmstockproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtdetailproduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnameproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcategoreproduct;
        private System.Windows.Forms.NumericUpDown nmpriceproduct;
        private System.Windows.Forms.NumericUpDown nmstockproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbunitproduct;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}