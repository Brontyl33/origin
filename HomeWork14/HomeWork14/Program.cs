using static Program;

internal class Program
{

    
    private static void Main(string[] args)
    {

        NewClass nC = new NewClass();
            for (int i = 0; i < 5; i++)
        {
            try
            {
                Console.WriteLine("Введите любое сообщение, что бы добавить его в список");
                nC.AddString(Console.ReadLine());
            }
            catch (Exception ex)
                {
            Console.WriteLine(ex.ToString());
                }
            }

        /* Второе задание
        int one;
        int two;
    marck1:
        Console.WriteLine("Введите первое число от 0 до 255");

        string i = Console.ReadLine();
        try
        {
            if (i == "")
            {
                throw new Exception("Значение не введено");
            }
            else
            {
                if (!int.TryParse(i, out one))
                {
                    throw new Exception("Введено не правильное значение");
                }
                else
                {
                    if (0 > one || one > 250)
                    {
                        throw new Exception("Число не уложилось в лимит");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            goto marck1;
        }
    marck2:
        Console.WriteLine("Введите второе число от 0 до 255");

        string j = Console.ReadLine();
        try
        {
            if (j == "")
            {
                throw new Exception("Значение не введено");
            }
            else
            {
                if (!int.TryParse(j, out two))
                {
                    throw new Exception("Введено не правильное значение");
                }
                else if (0 > two || two > 250)
                {
                        throw new Exception("Число не уложилось в лимит");
                    
                }else if(two == 0)
                {
                    throw new Exception("На 0 делить нельзя");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            goto marck2;
        }
        
            Console.WriteLine($"Значение деления + {one / two}");
        */
    }

    /* Первое задание
    public class Goods
    {
        public string Name { get; set; }
        public int price { get; set; }

        public Goods(string name, int price)
        {
            this.Name = name;
            this.price = price;
        }
    }

    public class Shop 
    {
        List<Goods> goodsInShop = new List<Goods>();
        public bool workerOfShops = false;
        private bool close = false;

        public Shop(bool workerOfShops)
        {
            this.workerOfShops = workerOfShops;
            try { 
                if (!workerOfShops)
                {
                    throw new Exception("Магазин не может работать без работника");
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Ошибка - {ex.Message}");
            }
        }
        public void AddGoods(Goods goods)
        {
            try
            {
                if (close)
                {
                    throw new Exception("Магазин ликвидирован");
                }
                else if (!workerOfShops)
                {
                    throw new Exception("Магазин не может работать без работника");
                }
                else if (goodsInShop.Contains(goods))
                {
                    throw new Exception($"Товар - {goods.Name} уже есть в магазине, ввидите другой товар");
                }
                else
                {
                    Console.WriteLine($"Товар - {goods.Name} добавлен в магазин");
                    goodsInShop.Add(goods);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка - {ex.Message}");
            }
        }
        public void BuyGoods(Goods goods, int priseforbuy)
        {
            try
            {
                if (close)
                {
                    throw new Exception("Магазин ликвидирован");
                }
                else if(!workerOfShops)
                {
                    throw new Exception("Магазин не может работать без работника");
                }
                else if (!goodsInShop.Contains(goods))
                {
                    throw new Exception($"Товар - {goods.Name} отсутсвует в магазине, выбирете другой товар");
                }else if(goods.price> priseforbuy)
                {
                    throw new Exception($"Товар - {goods.Name} стоит дорожи чем вы заплатили, предложите больше");
                }
                else
                {
                    Console.WriteLine($"Товар - {goods.Name} куплен");
                    goodsInShop.Remove(goods);
                }
            } catch (Exception ex) 
            {
                Console.WriteLine($"Ошибка - {ex.Message}");
            }
        }
        public void CloseShop()
        {
            try
            {
                if (goodsInShop.Count != 0)
                {
                    throw new Exception($"В магазине все еще есть товар, купите весь товар преджде чем его закрыть");
                }
                else 
                {
                    Console.WriteLine("Магазин закрыт");
                    close = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка - {ex.Message}");
            }
        }
    }

    */



    public class NewException : Exception
    {
        public NewException()
        {
        }

        public NewException(string message)
            : base(message) { }

        public NewException(string message, Exception inner)
            : base(message, inner) { }
    }

    public class NewClass
    {
        List<string> list = new List<string>();

        public void AddString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NewException("Введена пустая строка");
            }
            else
            {
                Console.WriteLine($"Значение - {value} добавлено в список");
                this.list.Add(value);
            }
        }
    }
}