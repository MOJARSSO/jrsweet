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
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Payment Payment { get; set; }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (nmamountpayment.Value == 0)
            {
                errorProvider1.SetError(nmamountpayment, "Please Enter The Amount");
                nmamountpayment.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmamountpayment, "");
            }

            if (cbpaymenttype.SelectedItem == null)
            {
                errorProvider1.SetError(cbpaymenttype, "Choose The Payment Type");
                cbpaymenttype.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbpaymenttype, "");
                
            }

            if (txtexplanationpay.Text == "")
            {
                errorProvider1.SetError(txtexplanationpay, "Incomplete or wrong information");
                txtexplanationpay.Focus();
                return ;
            }
            else
            {
                errorProvider1.SetError(txtexplanationpay, "");
                
            }

            Payment.Type = cbpaymenttype.SelectedItem.ToString();
            Payment.Amount = (double)nmamountpayment.Value;
            Payment.Explanation = txtexplanationpay.Text;
            Payment.Date = dtdatepayment.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
