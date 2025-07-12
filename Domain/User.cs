using System.Text.RegularExpressions;
using Domain;
using Enums;

public class User
{
    private int _id;
    private string _name;
    private string _email;
    private string _password;
    private RoleType _role;
    private DateTime _registrationDate;
    private List<Review> _reviews = new();
    private List<Favorite> _favorites = new();

    public int Id
    {
        get => _id;
        set => _id = value;
    }

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

    public string Email
    {
        get => _email;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Email cannot be null or empty.");

            if (!IsValidEmail(value))
                throw new ArgumentException("Email format is invalid.", nameof(value));

            _email = value;
        }
    }

    private bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    public string Password
    {
        get => _password;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Password cannot be null or empty.");

            if (value.Length < 8)
                throw new ArgumentException("Password must be at least 8 characters long.", nameof(value));

            _password = value;
        }
    }

    public RoleType Role
    {
        get => _role;
        set => _role = value;
    }

    public DateTime RegistrationDate
    {
        get => _registrationDate;
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Registration date cannot be in the future.", nameof(value));
            _registrationDate = value;
        }
    }

    public List<Review> Reviews
    {
        get => _reviews;
        set => _reviews = value ?? new List<Review>();
    }

    public List<Favorite> Favorites
    {
        get => _favorites;
        set => _favorites = value ?? new List<Favorite>();
    }
}
