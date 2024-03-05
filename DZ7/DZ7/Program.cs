using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    
    public class Item
    {
        private string Name = "unknown";
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }
    /* второе задание
    public class Engine 
    {
        internal bool Status = false;
    }
    public abstract class Transport
    {
        public abstract Engine Dvig { set; get; }

        public abstract void Move();
    }

    public class Car : Transport
    {
        public override Engine Dvig { set; get; }
        public override void Move() 
        { 
            if(Dvig.Status)
            {
                //логика движения
            }
            else
            {
                Dvig.Status = true;
            }
        }

    }
    public class Plane : Transport
    {
        public override Engine Dvig { set; get; }
        public override void Move()
        {
            if (Dvig.Status)
            {
                //логика движения
            }
            else
            {
                Dvig.Status = true;
            }
        }

    }*/

    public class Bag
    {
        private Item[] array = new Item[8];
        private bool _isOpen;

        public void Switch()
        {
            if (_isOpen)
            {
                _isOpen = false;
            }
            else { _isOpen = true; }
        }
        public void Add(Item item)
        {
            if (_isOpen)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == null)
                    {
                        array[i] = item;
                        Console.WriteLine($"Предмет {item.GetName()} добавлен в сумку");
                        break;
                    }else if(i== array.Length - 1 && array[i]!=null)
                    {
                        Console.WriteLine("Сумка заполнена");
                    }
                }
            }
            else { Console.WriteLine("Откройте сумку"); }
        }
        public Item TakeItem(int i)
        {
            Item j;
            if (_isOpen)
            {
                if (array[i]!=null) 
                { 
                    j = array[i];
                    array[i] = null;
                    Console.WriteLine($"Предмет {j.GetName()} взят из сумки");
                    return j;
                }
                else 
                {
                    Console.WriteLine("В данном отсеке сумки предмета нет");
                    return null;
                };
            }
            else
            {
                Console.WriteLine("Сумка закрыта");
                return null;
            }
        }
    }

}

/* третье задание
public static class IntExtension
    {
        public static int MaxNumber(this int[] array)
        {
        int j = 0;
        for(int i  = 0; i < array.Length; i++) 
        {
            if (i == 0)
            {
                j = array[i];
            }
            else
            {
                if (array[i]> j)
                {
                    j = array[i];
                }
            }
        }
        return j;
        }
    }*/