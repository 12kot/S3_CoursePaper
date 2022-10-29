namespace S3_CoursePaper;
// Беспозвоночные
public abstract class Invertebrate : Animal
{
    private const string AnimalClass = "Беспозвоночное";
    private string AnimalType;

    protected Invertebrate(string name, int population, int age, string animalType) : base(name, population, age)
    {
        AnimalType = animalType;
    }
    
    public override string ToString()
    {
        return  $"{AnimalClass, 15}\t{AnimalType, 14}\t" + base.ToString();
    }
}