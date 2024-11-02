int n =Convert.ToInt32( Console.ReadLine());
int[] array = new int[n];
int count = 0;
while (count<n){
    array[count] = Convert.ToInt32( Console.ReadLine());
    count ++;
}
string[] strs = new string[array.Length];
for (int i = 0;i<strs.Length; i++){
    strs[i] = Convert.ToString(array[i]);
    Console.WriteLine(strs[i]+" " +strs[i]);
}
