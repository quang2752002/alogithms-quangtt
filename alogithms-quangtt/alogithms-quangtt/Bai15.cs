using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai15
	{
		public static void minByPrice(List<Product> listProduct)//bài 15 trả về  product có giá nhỏ nhất
		{
			Bai11.sortByPrice(listProduct);
			Product product = listProduct[0];
			Console.WriteLine("San pham co gia tri nho nhat");
			Program.printProduct(product);
		}

	}
}
