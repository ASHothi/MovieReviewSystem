using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public class TVShow : VideoMedia
    {
        public int numOfEpisodes { get; set; }
        public int numOfSeasons { get; set; }

        public TVShow(string title) : base(title)
        {
        }

        public override string ToString()
        {
            string decription = 
                "Title: " + Title + "\n" +
                "Genre: " + Genre + "\n" +
                "Release date: " + ReleaseDate.ToString() + "\n" +
                "Age Rating: " + AgeRating + "\n" +
                "Number of seasons: " + numOfSeasons + "\n" +
                "Number of episodes: " + numOfEpisodes + "\n" +
                "Synopsis: " + synopsis;

            return decription;
        }
    }
}
