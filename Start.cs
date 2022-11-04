// See https://aka.ms/new-console-template for more information
namespace S3_CoursePaper;

public static class Start
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        Animal an = AddAnimal();
        
        if(an != null)
            animals.Add(an);
        
        RemoveAnimal(animals); 
        Display(Search(animals));
        
       /* animals.Sort((x, y) => x.Age.CompareTo(y.Age));
        animals.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
        animals.Sort((x, y) => x.Population.CompareTo(y.Population));
       
       интерфейс для кого что делает. метод move. Рыба плавает. кто-то ходит. что-то бегает
       сложная сортировка. Сортировка по нескольким компонентам */
    }
    private static void Menu()
    {
        Console.WriteLine("1. Добавить морского обитателя.\n" +
                          "2. Удалить морского обитателя.\n" +
                          "3. Вывести список морских обитателей.\n" +
                          "4. Поиск.\n" +
                          "5. Лёгкая сортировка.\n" +
                          "6. Сложная сортировка.\n");
    }
    
    private static Animal AddAnimal()
    {
        Console.WriteLine("Выберите тип морского обитателя:\n" +
                          "Членистоногое/Ракообразное/Млекопитающее/Рыба");
        string type = Console.ReadLine() ?? "undefined";
        
        Console.Write("Введите наименование морского обитаетеля: ");
        string name = Console.ReadLine() ?? "undefined";
        
        Console.Write("Введите популяцию морского обитателя: ");
        string population = Console.ReadLine() ?? "-1";
        
        Console.Write("Введите возраст: ");
        string age = Console.ReadLine() ?? "-1";
        
        Animal animal = null!;
  
        switch (type.ToLower())
        {
            case "членистоногое":
                animal = new Arthropod(name, Int32.Parse(population), Int32.Parse(age));
                break;
            case "ракообразное":
                animal = new Arthropod(name, Int32.Parse(population), Int32.Parse(age));
                break;
            case "млекопитающее":
                animal = new Arthropod(name, Int32.Parse(population), Int32.Parse(age));
                break;
            case "рыба":
                animal = new Arthropod(name, Int32.Parse(population), Int32.Parse(age));
                break;
            default:
                Console.WriteLine("Введён неверный тип. Повторите попытку: ");
                break;
        }

        return animal;
    }

    private static void RemoveAnimal(List<Animal> animals)
    {
        Display(animals);
        
        if(animals.Count == 0) return;
        
        Console.Write("Введите наименование морского обитателя: ");
        string name = Console.ReadLine() ?? "";

        foreach (var animal in animals.Where(animal => animal.Name.Equals(name)))
        {
            animals.Remove(animal);
            return;
        }
        
        Console.WriteLine("Морские обитатели с заданным наименованием не найдены.");
    }
    
    private static void Display(List<Animal> animals)
         {
             if(animals.Count == 0) Console.WriteLine("Животных нет.");
             
             foreach (var animal in animals)
             {
                 Console.WriteLine(animal);
             }
         }

    private static List<Animal> Search(List<Animal> animals)
    {
        if (animals.Count == 0)
            return new List<Animal>();
        
        Console.WriteLine("Введите имеющююся информацию через пробел:");
        
        string str = Console.ReadLine() ?? "";

        return (from animal in animals 
            from s in str.ToLower().Split(" ") 
            where animal.ToString().ToLower().Contains(s) select animal).ToList();
    }
}