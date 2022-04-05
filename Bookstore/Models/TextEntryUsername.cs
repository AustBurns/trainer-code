using System.ComponentModel.DataAnnotations;

namespace Models;

public abstract class TextEntryUsername
{
    private string username = "";
    public string Username

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
