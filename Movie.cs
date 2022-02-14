using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public class Movie : VideoMedia
    {
        public TimeOnly RunTime { get; set; }

        public Movie(string title) : base(title)
        {
        }

        public override string ToString()
        {
            string decription =
                "Title: " + Title + "\n" +
                "Genre: " + Genre + "\n" +
                "Release date: " + ReleaseDate.ToString() + "\n" +
                "RunTime: " + RunTime.ToString() + "\n" +
                "Age Rating: " + AgeRating + "\n" +
                "Synopsis: " + synopsis;

            return decription;
        }
    }
}
