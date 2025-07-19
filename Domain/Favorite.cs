namespace Domain;

public class Favorite
{
    private int _id;
    private User _user;
    private Restaurant _restaurant;
    private DateTime _date;


    public int Id { get => _id; set => _id = value; }

    public User User
    {
        get => _user;
        set => _user = value ?? throw new ArgumentNullException(nameof(value), "User cannot be null.");
    }

    public Restaurant Restaurant
    {
        get => _restaurant;
        set => _restaurant = value ?? throw new ArgumentNullException(nameof(value), "Restaurant cannot be null.");
    }

    public DateTime Date
    {
        get => _date;
        set
        {
            if (value == default)
                throw new ArgumentException("Date must be a valid date.", nameof(value));
            _date = value;
        }
    }
    
}