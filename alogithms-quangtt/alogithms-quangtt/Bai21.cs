using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt.Entity
{
	public class Bai21
	{
		public static double CalSalaryRecursive(double salary, int n) //bài 21 dùng đệ quy
		{
			if (n == 1)
			{
				return salary;
			}
			return Math.Round(CalSalaryRecursive(salary, n - 1) * 1.10, 6);
		}
		public static double CalSalaryIterative(double salary, int n)//bài 21 ko dùng đệ quy
		{
			for (int i = 2; i <= n; i++)
			{
				salary *= 1.10;
				salary = Math.Round(salary, 6);
			}
			return salary;
		}

	}
}
