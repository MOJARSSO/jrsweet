using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JRsweet.UI
{
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public Sales Sales { get; set; }
        internal Sale Sale { get; private set; }

        private void btncancel_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (nmpricesale.Value == 0)
            {
                errorProvider1.SetError(nmpricesale, "Please Enter The Price");
                nmpricesale.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmpricesale, "");
            }
            
            Sales.Date = dtdatesale.Value;
            Sales.Price = (double)nmpricesale.Value;
            DialogResult = DialogResult.OK;
            Sales.ProductID = Product.ID;
            Sales.CustomerID = Customer.ID;
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            FrmSale frm = new FrmSale()
            {
                Text = "Satış Yap",
                Sale = new Sale()
                {
                    ID = Guid.NewGuid()
                }
            };
        }

        private void btnselectcustomer_Click(object sender, EventArgs e)
        {
            Customers frm = new Customers();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Customer = frm.Customer;
                txtnamecustomer.Text = Customer.ToString();
               

            }
        }

        private void btnselectproduct_Click(object sender, EventArgs e)
        {
            Products frm = new Products();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Product = frm.Product;
                txtproductsale.Text = Product.ToString();
            }
        }

        
        public void HandleSalesIDNull()
        {
            JRsweet.UI.FrmSale sale = new JRsweet.UI.FrmSale();

            // Check if the Sales property is not null before accessing the ID
            if (sale.Sales != null && sale.Sales.ID != null)
            {
                
            }
            else
            {
                // The Sales.ID property is null
                Console.WriteLine("Sales ID is null.");
            }
        }

    }
}
