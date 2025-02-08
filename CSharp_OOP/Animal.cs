using System;
using System.Collections.Generic;

// Interface definition
public interface IPet
{
  void Play();
}

// Abstract base class
public abstract class Animal
{
  public string Name { get; set; }

  protected Animal(string name)
  {
    Name = name;
  }

  // Abstract method that must be implemented by derived classes
  public abstract void MakeSound();

  // Virtual method that can be overridden by derived classes
  public virtual string Describe()
  {
    return $"Describe: This is {Name}, an animal.";
  }
}

// Dog class implementing Animal and IPet
public class Dog : Animal, IPet
{
  public Dog(string name) : base(name) { }

  public override void MakeSound()
  {
    Console.WriteLine($"{Name} says: Bark! Bark!");
  }

  public override string Describe()
  {
    return $"{Name} is a friendly dog who loves to play fetch.";
  }

  public void Play()
  {
    Console.WriteLine($"{Name} is fetching the ball.");
  }
}

// Cat class implementing Animal and IPet
public class Cat : Animal, IPet
{
  public Cat(string name) : base(name) { }

  public override void MakeSound()
  {
    Console.WriteLine($"{Name} says: Meow!");
  }

  public override string Describe()
  {
    return $"{Name} is a curious cat who posses very strong reflexes.";
  }

  public void Play()
  {
    Console.WriteLine($"{Name} is playing with a ball of yarn.");
  }
}

