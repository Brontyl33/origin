
using static Program;

internal class Program
{
        delegate void NewYear();
        static void Main(string[] args)
        {

        List<Children> l =
        [
            new Children("Ivan", "Ivanov", 2),
            new Children("Petr", "Ivanov", 3),
            new Children("Ivan", "Petrov", 1),
            new Children("Petr", "Petrov", 5),
        ];

        List<Children> l2 =
        [
            new Children("Bill", "Ivanov", 6),
            new Children("Petr", "Gordon", 10),
            new Children("Jim", "Petrov", 15),
            new Children("Tom", "Fedorov", 9),
        ];

        DetskSad d = new DetskSad(l);
        Shool s = new Shool(l2);
        NewYear n = s.NewYear;
        n += d.NewYear;
        d.Notify += s.AddChildren;

        while (true)
        {
            Console.WriteLine("Напишите + для перемотки года или exit для выхода из программы");
            string j = Console.ReadLine();
            if (j == "+")
            {
                Console.WriteLine("Наступил новый учебный год");
                n();
            }
            else if (j == "exit")
            {
                Console.WriteLine("Происходит выход из программы");
                break;
            }
            else { Console.WriteLine($"Команда - {j} отсуствует и не может быть выплнена"); }
        }

        /* Первое задание
            List<Student> l = new List<Student>(0);
            l.Add(new Student("Ivan", "Ivanov",12));
            l.Add(new Student("Petr", "Ivanov", 7));
            l.Add(new Student("Ivan", "Petrov", 9));
            l.Add(new Student("Petr", "Petrov", 6));


            School s = new School(l);

        while (true) { 
            Console.WriteLine("Ведите команду. + это добавить ученика, ? это найти ученика, напишите exit для выхода из программы");
            string j = Console.ReadLine();
            if(j == "?") 
            { 
            Console.WriteLine("Введите имя искомого человека");
            string name =Console.ReadLine();
            Console.WriteLine("Введите фамилию искомого человека");
            string secondName = Console.ReadLine();

            Student p = s.Search(p =>
            {
                bool result = false;
                if (p.Name == name && p.Surname == secondName)
                { result = true; }
                return result;
            });
            if (p != null)
                Console.WriteLine($"Ученик по имени - {p.Name} и фамилии - {p.Surname} присуствует в школе");
            else Console.WriteLine($"Ученик по имени - {name} и фамилии - {secondName} отсутсвует в школе");

            }else if(j == "+")
            {
                Console.WriteLine("Введите имя ученика");
                string name = Console.ReadLine();
                Console.WriteLine("Введите фамилию ученика");
                string secondName = Console.ReadLine();
                int age;
                while (true) 
                { 
                Console.WriteLine("Введите возвраст ученика");
                string agetemp = Console.ReadLine();
                    if (int.TryParse(agetemp,out age)) 
                    {
                        break;
                    }
                }
                Student temp = new Student(name, secondName, age);
                s.AddStudent(temp);
            }else if(j == "exit")
            {
                Console.WriteLine("Происходит выход из программы");
                break;
            }
            else { Console.WriteLine($"Команда - {j} отсуствует и не может быть выплнена") ; }
        }
        }*/
    }
    /*Первое задание
    internal class Student
    {
        public string Name;
        public string Surname;
        public int age;
        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            this.age = age;
        }
    }

    internal class Headteacher
    {
        public string Name;
        public string Surname;
        internal Headteacher(string name, string secondname)
        {
            this.Name = name;
            this.Surname = secondname;
        }
        public void Privetstvie(string name, int age)
        {
            Console.WriteLine($"Приветствую родителей ученика  - {name}, {age} - хороший возраст для начала обучения");
        }
    }



    internal class School
    {
        List<Student> list = new List<Student>(0);
        Headteacher headteacher = new Headteacher("Sergey", "Petrov");

        public School(List<Student> list)
        {
            this.list = list;
        }

        internal Student Search(Func<Student, bool> value)
        {
            foreach (Student p in list)
                if (value(p))
                    return p;
            return null;
        }
        public void AddStudent(Student student)
        {
            list.Add(student);
            headteacher.Privetstvie(student.Name, student.age);
        }*/

    public class Shool
    {
        List<Children> childrens = new List<Children>();

        public Shool(List<Children> l)
        {
            childrens = l;
        }

        public void AddChildren(List<Children> children)
        {
            if (children.Count > 0) { 
            foreach(Children child in children)
            {
                childrens.Add(child);
                    Console.WriteLine($"Ребенок {child.name} {child.secondName} перешел в школу");
            }
                Console.WriteLine("Учеников в школе после перехода детей из садика");
                Print();
            }
        }
        public void Print()
        {
            if (childrens.Count > 0)
            {
                foreach (Children child in childrens)
                {
                    Console.WriteLine(child.name + " " + child.secondName + " возраст - " + child.age);
                }
            }
        }
        public void NewYear()
        {
            List <Children> k = new List<Children>();
            if (childrens.Count > 0)
            {
                foreach (Children child in childrens)
                {
                    child.age += 1;
                    if (child.age >= 18)
                    {
                        Console.WriteLine($"Ученик {child.name} закончил школу в этом году");
                        k.Add(child);
                    }
                }
                foreach (Children child in k)
                {
                    if (childrens.Contains(child))
                    {
                        childrens.Remove(child);
                    }
                }
            }
                Console.WriteLine("Учеников в школе до перехода детей из садика");
                Print();
            }
        }
    

    public class DetskSad
    {
        List<Children> childrens = new List<Children>();

        public DetskSad(List<Children> l) 
        {
            childrens = l;
        }

       public delegate void NewYearPerehod(List<Children> children);
       public event NewYearPerehod? Notify;
        public void Print()
        {
            if (childrens.Count > 0)
            {
                foreach (Children child in childrens)
                {
                    Console.WriteLine(child.name + " " + child.secondName + " возраст - " + child.age);
                }
            }
            else
            {
                Console.WriteLine("Садик пуст");
            }
        }
        public void NewYear()
        {
            List<Children> k = new List<Children>();
            if (childrens.Count > 0)
            {
                foreach (Children child in childrens)
                {
                    child.age += 1;
                    if (child.age >= 6)
                    {
                        k.Add(child);
                    }
                }
                foreach (Children child in k)
                {
                    if (childrens.Contains(child))
                    {
                        childrens.Remove(child);
                    }
                }
                
                Console.WriteLine("Учеников в садике после перехода детей в школу");
                Print();
                Notify?.Invoke(k);
            }
        }   
    }
 
    public class Children
    {
        public string name;
        public string secondName;
        public int age;
        public Children(string name, string secondName, int age) 
        {
            this.name = name;
            this.secondName = secondName;
            this.age = age;
        }

    }
}

