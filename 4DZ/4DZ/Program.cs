using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Первое задание
        int i = 200;
        string answer = default;
        while (i != 500)
        {
            if (i % 17 == 0)
            {
                answer += i+";";
            }
            i++;
        }
        Console.WriteLine(answer);
        */
        /* Второе задание
        string wvod = Console.ReadLine();
        do { 
        switch (wvod)
        {
            case "W" : 
                Console.WriteLine("Нужно двигаться вперед");
                    break;
            case "w":
                Console.WriteLine("Нужно двигаться вперед");
                break;
            case "S":
                Console.WriteLine("Нужно двигаться назад");
                break;
            case "s":
                Console.WriteLine("Нужно двигаться назад");
                break;
            case "A":
                Console.WriteLine("Нужно двигаться влево");
                break;
            case "a":
                Console.WriteLine("Нужно двигаться влево");
                break;
            case "D":
                Console.WriteLine("Нужно двигаться вправо");
                break;
            case "d":
                Console.WriteLine("Нужно двигаться вправо");
                break;
            default:
                Console.WriteLine("ВВеден неизвестный символ");
                break;
            }
            wvod = Console.ReadLine();
        } while (wvod !="exit");
    */
        /* Третье задание
        Random rnd = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next();
        }
        int j = 0;
    write:
        Console.WriteLine(array[j]);
            j++;
    if (j != array.Length)
        {
            goto write;
        }
        */

        
        /* четвертое задание
        bool RaschetNalog(double sumNalogBaz, double procNalog, out double sumNalog)
        {
            if((sumNalogBaz != null && procNalog !=null) && (sumNalogBaz >= 0 && procNalog >= 0)) 
            {
                sumNalog = sumNalogBaz * (procNalog/100);
                return true;
            }
            else {
                sumNalog = 0;
                return false; 
            }
        }
        */
    }
 }
        
            
        