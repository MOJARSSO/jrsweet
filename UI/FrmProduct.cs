using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRsweet.UI
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Product Product { get; set; }
        public bool Update { get; set; } = false;

        private void btnok_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtnameproduct)) return;
            if (!ErrorControl(cbcategoreproduct)) return;
            if (!ErrorControl(nmpriceproduct)) return;
            if (!ErrorControl(nmstockproduct)) return;
            if (!ErrorControl(cbunitproduct)) return;
            if (!ErrorControl(txtdetailproduct)) return;


            Product.Name = txtnameproduct.Text;
            Product.Categore = cbcategoreproduct.Text;
            Product.Price = (double)nmpriceproduct.Value;
            Product.Stock = (double)nmstockproduct.Value;
            Product.Unit = cbunitproduct.Text;
            Product.Detail = txtdetailproduct.Text;
            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Incomplete or wrong information");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }


            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Incomplete or wrong information");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }


            }
            return true;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            txtid.Text = Product.ID.ToString();
            if (Update)
            {
                  txtnameproduct.Text = Product.Name;
                  cbcategoreproduct.Text = Product.Categore;
                  nmpriceproduct.Value = (decimal)Product.Price; 
                  nmstockproduct.Value = (decimal)Product.Stock;
                  cbunitproduct.Text = Product.Unit;
                  txtdetailproduct.Text =  Product.Detail;
            }
        }
    }
}
