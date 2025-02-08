class Program
{
  static void Main(string[] args)
  {
    try
    {
      // Create a new Person instance
      Person person = new Person();

      // Get name input
      Console.Write("Enter your name: ");
      person.Name = Console.ReadLine();

      // Get age input
      Console.Write("Enter your age: ");
      if (int.TryParse(Console.ReadLine(), out int inputAge))
      {
        person.Age = inputAge;  // This might throw ArgumentException
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
      }
      else
      {
        throw new ArgumentException("Invalid age format. Please enter a number.");
      }
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
}
