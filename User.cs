using System.ComponentModel;

namespace HomeWork6;
public class User
{
    private string _userName;
    private string _password;

    
    public string UserName
    {
        get { return _userName; }
        set
        {
            if (IsUserNameValid(value))
                _userName = value;
            else
                Console.WriteLine(" Username deyeri 6 ile 25 simvol arasinda olmalidir");
        }
    }
 
    public string Password
    {
        get { return _password; }
        set
        {
            if (IsPasswordValid(value))
                _password = value;
            else
                Console.WriteLine("Password deyeri 8 ile 25 simvol arasi olmali ve en azi 1 boyuk herf, 1 kicik herf ve 1 reqem olmalidir");
        }
    }

    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    private bool IsUserNameValid(string userName)
    {
        return !string.IsNullOrEmpty(userName) && userName.Length >= 6 && userName.Length <= 25;
    }

    private bool IsPasswordValid(string password)
    {
        return !string.IsNullOrEmpty(password) &&
               password.Length >= 8 && password.Length <= 25 &&
               HasUpper(password) && HasLower(password) && HasDigit(password);
    }

    private bool HasDigit(string value)
    {
        foreach (char c in value)
        {
            if (char.IsDigit(c))
                return true;
        }
        return false;
    }

    private bool HasUpper(string value)
    {
        foreach (char c in value)
        {
            if (char.IsUpper(c))
                return true;
        }
        return false;
    }

    private bool HasLower(string value)
    {
        foreach (char c in value)
        {
            if (char.IsLower(c))
                return true;
        }
        return false;
    }
}