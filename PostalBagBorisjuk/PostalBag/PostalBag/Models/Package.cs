using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalBag.Models
{
    class Package : Consignment
    {
        public double Price { get; set; }
        public bool Registered { get; set; }
        public string Sender { get; set; }
        public double Weight { get; set; }

        public Package(double price, string recipient, bool registered, string sender, double weight) : base(price, recipient)
        {
            Registered = registered;
            Sender = sender;
            Weight = weight;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
