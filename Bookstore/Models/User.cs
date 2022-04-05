using System.ComponentModel.DataAnnotations;

namespace Models;
public class User : TextEntryUsername
{
    private string username = "";
    public string TextEntryUsername 
    { 
        get => username;
        set
        {
            if(String.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException("Username cannot be empty");
            }
            username = value;
        }
    }         
}