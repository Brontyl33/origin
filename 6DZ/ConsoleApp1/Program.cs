//using Library1;
//namespace ConeSpace;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Первое задание вместе с библиотекой ArrayWorker
        int[] first = [1, 6, 8, 3, 5, 7];
        ArrayWorker worker = new ArrayWorker();
        worker.Invert(first);
        */

        /* Второе задание с библиотекой Cone
        Cone c = new Cone(3,6);
        Console.WriteLine(c.PloshadiOsnov());
        Console.WriteLine(c.PloshadiPolnai());
        */

        /* третье задание
        Steck s = new Steck();
        while(true)
        {
            Console.WriteLine("Введите команду");
            string comanda = Console.ReadLine();

            if (comanda == "?")
            {
                s.IsEmpy();
            }
            else if (comanda == "+")
            {
                Console.WriteLine("Введите добавляемый элемент");
                s.Push(Console.ReadLine());
            }
            else if (comanda == "-")
            {
                s.Pop();
            }
            else if (comanda == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Введена неизвестная команда");
            }

        }*/

        /* четвертое задание
        Queue s = new Queue();
        while (true)
        {
            Console.WriteLine("Введите команду");
            string comanda = Console.ReadLine();

            if (comanda == "?")
            {
                s.Empty();
            }
            else if (comanda == "+")
            {
                Console.WriteLine("Введите добавляемый элемент");
                s.Push(Console.ReadLine());
            }
            else if (comanda == "-")
            {
                s.Pop();
            }
            else if (comanda == "e")
            {
                Console.WriteLine( s.Size());
            }else if (comanda == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Введена неизвестная команда");
            }

        }
        */

    }

    /* часть 4 задания
    public class Queue
    {
        string[] queue = new string[10];

        public bool Empty()
        {
            foreach (var i in queue)
            {
                if (!String.IsNullOrEmpty(i))
                {
                    
                    return false;
                }
            }
            
            return true;
        }
        public void Push(string peremen)
        {
            if (!String.IsNullOrEmpty(peremen))
            {
                for(var i = 0; i < queue.Length; i++)
                {
                    if (String.IsNullOrEmpty(queue[i]))
                    {
                        queue[i] = peremen;
                        return;
                    }
                }
                Console.WriteLine("Очередь переполнена удалите ненужные данные");
            }
            else
            {
                Console.WriteLine("Вы не ввели элемент");
                return;
            }
        }
        public void Pop()
        {
            if (Empty())
            {
                Console.WriteLine("Очередь пуста, отсутсвуют данные для удаления");
            }
            else
            {
                queue[0] = null;
                for (var i = 0;i < queue.Length; i++)
                {
                    if (i< queue.Length - 1 && !String.IsNullOrEmpty(queue[i+1]))
                    {
                        queue[i] = queue[i+1];
                    }else if(i == queue.Length - 1)
                    {
                        queue[queue.Length - 1] = null;
                    }else if(String.IsNullOrEmpty(queue[i + 1]))
                    {
                        queue[i] = null;
                        break;
                    }
                }
            }
        }
        public int Size()
        { 
            for(int i = 0; i < queue.Length;i++)
            {
                if (String.IsNullOrEmpty(queue[i]))
                {
                    return i;
                }
            }
            return queue.Length;
        }


    }

*/

}

/* Вторая часть 3 задания
public class Steck
{
    string[] steck = new string[10];
    private int golovnoiElement = -1;

    public bool IsEmpy()
    {
        foreach (var i in steck)
        {
            if (!String.IsNullOrEmpty(i))
            {
                Console.WriteLine("Стек не пуст");
                return false;
            }
        }
        Console.WriteLine("Стек пуст");
        return true;
    }

    public void Push(string peremen)
    {
        if(!String.IsNullOrEmpty(peremen)) 
        { 
            if (golovnoiElement == 9)
            {
                Console.WriteLine("Стек переполнен удалите ненужные данные");
            }
            else
            {
                golovnoiElement++;
                steck[golovnoiElement] = peremen;
                Console.WriteLine($"Элемент - {peremen} добавлен");
            }
        }
        else
        {
            Console.WriteLine("Вы не ввели элемент");
            return;
        }
    }

    public void Pop()
    {
        if (golovnoiElement == -1)
        {
            Console.WriteLine("Стек пуст, отсутсвуют данные для удаления");
        }
        else
        {
            steck[golovnoiElement] = null;
            golovnoiElement--;
            Console.WriteLine("Первый элемент в стеке удален");
        }
    }
}*/