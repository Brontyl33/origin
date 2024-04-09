

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using static Program;

internal class Program

{
    public static Random r = new Random();
    private static void Main(string[] args)
    {


        /*foreach (var i in NumberMoreFive(GetRandomWords(Convert.ToInt32(Console.ReadLine()))))
         {
             Console.WriteLine(i);
          };*/

        CustomCollection<NewClass> n = new CustomCollection<NewClass>();
        n.Add(new NewClass(23,0));
    }

    /*Первое задание
    public static IEnumerable<string> NumberMoreFive(string[] array)
    {
        foreach (var item in array)
        {
            if (item.Length > 5)
            {
                
                yield return item;
            }
        }
    }

    public static string[] GetRandomWords(int numberSlov)
    {
        
       List <string>  answer = new List <string>();
        Dictionary<int, string> words = new Dictionary<int, string>();
        
        for (int i = 0; i < 11; i++)
        {
            words.Add(i, RandomString());
        }
        string j = default;
        for (int i = 0; i < numberSlov; i++)
        {
            repit:
            j = words[r.Next(0, 9)];
            if (answer.Contains(j))
                {
                goto repit;
            }
            else
            {
                answer.Add(j);
            }
            
        }

        return answer.ToArray();
    }

    public static string RandomString()
    {
        string s = default;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        for(int i = 0;i < r.Next(4,9);i++)
        {
            s += chars[r.Next(1, 26)];
        }
        return s;
    }*/


    public class NewClass(): IComparable<NewClass>
    {
        public int value;
        public int idNumber{ get; set;}

        public NewClass(int value, int i) : this()
        {
            this.value = value;
            this.idNumber = i;
        }

        public int CompareTo(NewClass? obj)
        {
            if (obj == null)
            {
                return -1;
            }
            else {
                
                    if(obj.idNumber>this.idNumber)
                    {
                        return 1;
                    }else if(obj.idNumber==this.idNumber) { return 0;}
                    else { return -1;}
                }
        }

    }


    public class CustomCollection<T> where T : IComparable<T>
    {
        public List<NewClass> list;

        public CustomCollection()
        {
            list = new List<NewClass>();
            for(int i = 0;i<r.Next(2,6);i++)
            {
                list.Add(new NewClass(r.Next(1, 100), r.Next(1, 100)));
            }

            list.Sort();
            Print();
        }

        public void Add(NewClass objec)
        {
            list.Add(objec);
            list.Sort();
            Print();
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Print()
        {
            Console.WriteLine("Вывод значения списка");
            foreach(var objec in list)
            {
                Console.WriteLine($"idNamber = {objec.idNumber}, value = {objec.value}");
            }
        }
    }


}

public class T
{
}