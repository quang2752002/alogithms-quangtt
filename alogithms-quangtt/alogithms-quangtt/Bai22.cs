using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogithms_quangtt
{
	public class Bai22
	{
		public static int CalMonthRecursive(double money, double rate, double interest = 0, int months = 0)//bài 22 Tính số tháng đề lãi +gốc gấp 2 lần gốc dùng đệ quy
		{
			double x = money * (rate / 100);
			interest += x;
			months++;

			if (interest >= money)
			{
				return months;
			}
			else
			{
				return CalMonthRecursive(money, rate, interest, months);
			}
		}
		public static int CalMonthIterative(double money, double rate)  // bài 22 Tính số tháng đề lãi +gốc gấp 2 lần gốc ko dùng đệ quy
		{
			int months = 0;
			double interest = 0;
			while (interest < money)
			{
				double x = money * (rate / 100);
				interest += x;
				months++;
			}
			return months;
		}

	}
}
