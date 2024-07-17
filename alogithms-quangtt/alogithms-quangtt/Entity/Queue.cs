using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt.Entity
{
    public class Queue<Product>
    {
        private List<Product> items;

        public Queue()
        {
            items = new List<Product>();
        }

        public void Push(Product item)
        {
            items.Add(item);
        }

        public Product Get()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            Product item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}
