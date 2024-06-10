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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer()
            {
                Text = "Add Customer",
                Customer = new Customer() { ID = Guid.NewGuid() },
            };

            var sonuc = frmCustomer.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.AddCustomer(frmCustomer.Customer);
                if (b)
                {
                    DataSet ds = BLogic.BringCustomer("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }



            }
        }

        private void btneditcustomer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmCustomer frmCustomer = new FrmCustomer()
            {
                Text = "Update Customer",
                Update = true,
                Customer = new Customer()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Name = row.Cells[1].Value.ToString(),
                    Surname = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Email = row.Cells[4].Value.ToString(),
                    Addres = row.Cells[5].Value.ToString(),
                },
            };

            var sonuc = frmCustomer.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UpdateCustomer(frmCustomer.Customer);
                if (b)
                {

                    row.Cells[1].Value = frmCustomer.Customer.Name;
                    row.Cells[2].Value = frmCustomer.Customer.Surname;
                    row.Cells[3].Value = frmCustomer.Customer.Telefon;
                    row.Cells[4].Value = frmCustomer.Customer.Email;
                    row.Cells[5].Value = frmCustomer.Customer.Addres;
                }



            }
        }

        private void btnfindcustomer_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.BringCustomer(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btndeletecustomer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Delete the selected Register?", "Yes delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.DeleteCustomer(ID);

                if (b)
                {
                    DataSet ds = BLogic.BringCustomer("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }



            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.BringCustomer("");
            dataGridView1.DataSource = ds1.Tables[0];
        }

        public Customer Customer { get; set; }
        private void btnok_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];


            Customer = new Customer()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Name = row.Cells[1].Value.ToString(),
                Surname = row.Cells[2].Value.ToString(),
                Telefon = row.Cells[3].Value.ToString(),
                Email = row.Cells[4].Value.ToString(),
                Addres = row.Cells[5].Value.ToString(),
            };
            

            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
