using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai16
	{
		public static void maxByPrice(List<Product> listProduct)//bài 16 trả về  product có giá lớn nhất
		{
			Bai11.sortByPrice(listProduct);
			Product product = listProduct[listProduct.Count - 1];
			Console.WriteLine("San pham co gia tri lon nhat");
			Program.printProduct(product);
		}

	}
}
