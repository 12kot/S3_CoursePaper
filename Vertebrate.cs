namespace S3_CoursePaper;
// Позвоночные
public abstract class Vertebrate : Animal
{
    private const string AnimalClass = "Позвоночное";
    private string AnimalType;

    protected Vertebrate(string name, int population, int age, string animalType) : base(name, population, age)
    {
        AnimalType = animalType;
    }
    
    public override string ToString()
    {
        return $"{AnimalClass, 15}\t{AnimalType, 14}\t" + base.ToString();
    }
}