using alogithms_quangtt.Entity;
using dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai13
	{
		public static void SortByCategoryName(List<Product> listProduct, List<Category> listCategory)// bài 13 trả về danh sách product sắp xếp theo category name theo thứ tự abc. 
		{
			Dictionary<int, string> categoryMap = new Dictionary<int, string>();
			foreach (var category in listCategory)
			{
				categoryMap[category.id] = category.name;
			}

			for (int i = 1; i < listProduct.Count; i++)
			{
				Product keyProduct = listProduct[i];
				int j = i - 1;

				while (j >= 0 && String.Compare(categoryMap[keyProduct.categoryId], categoryMap[listProduct[j].categoryId], StringComparison.InvariantCultureIgnoreCase) < 0)
				{
					listProduct[j + 1] = listProduct[j];
					j--;
				}
				listProduct[j + 1] = keyProduct;
			}

			Program.printListProduct(listProduct);
		}

	}
}
