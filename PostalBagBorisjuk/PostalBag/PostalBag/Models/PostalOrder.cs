using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalBag.Models
{
    class PostalOrder : IValuable
    {
        public double Value { get; set; }
        public string Recepient { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
