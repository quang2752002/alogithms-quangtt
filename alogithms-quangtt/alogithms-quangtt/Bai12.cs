using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
    public class Bai12
    {
		public static void SortByName(List<Product> listProduct)// bài 12 Danh sach san pham sap xep theo đo dai cua ten tu cao đen thap
		{

			int n = listProduct.Count;


			for (int i = 1; i < n; i++)
			{
				Product key = listProduct[i];
				int keyLength = key.name.Length;
				int j = i - 1;


				while (j >= 0 && listProduct[j].name.Length < keyLength)
				{
					listProduct[j + 1] = listProduct[j];
					j--;
				}
				listProduct[j + 1] = key;
			}
			Console.WriteLine("Danh sach san pham sap xep theo đo dai cua ten tu cao đen thap");

			Program.printListProduct(listProduct);
		}

	}
}
