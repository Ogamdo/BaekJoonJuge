public class Program
{
    public static void Main(string[] args)
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();
    string str3 = Console.ReadLine();

    int N = Int32.Parse(str1);
    int V = Int32.Parse(str3);
    int count = 0;
    string[] strs = str2.Split(' ');

    for(int i=0; i <strs.Length; i++)
    {

        if(strs[i] == str3)
        {
           count++;
        }
        if(i == strs.Length - 1)
        {
            Console.WriteLine(count);

        }
    }

    
 


}

   
}
