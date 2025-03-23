using System.Numerics;

Console.WriteLine("Which week do you want to access?");
int weekNo = int.Parse(Console.ReadLine()!);
if(weekNo == 1) {
    Console.WriteLine("Which question?");
    int QuestionNo = int.Parse(Console.ReadLine()!);
    if(QuestionNo == 5) {
        Console.WriteLine("Enter a list of numbers seperated by spaces. i.e. '1 4 5 2.5 6 0'");
        string[] AStr = Console.ReadLine()!.Split(' ');
        List<float> A = new List<float>();
        foreach(string str in AStr) A.Add(float.Parse(str));
        Console.WriteLine($"the smallest distance is: {Week1.minDistance(A)}");
    }
}

else if(weekNo == 3) {
    Console.WriteLine("Which question?");
    int QuestionNo = int.Parse(Console.ReadLine()!);
    if(QuestionNo == 3) {
        Console.WriteLine("Enter a list of numbers seperated by spaces. i.e. '1 4 5 2.5 6 0'");
        string[] AStr = Console.ReadLine()!.Split(' ');
        List<float> A = new List<float>();
        foreach(string str in AStr) A.Add(float.Parse(str));
        Console.WriteLine($"the smallest distance is: {Week1.minDistance(A)}");
    }
}