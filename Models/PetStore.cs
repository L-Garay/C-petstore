using System.Collections.Generic;

namespace petstore.Models
{
  class PetStore
  {
    public List<Dog> Dogs { get; private set; } = new List<Dog>();
    public List<Cat> Cats { get; private set; } = new List<Cat>();
    public List<Bird> Birds { get; private set; } = new List<Bird>();

    public void AddAnimal(Dog dog)
    {
      Dogs.Add(dog);
    }
    public void AddAnimal(List<Dog> dogs)
    {
      Dogs.AddRange(dogs);
    }

    public void AddAnimal(Cat cat)
    {
      Cats.Add(cat);
    }
    public void AddAnimal(List<Cat> cats)
    {
      Cats.AddRange(cats);
    }
    public void AddAnimal(Bird bird)
    {
      Birds.Add(bird);
    }
    public void AddAnimal(List<Bird> birds)
    {
      Birds.AddRange(birds);
    }
    public bool BuyDog(string name)
    {
      Dog dogToRemove = Dogs.Find(d => d.Name == name);
      if (dogToRemove != null)
      {
        Dogs.Remove(dogToRemove);
        bool bought = true;
        return bought;

      }
      else
      {
        bool bought = false;
        return bought;
      }

    }
    public bool BuyBird(string name)
    {
      Bird birdToRemove = Birds.Find(b => b.Name == name);
      if (birdToRemove != null)
      {
        Birds.Remove(birdToRemove);
        bool bought = true;
        return bought;

      }
      else
      {
        bool bought = false;
        return bought;
      }
    }
    public bool BuyCat(string name)
    {
      Cat catToRemove = Cats.Find(c => c.Name == name);
      if (catToRemove != null)
      {
        Cats.Remove(catToRemove);
        bool bought = true;
        return bought;

      }
      else
      {
        bool bought = false;
        return bought;
      }

    }
  }
}