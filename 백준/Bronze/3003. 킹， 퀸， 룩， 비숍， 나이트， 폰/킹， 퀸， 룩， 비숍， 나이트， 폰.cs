using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 입력받고 공백으로 분리하여 배열로 저장
        string[] inputs = Console.ReadLine().Split();
        
        // 정수 리스트로 변환
        List<int> nums = new List<int>();
        foreach (string item in inputs)
        {
            nums.Add(int.Parse(item));
        }

        // origin 리스트 초기화
        int[] origin = { 1, 1, 2, 2, 2, 8 };
        
        // 결과를 저장할 리스트 생성
        List<int> result = new List<int>();

        // 각 요소를 빼고 결과 리스트에 저장
        for (int i = 0; i < origin.Length; i++)
        {
            result.Add(origin[i] - nums[i]);
        }

        // 결과 리스트 출력
        Console.WriteLine(string.Join(" ", result));
    }
}
