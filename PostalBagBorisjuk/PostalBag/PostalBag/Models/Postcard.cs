using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalBag.Models
{
    class Postcard : Consignment
    {
        public string Sender { get; set; }
        
        public Postcard(double price, string recepient, string sender) : base(price, recepient)
        {
            Sender = sender;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
