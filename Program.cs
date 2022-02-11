namespace MediaReviewSystem;

class Program 
{ 
    public static void Main(string[] args)
    {
        
        List<VideoMediaEntry> videoMediaEntries = new List<VideoMediaEntry>();

        /// this method is only used for testing
        addEntries(videoMediaEntries);
        ///

        Console.WriteLine("Hi what movie/tvShow do you want to search for?");
        string title = Console.ReadLine().ToLower();

        VideoMediaEntry videoEntry;
        VideoMedia movie;

        foreach (VideoMediaEntry videoMediaEntry in videoMediaEntries)
        {
            videoEntry = videoMediaEntry;
            movie = videoEntry.Video;

            if (movie.Title.Equals(title))
            {
                bool repeat = true;

                while (repeat)
                {
                    videoEntry = videoMediaEntry;
                    movie = videoEntry.Video;

                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("View details = 1");
                    Console.WriteLine("Add a review = 2");
                    Console.WriteLine("View Reviews = 3");
                    Console.WriteLine("exit = 0");


                    switch (Console.ReadLine())
                    {
                        case "0":
                            repeat = false;
                            break;
                        case "1":
                            // TODO IMPLEMENT DETAILS FOR THE MOVIE
                            break;
                        case "2":
                            AddVideoReview(videoEntry);
                            break;
                        case "3":
                            ViewVideoReviews(videoEntry);
                            break;
                        default:
                            break;
                    }
                }
                
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
        }

        void ViewVideoReviews(VideoMediaEntry entry)
        {
            Console.WriteLine("Would you like to view the reviews for this movie? (y/n)");
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

// TODO search by actor/director/writer and genre
// TODO allow user to add a movie if the one they are searching for doesn't exist
// TODO Implement CASE 1 in the switch statement 
// TODO Add user class and the serach class to remove complexity in this file
// TODO Validate Inputs 

