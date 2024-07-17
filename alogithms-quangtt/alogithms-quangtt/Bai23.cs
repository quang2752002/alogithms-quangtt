using alogithms_quangtt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai23
	{
		public static void PrintMenu(List<Menu> menus, int parentId, int level)//in menu đa cấp
		{
			
			foreach (var menu in menus.Where(m => m.parentId == parentId))
			{
				Console.WriteLine(new string('-', level * 2) + menu.title);
				PrintMenu(menus, menu.id, level + 1);
			}
		}
	}
}
