using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRsweet.UI
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        public Customer Customer { get; set; }
        public bool Update { get; set; } = false;
        private void btnok_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtname)) return;
            if (!ErrorControl(txtsur)) return;
            if (!ErrorControl(txttel)) return;
            if (!ErrorControl(txtemail)) return;
            if (!ErrorControl(txtemail)) return;


            Customer.Name = txtname.Text;
            Customer.Surname = txtsur.Text;
            Customer.Telefon = txttel.Text;
            Customer.Email = txtemail.Text;
            Customer.Addres = txtaddres.Text;


            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            

            DialogResult = DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            txtid.Text = Customer.ID.ToString();
            if (Update)
            {
                  txtname.Text = Customer.Name;
                  txtsur.Text = Customer.Surname;
                  txttel.Text = Customer.Telefon;
                  txtemail.Text = Customer.Email;
                  txtaddres.Text = Customer.Addres;
            }
        }
    }
}
