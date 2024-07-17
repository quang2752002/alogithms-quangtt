using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai4
	{
		public static void findProduct(List<Product> listProduct, string nameProduct)//bài 4 tìm kiếm sản phẩm theo tên
		{
			Console.WriteLine("San pham tim kiem theo ten la");

			foreach (Product product in listProduct)
			{
				if (product.name == nameProduct)
				{

					Program.printProduct(product);
				}
			}
		}
	}
}
