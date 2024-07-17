using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace alogithms_quangtt.Entity
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int quality { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public Product() { }
        public Product(string name, int price, int quality, int categoryId)
        {
            this.name = name;
            this.price = price;
            this.quality = quality;
            this.categoryId = categoryId;
        }

    }
}
