namespace petstore.Models
{
  class Dog
  {
    public string Name { get; private set; }
    public string Breed { get; private set; }
    public int Age { get; private set; }

    public Dog(string name, string breed, int age)
    {
      Name = name;
      Breed = breed;
      Age = age;
    }

  }
}