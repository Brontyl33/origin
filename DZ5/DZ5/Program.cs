using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        /* первое задание

        static string[] NewMethod(string[] array1, string value)
        {
            if (array1 == null || value == null)
            {
                return null;
            }
            else
            {
                if (array1.Contains(value))
                {
                    return array1;
                }
                else
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (array1[i] == null)
                        {
                            array1[i] = value;

                            return array1;
                        }
                    }
                    Array.Resize(ref array1, array1.Length + 1);
                    array1[array1.Length - 1] = value;
                    return array1;

                }
            }
        }*/
        /* второе задание
        int[,] first = new int[2, 3] { { 1, 2,11 }, { 2, 2,9 } };
        int[,] second = new int[2, 3] { { 3, 5 , 7 }, { 8, 4, -7 } };
       
        Console.WriteLine(Metod(first,second));

        int[,] Metod(int [,] a, int [,] b)
        {
            if (a.Length == b.Length && a!=null && b!=null)
            {
                int[,] answer = new int[a.GetUpperBound(0) +1, a.GetUpperBound(1)+1];
                for (int i = 0; i< a.GetUpperBound(0)+1; i++)
                {
                    for (int j = 0; j < a.GetUpperBound(1) + 1; j++)
                    {
                        answer[i,j] = a[i, j] + b[i,j];
                    }
                }
                return answer;
            }
            else
            {
                return null;
            }
        }*/
    } 
}