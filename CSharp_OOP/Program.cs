class Program
{
  static void Main(string[] args)
  {
    // Create instances of Dog and Cat
    Dog dog = new Dog("Buddy");
    Cat cat = new Cat("Rosie");

    // Create a list of animals
    List<Animal> animals = new List<Animal> { dog, cat };

    // Iterate through the list and call methods
    Console.WriteLine("\n<------------Animal Information:------------>\n");
    foreach (Animal animal in animals)
    {
      Console.WriteLine(animal.Describe());
      animal.MakeSound();

      // Check if the animal is a pet and call Play()
      if (animal is IPet pet)
      {
        pet.Play();
      }
      Console.WriteLine("-------------------------------------");
    }
  }
}
