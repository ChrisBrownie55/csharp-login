using System;
using System.Collections.Generic;
namespace login.Models {
  public class App {
    public bool LoggedIn { get; private set; }
    private Dictionary<string, User> Users = new Dictionary<string, User>();

    private bool Login(string username, string password) {
      return Users.ContainsKey(username) && Users[username].ValidatePassword(password);
    }

    private string[] GetUsernameAndPassword() {
      Console.Write("Username: ");
      string username = Console.ReadLine().ToLower();
      Console.Write("Password: ");
      string password = Console.ReadLine().ToLower();
      return new string[2] {username, password};
    }

    public void LoginMenu() {
      string[] user = GetUsernameAndPassword();
      string username = user[0];
      string password = user[1];
      LoggedIn = Login(username, password);

      Console.Clear();
      if (!LoggedIn) {
        Console.WriteLine("Invalid login.");
      } else {
        Console.WriteLine("Successfully logged in.");
      }
    }

    private bool Register(string username, string password) {
      return Users.TryAdd(username, new User(username, password));
    }

    public void RegisterMenu() {
      string[] user = GetUsernameAndPassword();
      string username = user[0];
      string password = user[1];
      LoggedIn = Register(username, password);

      Console.Clear();
      if (!LoggedIn) {
        if (Users.ContainsKey(username)) {
          Console.WriteLine("User already exists");
        } else {
          Console.WriteLine("Unable to register, sorry.");
        }
      } else {
        Console.WriteLine("Successfully registed.");
      }
    }

    public App() {
      Register("test_boi99", "a_passworD");
      Register("student", "a_studenT");
      Register("brazybio", "oibyzarb");
      Register("chris", "brown");
    }
  }
}