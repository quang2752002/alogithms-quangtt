using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt.Entity
{
    public class Menu
    {
        public int id { get; set; }
        public string title { get; set; }
        public int parentId { get; set; }
        public Menu(int id,string title, int parentId) 
        {
            this.id = id;
            this.title = title;
            this.parentId = parentId;
        }
    }
}
