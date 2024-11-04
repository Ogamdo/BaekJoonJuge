/*
동 술하고 같이 초밥을 먹거나 점심 식사가 아닐 때는 초밥의 밥알을 
$280$개로 하며, 점심 식사이면서 술과 같이 먹지 않을때는 초밥의 밥알을 
$320$개로 하여 초밥을 만들어야 해, 근데, 내가 초밥을 언제 먹을지, 혹은 술과 같이 먹을지 아직 정하지 않았어. 내가 초밥을 먹는 시간과 술의 유무를 말하면, 그때 너는 너가 만들어야 하는 초밥의 밥알 갯수를 구해야해"
*/

//술 같이 혹은 점심 아닐 때 280개
//술 안하면서 점심일 때  320
string sr = Console.ReadLine();
string[] strings = sr.Split();
int T = Convert.ToInt32(strings[0]);
int S = Convert.ToInt32(strings[1]);

if (S == 0)
{
    if (12<=T&&T<=16)
    {
        Console.WriteLine(320);
    }
    else
    {
        Console.WriteLine(280);    
    }
}
else
{
    Console.WriteLine(280);
}