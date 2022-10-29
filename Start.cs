// See https://aka.ms/new-console-template for more information
namespace S3_CoursePaper;

public static class Start
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        
        Animal mammal = new Mammal("Жук", 18, 2000);
        animals.Add(mammal);

        Animal fish = new Fish("Рыба", 20, 1000);
        animals.Add(fish);
        
        Animal arthropod = new Arthropod("Никита", 1, 18);
        animals.Add(arthropod);
        
        Animal crustacean = new Crustacean("Звезда", 456, 3456789);
        animals.Add(crustacean);

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}