using System.Collections;

namespace Identity;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}

public class UserStore : IEnumerable
{
    private List<User> userList;

    public UserStore()
    {
        userList = new List<User>();
    }
    public IEnumerator GetEnumerator() => userList.GetEnumerator();
}
public enum Role{
    Administrator,Customer,Support
}