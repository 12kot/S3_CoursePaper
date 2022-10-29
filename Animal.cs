namespace S3_CoursePaper;

public abstract class Animal
{
    private readonly string _name;
    private readonly int _population;
    private readonly int _age;

    protected Animal(string name, int population, int age)
    {
        _name = name;
        _population = population;
        _age = age;
    }

    public override string ToString()
    {
        return $"{_name, 15}\t{_population, 10}\t{_age, 4}";
    }
}