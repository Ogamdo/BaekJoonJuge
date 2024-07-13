using System;

public class Baekjoon
{
	public static void Main(string[] args)
	{
		
		String s =Console.ReadLine();
		int.TryParse(s, out int T);
		
		for (int i =0; i<T; i++)
		{
			
			String[] strings = Console.ReadLine().Split(' ');
			int.TryParse(strings[0], out int A);
			int.TryParse(strings[1], out int B);

			Console.WriteLine(A+B);

		
		}


	}
	
}
