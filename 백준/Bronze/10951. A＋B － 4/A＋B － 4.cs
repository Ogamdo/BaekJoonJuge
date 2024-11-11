
while(true)
{
    string AnB = Console.ReadLine();
     if(AnB == null)
    {
        break;
    }
    string[] strings = AnB.Split(" ");
    int A = Convert.ToInt32(strings[0]);
    int B = Convert.ToInt32(strings[1]);
    Console.WriteLine(A+B);
   
} 
