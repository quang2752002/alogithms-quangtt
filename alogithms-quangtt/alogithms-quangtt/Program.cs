using alogithms_quangtt;
using alogithms_quangtt.Entity;
using System;
namespace dao
{
	class Program
	{
		public static void printProduct(Product product)
		{
			Console.WriteLine(product.name + " " + product.price + " " + product.quality + " " + product.categoryId);
		}
		public static void printListProduct(List<Product> ListProduct)
		{
			foreach (Product product in ListProduct)
			{
				printProduct(product);
			}
		}
		public static void Main(string[] args)
		{
			List<Product> listProduct = new List<Product>
		{
			new Product("CPU", 750, 10, 1),
			new Product("RAM", 50, 2, 2),
			new Product("HDD", 70, 1, 2),
			new Product("Main", 400, 3, 1),
			new Product("Keyboard", 30, 8, 4),
			new Product("Mouse", 25, 50, 4),
			new Product("VGA", 60, 35, 3),
			new Product("Monitor", 120, 28, 2),
			new Product("Case", 120, 28, 4),
		};
			List<Category> listCategory = new List<Category>
			{

			new Category( 1, "Comuter"),
			new Category( 2, "Memory" ),
			new Category( 3, "Card"),
			new Category( 4, "Acsesory"),
			};

			Bai4.findProduct(listProduct, "CPU"); //tìm kiếm sản phẩm theo tên
			Bai5.findProductByCategory(listProduct, 1); //tìm kiếm danh sách sản phẩm theo categoryId
			Bai6.findProductByPrice(listProduct, 30);  // danh sách sản phẩm danh sách  có giá <= price truyền vào
			Bai11.printSortByPrice(listProduct);    // danh sách sản phẩm sắp xếp theo giá từ thấp đến cao
			Bai12.SortByName(listProduct);     //Danh sach sản phẩm sắp xếp  theo độ dài của tên từ cao đến thấp

			Bai13.SortByCategoryName(listProduct, listCategory); // trả về danh sách product sắp xếp theo category name theo thứ tự abc. . 

			Bai14.mapProductByCategory(listProduct, listCategory); // trả về danh sách product có chứa tên category tương ứng theo categoryId
			Bai15.minByPrice(listProduct); //trả về  product có giá nhỏ nhất
			Bai16.maxByPrice(listProduct);   // trả về  product có giá lớn nhất

			double salary = 50;      //bài 21 tính lương
			salary = Bai21.CalSalaryRecursive(salary, 3);       // dùng đệ quy
			Console.WriteLine("Tinh luong dung de quy " + salary);
			double luong = 50;
			luong = Bai21.CalSalaryIterative(luong, 3);    // ko dùng đệ quy
			Console.WriteLine("Tinh luong ko dung de quy " + luong);


			int months = Bai22.CalMonthRecursive(100, 50);   //  bài 22 Tính số tháng đề lãi +gốc gấp 2 lần gốc dùng đệ quy

			Console.WriteLine("So thang de lai + goc gap 2 lan goc la :" + months);

			int thang = Bai22.CalMonthIterative(100, 50); //  bài 22 Tính số tháng đề lãi +gốc gấp 2 lần gốc ko dùng đệ quy
			Console.WriteLine("So thang de lai + goc gap 2 lan goc la :" + thang);

			List<Menu> menus = new List<Menu>
		    {
			new Menu ( 1, "The thao", 0),
			new Menu ( 2, "The thao trong nuoc", 1),
			new Menu ( 3, "The thao quoc te", 1),
			new Menu ( 4, "Xa hoi", 0),
			new Menu ( 5, "Giao thong ", 4),
			new Menu ( 6, "Giao thong un tac ", 5),
			new Menu ( 7, "Moi truong ", 4),
			new Menu ( 8, "Moi truong do thi ", 7),
			};
			Console.WriteLine("In menu da cap");
			Bai23.PrintMenu(menus, 0, 0);




			alogithms_quangtt.Entity.Queue<Product> queue = new alogithms_quangtt.Entity.Queue<Product>();    // bài 24 queue
			queue.Push(new Product("CPU", 750, 10, 1));// Thêm các sản phẩm vào hàng đợi
			queue.Push(new Product("RAM", 50, 2, 2));
			queue.Push(new Product("HDD", 70, 1, 2));
			queue.Push(new Product("Main", 400, 3, 1));
			queue.Push(new Product("Keyboard", 30, 8, 4));
			queue.Push(new Product("Mouse", 25, 50, 4));
			queue.Push(new Product("VGA", 60, 35, 3));
			queue.Push(new Product("Monitor", 120, 28, 2));
			queue.Push(new Product("Case", 120, 28, 5));
			Console.WriteLine("Danh sach san pham trong hang đoi");
			while (!queue.IsEmpty())// Lấy và in ra các sản phẩm từ hàng đợi
			{
				Product product = queue.Get();
				printProduct(product);
			}
			alogithms_quangtt.Entity.Stack<Product> stack = new alogithms_quangtt.Entity.Stack<Product>();     //bài 25 stack
			stack.Push(new Product("CPU", 750, 10, 1));// Thêm các sản phẩm vào ngăn xếp
			stack.Push(new Product("RAM", 50, 2, 2));
			stack.Push(new Product("HDD", 70, 1, 2));
			stack.Push(new Product("Main", 400, 3, 1));
			stack.Push(new Product("Keyboard", 30, 8, 4));
			stack.Push(new Product("Mouse", 25, 50, 4));
			stack.Push(new Product("VGA", 60, 35, 3));
			stack.Push(new Product("Monitor", 120, 28, 2));
			stack.Push(new Product("Case", 120, 28, 5));
			Console.WriteLine("Danh sach san pham trong ngan xep");
			while (!stack.IsEmpty())// Lấy và in ra các sản phẩm từ ngăn xếp
			{
				Product product = stack.Get();
				printProduct(product);
			}
		}
	}
}