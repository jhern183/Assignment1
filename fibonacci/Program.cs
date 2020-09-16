using System;

namespace fibonacci
{
	class Program
	{
		public static int FibonacciSequence(int n)
		{
			int x = 0;
			int y = 1;
			
			for (int i = 0; i < n; i++)
			{
				int temp = x;
				x = y;
				y = temp + y;
			}
			return x;

		}
		static void Main()
		{
			Console.Write("\n\n\n Input sequence number: ");
			int s = Convert.ToInt32(Console.ReadLine());
			Console.Write("\n\n The Fibonacci sequence number at {0} is : ", s);
			
			
			Console.Write("{0} ", FibonacciSequence(s-1));
			
			

		}
	}
}
