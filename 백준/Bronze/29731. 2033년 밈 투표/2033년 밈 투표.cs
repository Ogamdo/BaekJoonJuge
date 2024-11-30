
        string[] Astley =new string[7];
        Astley[0] = "Never gonna give you up";
        Astley[1] = "Never gonna let you down";
        Astley[2] = "Never gonna run around and desert you";
        Astley[3] = "Never gonna make you cry";
        Astley[4] = "Never gonna say goodbye";
        Astley[5] = "Never gonna tell a lie and hurt you";
        Astley[6] = "Never gonna stop";
    
        int N = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[N];
        int n = 0;
        for(int i=0; i<N; i++)
        {
           string s= Console.ReadLine();
            if(!Astley.Contains(s))
            {
                n += 1;
            }
           
        
      

          
        }
        if(n > 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }