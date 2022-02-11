// See https://aka.ms/new-console-template for more information
namespace MediaReviewSystem;

class Program 
{ 
    public static void Main(string[] args)
    {
        
        List<VideoMediaEntry> videoMediaEntries = new List<VideoMediaEntry>();
        addEntries(videoMediaEntries);

        Console.WriteLine("Hi what movie/tvShow do you want to search for?");
        string title = Console.ReadLine();

        VideoMediaEntry videoEntry;
        VideoMedia movie;

        foreach (VideoMediaEntry videoMediaEntry in videoMediaEntries)
        {
            videoEntry = videoMediaEntry;
            movie = videoEntry.Video;

            if (movie.Title.Equals(title))
            {
                videoEntry = videoMediaEntry;
                movie = videoEntry.Video;
                AddVideoReview(videoEntry);
                ViewVideoReviews(videoEntry);

                break;
            }
            else
            {
                Console.WriteLine("Sorry what you are looking for does not exist");
            }   
        }

        void AddVideoReview(VideoMediaEntry entry)
        {
            Console.WriteLine("would you like to add a review to this? (y/n)");
            string response = Console.ReadLine();

            if (response.Equals("y"))
            {
                Console.WriteLine("What rating out of ten would you give the movie?");
                int score = int.Parse(Console.ReadLine());

                Console.WriteLine("please leave a written review below:");
                string writtenReview = Console.ReadLine();

                VideoMediaReview review = new VideoMediaReview(score, writtenReview);

                entry.Reviews.Add(review);
            }
            else
            {
                return;
            }
        }

        void ViewVideoReviews(VideoMediaEntry entry)
        {
            Console.WriteLine("Would you like to view the reviews for this movie?");
            string response = Console.ReadLine();

            if (response.Equals("y"))
            {
                Console.WriteLine("- - - - - - - - -");
                foreach (VideoMediaReview reviews in entry.Reviews)
                {
                    Console.WriteLine("Rating " + reviews.GetRating() + "/10");
                    Console.WriteLine(reviews.WritenReview);
                    Console.WriteLine("- - - - - - - - -");
                }
            }
            else
            {
                return;
            }
        }

        void addEntries(List<VideoMediaEntry> videolist)
        {
            VideoMediaReview testReview = new VideoMediaReview(5, "Movie Bad :(");

            Movie movie = new Movie("dark knight");
            movie.Genre = "action";

            VideoMediaEntry entry = new VideoMediaEntry(movie);
            entry.Reviews.Add(testReview);

            videolist.Add(entry);
        }
    }
}

