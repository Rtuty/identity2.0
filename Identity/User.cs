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

    public void Register(string login,string password,Role role)
    {
        if(!userList.Exists(user=>user.Login==login))userList.Add(new User()
        {
            Login=login,
            Password=password,
            Role=role
        });
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

public enum Role{
    Administrator,Customer,Support
}