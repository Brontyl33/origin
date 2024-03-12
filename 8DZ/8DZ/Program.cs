using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {

    }

    public abstract class Animal
    {
        public bool Full { get; set; }
        public virtual void Live()
        {

        }
    }

    public class HerbivoreAnimal : Animal
    {

        public override void Live()
        {
            if (!Full)
            {
                EatGrass();
            }
        }

        private void EatGrass()
        {
            Console.WriteLine("Жует траву");
            Full = true;

        }
    }

    public class Predator : Animal
    {
        
        public override void Live()
        {
            if (!Full)
            {
                Bite();
                
            }
        }

        private void Bite()
        {
            Console.WriteLine("Охотится");
            Full = true;
        }
    }

    public class Rabbit : HerbivoreAnimal { }

    public class Deer : HerbivoreAnimal { }

    public class Wolf : Predator { }

    public class Bear : Predator { }

    public class Zoo
    {
        private Animal[] volierForHerb;
        private Animal[] volierForPredator;

        public Zoo(int herb, int predator) 
        {
            volierForHerb  = new Animal[herb];
            volierForPredator = new Animal[predator];
        }

        public void AddAnimal(Animal animal)
        {
            Type type = animal.GetType();
            if(type.BaseType == typeof(Predator))
            {
                for(int i = 0; i< volierForPredator.Length;i++)
                {
                    if(volierForPredator[i] == null)
                    {
                        volierForPredator[i] = animal;
                        Console.WriteLine("Животное помещено в вольер для хищников");
                        break;
                    }else if(i == volierForPredator.Length-1 && volierForPredator[i] != null)
                    {
                        Console.WriteLine("Вольер c хищниками полон, убирите животное или расширьте вольер");
                    }
                }
            }else if (type.BaseType == typeof(HerbivoreAnimal))
            {
                for (int i = 0; i < volierForHerb.Length; i++)
                {
                    if (volierForHerb[i] == null)
                    {
                        volierForHerb[i] = animal;
                        Console.WriteLine("Животное помещено в вольер для травоядных");
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
}