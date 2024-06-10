using JRsweet.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRsweet.BL
{
    public static class BLogic
    {
        public static bool AddCustomer(Customer n)
        {
            try
            {
                int res = DataLayer.AddCustomer(n);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return false;
            }
        }

        internal static bool AddProduct(Product u)
        {
            try
            {
                int res = DataLayer.AddProduct(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return false;
            }
        }

        internal static bool AddSales(Sales s)
        {
            try
            {
                int res = DataLayer.AddSales(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet BringCustomer(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.BringCustomer(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return null;
            }
        }

        internal static DataSet BringProduct(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.BringProduct(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return null;
            }
        }

        internal static bool DeleteCustomer(string id)
        {
            try
            {
                int res = DataLayer.DeleteCustomer(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return false;
            }
        }

        internal static bool DeleteProduct(string id)
        {
            try
            {
                int res = DataLayer.DeleteProduct(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return false;
            }
        }

        

        internal static bool UpdateCustomer(Customer n)
        {
            try
            {
                int res = DataLayer.UpdateCustomer(n);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return false;
            }
        }

        internal static bool UpdateProduct(Product u)
        {
            try
            {
                int res = DataLayer.UpdateProduct(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olustu:" + ex.Message);
                return false;
            }
        }
    }
}
