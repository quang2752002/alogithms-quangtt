using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai11
	{
		public static List<Product> sortByPrice(List<Product> listProduct)//bài 11  danh sách sản phẩm sắp xếp theo giá từ thấp đến cao
		{

			for (int i = 0; i < listProduct.Count; i++)
			{

				for (int j = 0; j < listProduct.Count - 1 - i; j++)
				{
					if (listProduct[j].price > listProduct[j + 1].price)
					{
						Product product = new Product();
						product = listProduct[j];
						listProduct[j] = listProduct[j + 1];
						listProduct[j + 1] = product;

					}
				}

			}

			return listProduct;
		}
		public static void printSortByPrice(List<Product> listProduct)//In danh sách sản phẩm sắp xếp theo giá từ thấp đến cao
		{
			Console.WriteLine("Danh sach san pham sap xep gia tu thap den cao");
			sortByPrice(listProduct);

			Program.printListProduct(listProduct);
		}

	}
}
