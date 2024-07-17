using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt.Entity
{
    public class Stack<Product>
    {
        private List<Product> items;

        public Stack()
        {
            items = new List<Product>();
        }

        public void Push(Product item)// Thêm sản phẩm vào đầu stack
        {
            items.Insert(0, item);
        }

        public Product Get()//lấy sản phẩm vào  trong stack
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            Product item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public bool IsEmpty()//kiểm tra stack rỗng
        {
            return items.Count == 0;
        }
    }

}
