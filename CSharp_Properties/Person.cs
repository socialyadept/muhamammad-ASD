using System;

public class Person
{
  // Auto-implemented property for Name
  public string Name { get; set; }

  // Full property for Age with validation
  private int age;
  public int Age
  {
    get { return age; }
    set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Age must be a positive number.");
      }
      age = value;
    }
  }
}

