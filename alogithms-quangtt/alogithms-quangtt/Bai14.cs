using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai14
	{
		public static void mapProductByCategory(List<Product> listProduct, List<Category> listCategory)//bài 14 trả về danh sách product có chứa tên category tương ứng theo categoryId

		{
			Console.WriteLine("Danh sach san pham co ten danh muc la ");

			foreach (Product product in listProduct)
			{
				foreach (Category category in listCategory)
				{
					if (product.categoryId == category.id)
					{
						Console.WriteLine(product.name + " " + product.price + " " + product.quality + " " + category.name);
					}
				}
			}
		}

	}
}
