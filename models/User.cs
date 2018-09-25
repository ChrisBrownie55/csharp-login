using System;

namespace login.Models {
  public class User {
    public Guid _id { get; private set; } = Guid.NewGuid();
    public string Username { get; private set; }
    public string Password { get; private set; }

    public bool ValidatePassword(string password) {
      return password == Password;
    }

    public User(string username, string password) {
      Username = username;
      Password = password;
    }
  }
}