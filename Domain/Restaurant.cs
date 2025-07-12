using Enums;

namespace Domain;

public class Restaurant
{
    private int _id;
    private string _name;
    private string _description;
    private Category _category;
    private Location _location;
    private List<Review> _reviews = new();
    private double _rating;

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

    public string Description
    {
        get => _description;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Description cannot be null, empty, or whitespace.");
            _description = value;
        }
    }

    public Category Category
    {
        get => _category;
        set => _category = value;
    }

    public Location Location
    {
        get => _location;
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Location cannot be null.");
            _location = value;
        }
    }

    public List<Review> Reviews
    {
        get => _reviews;
        set => _reviews = value ?? new List<Review>();
    }

    public double Rating
    {
        get => _rating;
        set
        {
            if (value < 0 || value > 5)
                throw new ArgumentOutOfRangeException(nameof(value), "Rating must be between 0 and 5.");
            _rating = value;
        }
    }
}