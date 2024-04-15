internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("ВВедите знак / для деления чисел или ввидите exit для выхода");
            string x = Console.ReadLine();
            if (x.Equals("/"))
            {mark:
                try {
                    Console.WriteLine("ВВедите первое число");
                    int one = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("ВВедите второе число");
                    int second = Convert.ToInt32(Console.ReadLine());
                    if (second == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    else { Console.WriteLine($"{Delit(one, second)} - результат деления"); }
                } 
                        catch(DivideByZeroException) { Console.WriteLine("Второе число является 0, на 0 делить нельзя"); goto mark; } 
                        catch(Exception) { Console.WriteLine("ВВеденое значение не является числом"); goto mark; }
            }else if (x.Equals("exit")) break;
            else { Console.WriteLine("Не известный символ"); }
        }
    }

   public static double Delit(int i, int j)
        
        {
                return Convert.ToDouble(i) / j; 
        }

}