using System;
using login.Models;

namespace login {
  class Program {
    static void Main(string[] args) {
      App app = new App();

      Console.Clear();
      Console.WriteLine("You must be logged in to continue.");
      while (!app.LoggedIn) {
        Console.Write("\n");
        app.LoginMenu();
      }
    }
  }
}
