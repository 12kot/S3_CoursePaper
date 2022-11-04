namespace S3_CoursePaper;

public abstract class Animal
{
    public string Name { get; }
    public int Population { get; }
    public  int Age { get; }

    protected Animal(string name, int population, int age)
    {
        Name = name;
        Population = population;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name, 10}\t{Population, 10}\t{Age, 4}";
    }
}