using System.Reflection.Metadata;
using Enums;

namespace Domain;

public class Review
{
        private int _id;
        private Restaurant _restaurant;
        private string _comment;
        private int _score; 
        private User _user;
        private DateTime _date;

        public int Id { get => _id; set => _id = value; }

        public Restaurant Restaurant
        {
            get => _restaurant;
            set => _restaurant = value ?? throw new ArgumentNullException(nameof(value), "Restaurant cannot be null.");
        }

        public string Comment
        {
            get => _comment;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Comment cannot be null or empty.");
                if(value.Length > 500)
                    throw new ArgumentOutOfRangeException(nameof(value), "Comment cannot be longer than 500 characters.");
                _comment = value;
            }
        }

        public int Score
        {
            get => _score;
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentOutOfRangeException(nameof(value), "Score must be between 0 and 5.");
                _score = value;
            }
        }

        public User User
        {
            get => _user;
            set => _user = value ?? throw new ArgumentNullException(nameof(value), "User cannot be null.");
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value; 
        }
    }