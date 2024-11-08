string str = Console.ReadLine();
string[] strArr = str.Split();
int N  = Convert.ToInt32(strArr[0]);
int M = Convert.ToInt32(strArr[1]);
int money = N *100;
if(money > M|| money==M)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}