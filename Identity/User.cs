using System.Collections;

namespace Identity;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}

public class UserStore
{
    private List<User> userList;
    public UserStore()
    {
        userList = new List<User>();
    }

    public void RegisterCustomer(string login, string password, string discount, Role role) {
        if (!userList.Exists(user => user.Login == login))userList.Add(new Customer() 
        {
            Login=login,
            Password=password,
            Discount=discount,
            Role=role
        });
    }

    public void RegisterPerformer(string login, string password, string salary, Role role) {
        if (!userList.Exists(user => user.Login == login)) userList.Add(new Performer()
        {
            Login=login,
            Password=password,
            Salary=salary,
            Role=role
        });
    }

    public List<string> GetUserLogin() {
        var result = new List<string>();
        foreach (User u in userList) {
            result.Add(u.Login);
        }
        return result;
    }
    public User Authorizate(string login,string password) {
        var user = userList.Find(user => user.Login == login);
        if (user!=null&&user.Password==password) return user;
        return null;
    }
}
public class AuthBody{
    public string Login { get; set; }
    public string Password { get; set; }
    
}
public class Performer : User {
    public string Salary { get; set; }
}

public class Customer : User {
    public string Discount { get; set; }
}

public enum Role{
    Administrator,Customer,Support
}