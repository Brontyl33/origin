internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    public class Worker:IComparable<Worker>
    {
        protected string name;
        protected int age;
        protected double salary;

        public Worker(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public int CompareTo(Worker? obj)
        {
            if (obj == null) return -1;
            else if (obj == this) return 0;
            else if (obj.salary > this.salary) return -1;
            else return 1;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{name} - работник, возраст работника - {age}, работник имеет зарплату -{salary} рублей");
        }
    }

    public class Maneger : Worker
    {
        protected string otdel;
        public Maneger(string name, int age, double salary, string otdel) : base(name, age, salary)
        {
            this.otdel = otdel;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{name} - менеджер из отдела -{otdel} , возраст менеджер - {age}, менеджер имеет зарплату -{salary} рублей");
        }
    }
}