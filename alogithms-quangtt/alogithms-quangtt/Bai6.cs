using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai6
	{
		public static void findProductByPrice(List<Product> listProduct, int price)//bài 6  danh sách sản phẩm danh sách  có giá <= price truyền vào
		{
			List<Product> result = new List<Product>();
			foreach (Product product in listProduct)
			{
				if (product.price <= price)
				{
					result.Add(product);
				}
			}
			Console.WriteLine("Danh sach san pham co gia nho hon hoac bang gia truyen vao ");
			Program.printListProduct(result);

		}

	}
}
