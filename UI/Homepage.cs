using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRsweet.UI;
using JRsweet.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JRsweet
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        Customers mf = new Customers();
        Products uf = new Products();

        public  Sales Sales { get; set; }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void btnbuynow_Click(object sender, EventArgs e)
        {
            FrmSale frm = new FrmSale();
            {
                Sales = new Sales()
                {

                    ID = Guid.NewGuid()
                };
                


            }
        }

        
    }
}
