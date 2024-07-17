using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai5
	{
		public static void findProductByCategory(List<Product> listProduct, int categoryId)//bài 5 tìm kiếm danh sách sản phẩm theo categoryId
		{
			List<Product> result = new List<Product>();
			foreach (Product product in listProduct)
			{
				if (product.categoryId == categoryId)
				{
					result.Add(product);
				}
			}
			Console.WriteLine("Danh sach san pham co danh muc can tim la ");
			Program.printListProduct(result);
		}

	}
}
