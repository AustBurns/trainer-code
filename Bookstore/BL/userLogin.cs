using DL;
namespace BL;

public class userLogin
{
    public void CreateUser(User userToCreate) => allUsers.Users.Add(userToCreate);
    
    public List<User> GetUsers() => allUsers.Users;
}


