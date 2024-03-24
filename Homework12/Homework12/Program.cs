internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> listOfPerson =
        [
            new Person(Pol.man, "Jon", 26),
            new Person(Pol.man, "Sam", 38),
            new Person(Pol.man, "Karl", 12),
            new Person(Pol.man, "Din", 65),
            new Person(Pol.man, "Yan", 21),
            new Person(Pol.woman, "Kler", 33),
            new Person(Pol.woman, "Sveta", 88),
            new Person(Pol.woman, "Kat", 1),
            new Person(Pol.woman, "Pet", 52),
            new Person(Pol.woman, "Jan", 24),
        ];

        listOfPerson.Sort();
        foreach(Person person in listOfPerson)
        {
            Console.WriteLine(person.name +" "+ person.age);
        }
    }

    // Первое задание
    public abstract class Animal
    {
        protected string name { get; set; }
        protected int numOfLegs { get; set; }

        public abstract void setName(string name);
        public abstract string getName();
        public abstract void setNumOfLegs(int num);
        public abstract int getNumOfLegs();
        public abstract void displayAnimal();
    }

    public class Cat : Animal, Carnivore
    {
        private string sound;
        private string color;

        public Cat(string sound, string color)
        {
            this.sound = sound;
            this.color = color;
        }

        public string typeC { get; set; }
        public string foodC { get; set; }

        public override void displayAnimal()
        {
            Console.WriteLine(name);
        }

        public void displayEatC()
        {
            Console.WriteLine(foodC);
        }

        public override string getName()
        {
            return name;
        }

        public override int getNumOfLegs()
        {
            return numOfLegs;
        }

        public override void setName(string name)
        {
            this.name = name;
        }

        public override void setNumOfLegs(int num)
        {
            numOfLegs = num;
        }
    }

    public class Bear : Animal, Carnivore, Herbivore
    {
        private string sound;
        private string color;

        public Bear(string sound, string color)
        {
            this.sound = sound;
            this.color = color;
        }

        public string typeC { get; set; }
        public string foodC { get; set; }
        public string typeH { get ; set; }
        public string foodH { get ; set; }

        public override void displayAnimal()
        {
            Console.WriteLine(name);
        }

        public void displayEatC()
        {
            Console.WriteLine(foodC);
        }

        public void displayEatH()
        {
            Console.WriteLine(foodH);
        }

        public override string getName()
        {
            return name;
        }

        public override int getNumOfLegs()
        {
            return numOfLegs;
        }

        public override void setName(string name)
        {
            this.name = name;
        }

        public override void setNumOfLegs(int num)
        {
            numOfLegs = num;
        }
    }
    public class Elephant : Animal,  Herbivore , Iequatable
    {
        private string sound;
        private string color;
        private int Size { get; set; }

        public Elephant(string sound, string color, int size)
        {
            this.sound = sound;
            this.color = color;
            Size = size;
        }

        public string typeH { get; set; }
        public string foodH { get; set; }

        public override void displayAnimal()
        {
            Console.WriteLine(name);
        }

        public void displayEatH()
        {
            Console.WriteLine(foodH);
        }

        public override string getName()
        {
            return name;
        }

        public override int getNumOfLegs()
        {
            return numOfLegs;
        }

        public override void setName(string name)
        {
            this.name = name;
        }

        public override void setNumOfLegs(int num)
        {
            numOfLegs = num;
        }

        public bool MoreSizeThen(Elephant ele)
        {
            if(ele.Size>=this.Size) return false;
            else return true;
        }
    }
    public interface Carnivore
    {
        public string typeC { get; set; }
        public string foodC { get; set; }

        public void displayEatC();
    }
    public interface Herbivore
    {
        public string typeH { get; set; }
        public string foodH { get; set; }

        public void displayEatH();
    } 
    //Второе задание
    public class Zoo
    {
        private Animal[] volierForHerb;
        private Animal[] volierForPredator;

        public Zoo(int herb, int predator)
        {
            volierForHerb = new Animal[herb];
            volierForPredator = new Animal[predator];
        }

        public void AddAnimal(Animal animal)
        {
            if (animal is Carnivore)
            {
                for (int i = 0; i < volierForPredator.Length; i++)
                {
                    if (volierForPredator[i] == null)
                    {
                        volierForPredator[i] = animal;
                        Console.WriteLine($"Животное {animal.getName()} помещено в вольер для хищников");
                        break;
                    }
                    else if (i == volierForPredator.Length - 1 && volierForPredator[i] != null)
                    {
                        Console.WriteLine("Вольер c хищниками полон, убирите животное или расширьте вольер");
                    }
                }
            }
            else if (animal is Herbivore)
            {
                for (int i = 0; i < volierForHerb.Length; i++)
                {
                    if (volierForHerb[i] == null)
                    {
                        volierForHerb[i] = animal;
                        Console.WriteLine($"Животное {animal.getName()} помещено в вольер для травоядных");
                        break;
                    }
                    else if (i == volierForHerb.Length - 1 && volierForHerb[i] != null)
                    {
                        Console.WriteLine("Вольер с травоядными полон, убирите животное или расширьте вольер");
                    }
                }
            }
        }

    }
    //Третье задание
    public interface Iequatable 
    {
        public bool MoreSizeThen(Elephant ele);
    }
    // Четвертое задание
    public class Person : IComparable<Person>
    {
        
        Pol pol;
        public string name;
        public int age;

        public Person(Pol pol, string name, int age)
        {
            this.pol = pol;
            this.name = name;
            this.age = age;
        }
        int IComparable<Person>.CompareTo(Person other)
        {
            if(other.pol==Pol.woman && this.pol == Pol.man)
            {
                return 1;
            }else if (other.pol == Pol.man && this.pol == Pol.woman)
            {
                return -1;
            }
            else
            {
                if (this.age == other.age)
                {
                    return 0;
                }else if(other.age < this.age)
                {
                    return 1;
                }else
                {
                    return -1;
                }
            }
        }
    }
    
    public enum Pol
        {
            woman,
            man
        }

    //Пятое задание
    public class MobileNetwork
    {
        string name { get; set; }
        string country { get; set; }

        public MobileNetwork(string name, string country)
        {
            this.name=name;
            this.country=country;
        }

    }

    public class MobilePhone<T> where T : MobileNetwork
    {

        private T Network { get; set; }

        public T InputSim(T network)
        {
            if (Network == null)
            {
                Network = network;
                Console.WriteLine("Карта вставлена в пустой разъем");
                return null;
            }
            else
            {
                T networkold = Network;
                Network = network;
                Console.WriteLine("Карта вставлена в разъем, старая карта возвращена");
                return networkold;
            }

        }

    }
    
}