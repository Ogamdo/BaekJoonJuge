while(true)
{
string str = Console.ReadLine();
string[] strArr = str.Split();
int N  = Convert.ToInt32(strArr[0]);
int M = Convert.ToInt32(strArr[1]);

if(N>M)
{
    Console.WriteLine("Yes");
}
else if(M==0&&N==0)
{
    break;
}
else
{
    Console.WriteLine("No");
}

}
