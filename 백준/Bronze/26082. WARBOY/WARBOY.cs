//경쟁사 가성비 ab = B/A
string  input = Console.ReadLine();
string[] str = input.Split(" ");
int A = Convert.ToInt32(str[0]);
int B = Convert.ToInt32(str[1]);
int C = Convert.ToInt32(str[2]);
int r = B/A;

Console.WriteLine(3*r*C);
