using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 1000; i++)
        {
            list.Add(i);
        }
        Thread myThread1 = new Thread(Chetnii);
        Thread myThread2 = new Thread(NeChetnii);

        myThread1.Start(); 
        myThread2.Start();

        void Chetnii()
        {
            var k = list.Where(j => j % 2 == 0);
            foreach (var i in k)
            {
                Console.WriteLine(i);
            }
        }

        void NeChetnii()
        {
            var p = list.Where(n => n % 2 != 0);
            foreach (var i in p)
            {
                Console.WriteLine(i);
            }
        }
    }
}