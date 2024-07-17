using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt.Entity
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public Category() { }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
