using System;
using petstore.Models;

namespace petstore
{
  class Program
  {
    static void Main(string[] args)
    {
      Dog Duke = new Dog("Duke", "Border-Collie", 3);
      Dog Milo = new Dog("Milo", "Pitbull", 3);
      Cat Jax = new Cat("Jax", "Tabby", 5);
      Cat Gertrude = new Cat("Gertrude", "Siamise", 2);
      Bird Taz = new Bird("Taz", "Cockatoo", 6);
      Bird Becky = new Bird("Becky", "Tucan", 1);
      PetStore PetLand = new PetStore();
      bool interested = true;
      PetLand.AddAnimal(Duke);
      PetLand.AddAnimal(Taz);
      PetLand.AddAnimal(Milo);
      PetLand.AddAnimal(Jax);
      PetLand.AddAnimal(Becky);
      PetLand.AddAnimal(Gertrude);
      Console.Clear();
      while (interested)
      {
        Console.WriteLine("Welcom to the PetLand Animal Shelter! We only have dogs, cats, and birds at the moment. Would you like to rescue an animal today? Or are you bringing one into our facility?");
        Console.WriteLine("A) Rescue");
        Console.WriteLine("B) Adding");
        string choice = Console.ReadLine();
        if (choice.ToLower() == "rescue")
        {
          Console.WriteLine("That's awesome! Thank you for saving a...");
          Console.WriteLine("A) Dog");
          Console.WriteLine("B) Bird");
          Console.WriteLine("C) Cat");
          string typeChoice2 = Console.ReadLine();
          if (typeChoice2.ToLower() == "dog")
          {
            Console.WriteLine("What is the name of the dog you would like to rescue?");
            PetLand.Dogs.ForEach(d => Console.WriteLine(d.Name));
            string dogName = Console.ReadLine();
            if (PetLand.BuyDog(dogName) == true)
            {
              PetLand.BuyDog(dogName);
              Console.WriteLine($"Congratulations! The paperwork went through and you are now the proud owner of {dogName}!  Is that all the business you have today? y/n");
              string continue2 = Console.ReadLine();
              if (continue2 == "y")
              {
                Console.WriteLine("Goodbye, thanks for coming in today!");
                interested = false;
              }
              else
              {
                Console.Clear();
              }
            }
            else
            {
              Console.WriteLine("I'm sorry we couldn't seem to find that particular animal.  Would you like to try again? y/n");
              string leave = Console.ReadLine();
              if (leave == "y")
              {
                Console.Clear();
              }
              else
              {
                Console.WriteLine("Goodbye, thanks for coming in today!");
                interested = false;
              }
            }
          }
          else if (typeChoice2.ToLower() == "bird")
          {
            Console.WriteLine("What is the name of the bird you would like to rescue?");
            string birdName = Console.ReadLine();
            if (PetLand.BuyBird(birdName) == true)
            {
              PetLand.BuyBird(birdName);
              Console.WriteLine($"Congratulations! The paperwork went through and you are now the proud owner of {birdName}!  Is that all the business you have today? y/n");
              string continue2 = Console.ReadLine();
              if (continue2 == "y")
              {
                Console.WriteLine("Goodbye, thanks for coming in today!");
                interested = false;
              }
              else
              {
                Console.Clear();
              }
            }
            else
            {
              Console.WriteLine("I'm sorry we couldn't seem to find that particular animal.  Would you like to try again? y/n");
              string leave = Console.ReadLine();
              if (leave == "y")
              {
                Console.Clear();
              }
              else
              {
                Console.WriteLine("Goodbye, thanks for coming in today!");
                interested = false;
              }
            }
          }
          else if (typeChoice2.ToLower() == "cat")
          {
            Console.WriteLine("What is the name of the cat you would like to rescue?");
            string catName = Console.ReadLine();
            PetLand.BuyCat(catName);
            if (PetLand.BuyCat(catName) == true)
            {
              PetLand.BuyCat(catName);
              Console.WriteLine($"Congratulations! The paperwork went through and you are now the proud owner of {catName}!  Is that all the business you have today? y/n");
              string continue2 = Console.ReadLine();
              if (continue2 == "y")
              {
                Console.WriteLine("Goodbye, thanks for coming in today!");
                interested = false;
              }
              else
              {
                Console.Clear();
              }
            }
            else
            {
              Console.WriteLine("I'm sorry we couldn't seem to find that particular animal.  Would you like to try again? y/n");
              string leave = Console.ReadLine();
              if (leave == "y")
              {
                Console.Clear();
              }
              else
              {
                Console.WriteLine("Goodbye, thanks for coming in today!");
                interested = false;
              }
            }
          }
          else
          {
            Console.WriteLine("That's not an option, do you want to exit? y/n");
            string decision2 = Console.ReadLine();
            if (decision2 == "y")
            {
              Console.WriteLine("Goodbye, thanks for coming in today!");
              interested = false;
            }
            else
            {
              Console.Clear();
            }
          }
        }
        else if (choice.ToLower() == "adding")
        {
          Console.WriteLine("We'll take great care of your...");
          Console.WriteLine("A) Dog");
          Console.WriteLine("B) Bird");
          Console.WriteLine("C) Cat");
          string typeChoice = Console.ReadLine();
          if (typeChoice.ToLower() == "dog")
          {
            Console.WriteLine("Okay perfect, I'm going to ask you some questions now to get some basic information.");
            Console.WriteLine("What is the dog's name?");
            string dogName = Console.ReadLine();
            Console.WriteLine($"What kind of breed is {dogName}?");
            string dogBreed = Console.ReadLine();
            Console.WriteLine($"And finally, how old is {dogName}");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            Dog Dog = new Dog($"{dogName}", $"{dogBreed}", dogAge);
            PetLand.AddAnimal(Dog);
            Console.WriteLine("Alright, your dog is processed and you are all set, would you like to exit? y/n");
            string continue1 = Console.ReadLine();
            if (continue1 == "y")
            {
              Console.WriteLine("Goodbye, thanks for coming in today!");
              interested = false;
            }
            else
            {
              Console.Clear();
            }
          }
          else if (typeChoice.ToLower() == "bird")
          {
            Console.WriteLine("Okay perfect, I'm going to ask you some questions now to get some basic information.");
            Console.WriteLine("What is the bird's name?");
            string birdName = Console.ReadLine();
            Console.WriteLine($"What kind of breed is {birdName}?");
            string birdBreed = Console.ReadLine();
            Console.WriteLine($"And finally, how old is {birdName}");
            int birdAge = Convert.ToInt32(Console.ReadLine());
            Bird Bird = new Bird($"{birdName}", $"{birdBreed}", birdAge);
            PetLand.AddAnimal(Bird);
            PetLand.Birds.ForEach(bird => Console.WriteLine(bird.Name));
            Console.WriteLine("Alright, your bird is processed and you are all set, would you like to exit? y/n");
            string continue1 = Console.ReadLine();
            if (continue1 == "y")
            {
              Console.WriteLine("Goodbye, thanks for coming in today!");
              interested = false;
            }
            else
            {
              Console.Clear();
            }
          }
          else if (typeChoice.ToLower() == "cat")
          {
            Console.WriteLine("Okay perfect, I'm going to ask you some questions now to get some basic information.");
            Console.WriteLine("What is the cat's name?");
            string catName = Console.ReadLine();
            Console.WriteLine($"What kind of breed is {catName}?");
            string catBreed = Console.ReadLine();
            Console.WriteLine($"And finally, how old is {catName}");
            int catAge = Convert.ToInt32(Console.ReadLine());
            Cat Cat = new Cat($"{catName}", $"{catBreed}", catAge);
            PetLand.AddAnimal(Cat);
            Console.WriteLine("Alright, your cat is processed and you are all set, would you like to exit? y/n");
            string continue1 = Console.ReadLine();
            if (continue1 == "y")
            {
              Console.WriteLine("Goodbye, thanks for coming in today!");
              interested = false;
            }
            else
            {
              Console.Clear();
            }
          }
          else
          {
            Console.WriteLine("That's not an option, do you want to exit? y/n");
            string decision2 = Console.ReadLine();
            if (decision2 == "y")
            {
              Console.WriteLine("Goodbye, thanks for coming in today!");
              interested = false;
            }
            else
            {
              Console.Clear();
            }
          }
        }
        else
        {
          Console.WriteLine("That's not an option, do you want to exit? y/n");
          string decision = Console.ReadLine();
          if (decision == "y")
          {
            Console.WriteLine("Goodbye, thanks for coming in today!");
            interested = false;
          }
          else
          {
            Console.Clear();
          }
        }

      }
    }
  }
}
