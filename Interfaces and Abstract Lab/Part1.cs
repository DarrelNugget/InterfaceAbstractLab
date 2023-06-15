
abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public abstract void Eat();
}

interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    double Height { get; set; }
    int Age { get; set; }

    void Eat();
    string Cry();

}

class Dog : Animal, IAnimal
{
    public double Height { get; set; }
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

class Cat : Animal, IAnimal
{
    public double Height { get; set; }
    public override void Eat()
    {
        Console.WriteLine("Cats eat meat.");
    }

    public string Cry()
    {
        return "Meow!";
    }
}

class Part1
{
    static void Main()
    {
        //Dog Testing---------------------------------------------------------------
        Console.Write("Enter the dog's name: ");
        string doggyName = Console.ReadLine();
        Console.Write("Enter the dog's colour: ");
        string doggyColour = Console.ReadLine();
        Console.Write("Enter the dog's age: ");
        int doggyAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter dog height: ");
        int doggyHeight = int.Parse(Console.ReadLine());

        Dog testDog = new Dog();
        testDog.Name = doggyName;
        testDog.Colour = doggyColour;
        testDog.Age = doggyAge;
        testDog.Height = doggyHeight;

        Console.WriteLine("Dog's Infomaitons");
        Console.WriteLine("Name: " + testDog.Name);
        Console.WriteLine("Colour: " + testDog.Colour);
        Console.WriteLine("Age: " + testDog.Age);
        testDog.Eat();
        Console.WriteLine("Cry: " + testDog.Cry());

        //Cat Testing---------------------------------------------------------------
        Console.Write("Enter the cat's name: ");
        string catName = Console.ReadLine();
        Console.Write("Enter the cat's colour: ");
        string catColour = Console.ReadLine();
        Console.Write("Enter the cat's age: ");
        int catAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter cat height: ");
        int catHeight = int.Parse(Console.ReadLine());
        
        Cat testCat = new Cat();
        testDog.Name = catName;
        testDog.Colour = catColour;
        testDog.Age = catAge;
        testCat.Height = catHeight;
        
        Console.WriteLine("cat's Infomaitons");
        Console.WriteLine("Name: " + testCat.Name);
        Console.WriteLine("Colour: " + testCat.Colour);
        Console.WriteLine("Age: " + testCat.Age);
        testCat.Eat();
        Console.WriteLine("Cry: " + testCat.Cry());


        //List to print all animals-------------------------------------------------
        List<Animal> animals = new List<Animal>();
        animals.Add(testDog);
        animals.Add(testCat);

        Console.WriteLine("List of all animals names: ");
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}