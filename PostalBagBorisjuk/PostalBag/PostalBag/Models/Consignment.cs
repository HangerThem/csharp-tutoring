using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalBag.Models
{
    public abstract class Consignment
    {
        public double Price { get; set; }
        public string Recipient { get; set; }

        public Consignment(double price, string recepient)
        {
            Price = price;
            Recipient = recepient;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
