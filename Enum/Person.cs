public class Person
{
    public string PersonName { get; set; }
    public string Email { get; set; }
    public AgeGroupEnum AgeGroup { get; set; }
}

public enum AgeGroupEnum
{
    Child,
    Teenager,
    Adult,
    Senior
}