using System.Numerics;
// 두개의 입력을 받고, 정수형으로 변환하자.
string str = Console.ReadLine();
string str2 = Console.ReadLine();
char[] arr = str2.ToCharArray();
int N = Convert.ToInt32(str); // 첫줄 변환
int[] ints = new int[N]; // 첫 줄만큼의 길이를 가진 정수형 배열을 선언한다.
int sum =0;// 배열들을 더할 정수형 자료를 선언한다.

for (int i = 0; i < N; i++)
{
    ints[i] = Convert.ToInt32(arr[i].ToString());
    
    sum += ints[i];
  
}
  Console.WriteLine(sum);