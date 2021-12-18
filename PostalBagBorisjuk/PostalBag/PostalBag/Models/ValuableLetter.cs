using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalBag.Models
{
    class ValuableLetter : Letter, IValuable
    {
        public double Price { get; set }
        public double Value { get; set; }

        public ValuableLetter(double price, string recipient, bool registered, string sender, double value) : base(price, recipient, registered, sender)
        {
            Value = value;
        }
        public override string ToString()
        {
            return base.ToString() + "To:" + Sender + "Price:" + Price + "Value:" + Value;
        }
    }
}
