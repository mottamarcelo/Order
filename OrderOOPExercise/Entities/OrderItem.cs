using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public double SubTotal() 
        { 
            return Quantity * Price; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", $");
            sb.Append(Price);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal());
            return sb.ToString();
        }
    }
}
