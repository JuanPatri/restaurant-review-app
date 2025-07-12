using System.Text.RegularExpressions;
using Enums;

namespace Domain;

public class User
{
    private int _id { get; set; }
    private string _name { get; set; }
    private string _email { get; set; }
    private string _password { get; set; }
    private RoleType _role { get; set; }
    private List<Review> _reviews { get; set; }
    private DateTime _registrationDate { get; set; }
    private List<Favorite> _favorites { get; set; }

    public int Id{ get => _id; set => _id = value; }
    
    public string Name
    {
        get => _name;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Name cannot be null, empty, or whitespace.");

            _name = value;
        }
    }

    private bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
    public string Email
    {
        get => _email;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Email cannot be null or empty.");

            if (!IsValidEmail(value))
                throw new ArgumentException("Email format is invalid.", nameof(value));
        }
    }

    public string Password
    {
        get => _password;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Password cannot be null or empty.");
            
            if(value.Length < 8)
                throw new ArgumentException("Password must be at least 8 characters long.", nameof(value));
            
            _password = value;
        }
    }
    
    public RoleType Role { get => _role; set => _role = value; }
    
    public List<Review> Reviews { get => _reviews; set => _reviews = value; }
    
    public DateTime RegistrationDate { get => _registrationDate;
        set
        {
            if(value > DateTime.Now)
                throw new ArgumentException("Registration date cannot be in the future.", nameof(value));
            _registrationDate = value; 
        } 
    }
    
    public List<Favorite> Favorites { get => _favorites; set => _favorites = value; }
}