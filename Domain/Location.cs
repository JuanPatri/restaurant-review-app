namespace Domain;

public class Location
{
    private string _address;
    private string _city;
    private string _country;
    private string _postalCode; 
    private double _latitude;
    private double _longitude;

    public string Address
    {
        get => _address;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Address cannot be null or empty.");
            _address = value;
        }
    }

    public string City
    {
        get => _city;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "City cannot be null or empty.");
            _city = value;
        }
    }

    public string Country
    {
        get => _country;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Country cannot be null or empty.");
            _country = value;
        }
    }

    public string PostalCode
    {
        get => _postalCode;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "PostalCode cannot be null or empty.");
            _postalCode = value;
        }
    }

    public double Latitude
    {
        get => _latitude;
        set
        {
            if (value < -90 || value > 90)
                throw new ArgumentOutOfRangeException(nameof(value), "Latitude must be between -90 and 90.");
            _latitude = value;
        }
    }

    public double Longitude
    {
        get => _longitude;
        set
        {
            if (value < -180 || value > 180)
                throw new ArgumentOutOfRangeException(nameof(value), "Longitude must be between -180 and 180.");
            _longitude = value;
        }
    }
}
