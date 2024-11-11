while(true)
{
    string input = Console.ReadLine();
    if(input == "0 0") break;
    string[] nums = input.Split(" ");
    int A = Convert.ToInt32(nums[0]);
    int B = Convert.ToInt32(nums[1]);
    Console.WriteLine(A+B);
}