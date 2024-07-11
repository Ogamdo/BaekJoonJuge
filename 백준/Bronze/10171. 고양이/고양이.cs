using System;
using System.Data.Common;

public class Baekjoon
{
	public static void Main(string[] args)
	{
		

		Cat cat= new Cat();
		cat.priting();
	
	

	}
    
public class Cat
{
    // @를 사용하여 verbatim string literal을 사용하면, 역슬래시를 그대로 사용
    // 일반 문자열 리터럴에서 역슬래시를 사용하려면 \\로 이스케이프
   private string cat = @"\    /\" + Environment.NewLine +
                         @" )  ( ')" + Environment.NewLine +
                         @"(  /  )" + Environment.NewLine +
                         @" \(__)|" + Environment.NewLine;
        public void priting()
    {
        Console.WriteLine(cat);
    }
}
}
