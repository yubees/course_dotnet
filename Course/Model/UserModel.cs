

namespace Course.Model;


public class User {
    public string Name{get;}

    public string Email{get;}

    public string Password{get;}

    public User(string name, string email, string password){
            Name = name;
            Password = password;
            Email = email;


    }
    
}