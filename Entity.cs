using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRsweet
{
    public class Customer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }

    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Categore { get; set; }
        public double Price { get; set; }
        public double Stock { get; set; }
        public string Unit { get; set; }
        public string Detail { get; set; }

        public override string ToString()
        {
            return $"{Name} {Detail}";
        }

    }

    public class Sales
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid ProductID { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }


    }
    public class Payment
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public string Explanation { get; set; }

    }
}

