namespace Zoo
{
    //****************  Animal class ***************
    class Animal
    {
        public string Name;
        private string Species;
        public string Diet;

        public Animal(string name, string species, string diet)
        {
            Name = name;
            Species = species;
            Diet = diet;
        }
        

        public static string MakeSound()
        {
            return "Meow";
        }

        public string GetSpecies()
        {
            return Species;
        }
    }

    //****************** ZooKeeper Class *****************
    class ZooKeeper
    {
        public string Name;

        public ZooKeeper(string name)
        {
            Name = name;
        }

        public void FeedAnimal(Animal animal)
        {
            Console.WriteLine($"{Name} is feeding {animal.Name}");
        }
    }

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal cat = new Animal("Candy", "Cat", "Herbivore");
            Animal dog = new Animal("Taicen", "Dog", "Carnivore");
            Animal lion = new Animal("Sultan","Lion", "Omnivore");
            Animal elephant = new Animal("Hathi", "Elephant", "Herbivore");
            Animal tiger = new Animal("Sheru","Tiger", "Carnivore");
            Animal giraffe = new Animal("Lambu", "Giraffe", "Omnivore");

            animals.Add(cat);
            animals.Add(dog);
            animals.Add(lion);
            animals.Add(elephant);
            animals.Add(tiger);
            animals.Add(giraffe);

            foreach (var animal in animals)
            {
                Console.WriteLine($"Name is {animal.Name}, species is {animal.GetSpecies()}  and the diet is  {animal.Diet}");
            }

            ZooKeeper zooKeeper = new ZooKeeper("Marcus");
            foreach (var animal in animals)
            {
                zooKeeper.FeedAnimal(animal);
            }

            /*Console.WriteLine($"Name is {cat.Name}, species is {cat.GetSpecies()}  and the diet is  {cat.Diet}");
            Console.WriteLine($"Name is {dog.Name}, species is {dog.GetSpecies()} and the diet is {dog.Diet}");
            Console.WriteLine($"Name is {lion.Name}, species is {lion.GetSpecies()} and the diet is {lion.Diet}");
            Console.WriteLine($"Name is {elephant.Name}, species is {elephant.GetSpecies()}   and the diet is   {elephant.Diet}");
            Console.WriteLine($"Name is {tiger.Name}, species is {tiger.GetSpecies()} and the diet is {tiger.Diet}");
            Console.WriteLine($"Name is {giraffe.Name}, species is {giraffe.GetSpecies()}    and the diet is    {giraffe.Diet}");*/
        }
    }
}