using System;

class Program
{
  // Define constants for correct credentials
  private const string CORRECT_USERNAME = "Alice";
  private const string CORRECT_PASSWORD = "Wonderland123";

  static void Main(string[] args)
  {
    try
    {
      // Prompt for username
      Console.Write("Enter your username: ");
      string? username = Console.ReadLine();

      // Check if username is empty
      if (string.IsNullOrWhiteSpace(username))
      {
        throw new Exception("username cannot be empty");
      }

      // Prompt for password
      Console.Write("Enter your password: ");
      string? password = Console.ReadLine();

      // Check if password is empty
      if (string.IsNullOrWhiteSpace(password))
      {
        throw new Exception("password cannot be empty");
      }

      // Verify credentials
      if (username == CORRECT_USERNAME && password == CORRECT_PASSWORD)
      {
        Console.WriteLine($"Welcome, {username}! You have successfully logged in.");
      }
      else
      {
        Console.WriteLine("Login failed. Please check your username and password.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Unhandled Exception: {ex.GetType()}: {ex.Message}");
    }
  }
}
