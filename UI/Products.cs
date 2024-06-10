using JRsweet.BL;
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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            FrmProduct frmproduct = new FrmProduct()
            {
                Text = "Add Customer",
                Product = new Product() { ID = Guid.NewGuid() },
            };

            var sonuc = frmproduct.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.AddProduct(frmproduct.Product);
                if (b)
                {
                    DataSet ds = BLogic.BringProduct("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }



            }
        }

        private void btnfindproduct_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.BringProduct(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btneditproduct_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmProduct frmproduct = new FrmProduct()
            {
                Text = "Update Product",
                Update = true,
                Product = new Product()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Name = row.Cells[1].Value.ToString(),
                    Categore = row.Cells[2].Value.ToString(),
                    Price = double.Parse(row.Cells[3].Value.ToString()),
                    Stock = double.Parse(row.Cells[4].Value.ToString()),
                    Unit = row.Cells[5].Value.ToString(),
                    Detail = row.Cells[5].Value.ToString(),
                },
            };

            var sonuc = frmproduct.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UpdateProduct(frmproduct.Product);
                if (b)
                {

                    row.Cells[1].Value = frmproduct.Product.Name;
                    row.Cells[2].Value = frmproduct.Product.Categore;
                    row.Cells[3].Value = frmproduct.Product.Price;
                    row.Cells[4].Value = frmproduct.Product.Stock;
                    row.Cells[5].Value = frmproduct.Product.Unit;
                    row.Cells[5].Value = frmproduct.Product.Detail;
                }



            }

        }

        private void btndeleteproduct_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Delete the selected Register?", "Yes delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.DeleteProduct(ID);

                if (b)
                {
                    DataSet ds = BLogic.BringProduct("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }



            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.BringProduct("");
            dataGridView2.DataSource = ds2.Tables[0];
        }

        public Product Product { get; set; }
        private void btnok_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            

                Product = new Product()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Name = row.Cells[1].Value.ToString(),
                    Categore = row.Cells[2].Value.ToString(),
                    Price = double.Parse(row.Cells[3].Value.ToString()),
                    Stock = double.Parse(row.Cells[4].Value.ToString()),
                    Unit = row.Cells[5].Value.ToString(),
                    Detail = row.Cells[5].Value.ToString(),
                };
            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
