internal class Program
{
    private static void Main(string[] args)
    {
        int[] i = [1,8, 2, 3, 5, 11,16];

        Console.WriteLine(SumCol(i));

        List<int> list = new List<int>();
        list = i.ToList();
        var answer2 = list.Where(p => p % 2 == 0);
        foreach(var j in answer2)
        {
            Console.WriteLine(j);
        }
    }
    public static int SumCol(int[] t)
    {
        int answered = 0;
        foreach (int i in t)
        {
            answered += i;
        }
        return answered;
    }
}