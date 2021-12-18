using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalBag.Models
{
    class Letter : Consignment
    {
        public double Price { get; set; }
        public bool Registered { get; set; }
        public string Sender { get; set; }

        public Letter(double price, string recipient, bool registered, string sender) : base(price, recipient)
        {
            Registered = registered;
            Sender = sender;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
