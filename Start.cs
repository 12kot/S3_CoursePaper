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
        
        animals.Sort((x, y) => x.Age.CompareTo(y.Age));
       // animals.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
       // animals.Sort((x, y) => x.Population.CompareTo(y.Population));
       
       //сложный поиск. Поиск по нескольким компонентам ГОТОВО
       //интерфейс для кого что делает. метод move. Рыба плавает. кто-то ходит. что-то бегает
       //сложная сортировка. Сортировка по нескольким компонентам
       
       Display(Search(animals));
      // Display(animals);
    }

    private static string Input()
    {
        Console.WriteLine("По каким параметрам будем сортировать?\n" +
                          "1. Имя.\n" +
                          "2. Популяция.\n" +
                          "3. Возраст.\n" +
                          "4. Класс.\n" +
                          "5. Тип.\n");
        

        return Console.ReadLine() ?? "-1";
    }

    private static List<Animal> Search(List<Animal> animals)
    {
        string str;
        Console.WriteLine("Введите имеющююся информацию через пробел:\n");
        
        str = Console.ReadLine() ?? "";
        
        List<Animal> anS = new List<Animal>();
        foreach (var animal in animals)
        {
            foreach (var s in str.Split(" "))
            {
                if(animal.ToString().Contains(s)) 
                    anS.Add(animal);
            }
        }

        return anS;
    }
    
    private static void Display(List<Animal> animals)
    {
        if(animals.Count == 0) 
            Console.WriteLine("Животных нет.");
        
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}