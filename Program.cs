namespace MediaReviewSystem;

public class Program 
{
    public List<VideoMediaEntry> videoMediaEntries = new List<VideoMediaEntry>();
    public List<VideoMediaCreator> videoMediaCreators = new List<VideoMediaCreator>();

    public static void Main(string[] args)
    {
        Program program = new Program();
       
        /// this method is only used for testing
        program.AddEntries();
        ///

        program.GiveOptions();
    }

    void GiveOptions()
    {
        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] Search for movie/TV show");
            Console.WriteLine("[2] Search through genre");
            Console.WriteLine("[3] Search for Actor/Writer/Director");
            Console.WriteLine("[0] exit");

            switch (Console.ReadLine())
            {
                case "0":
                    repeat = false;
                    break;
                case "1":
                    Console.WriteLine("What movie/tvShow do you want to search for?");
                    VideoOptions(VideoSearchByTitle(videoMediaEntries, Console.ReadLine()));
                    break;
                case "2":
                    // TODO Add search by genres
                    break;
                case "3":
                    Console.WriteLine("Who are you searching for?");
                    CreatorOptions(SearchforPerson(Console.ReadLine()));
                    break;
                default:
                    break;
            }
        }
    }

    VideoMediaEntry VideoSearchByTitle(List<VideoMediaEntry> videoEntries, string title)
    {
        foreach (VideoMediaEntry videoMediaEntry in videoMediaEntries)
        {
            if (videoMediaEntry.Video.Title.Equals(title))
            {
                return videoMediaEntry;
            }
        }

        Console.WriteLine("Sorry what you are looking for does not exist");
        return null;
    }

    VideoMediaCreator SearchforPerson(string name)
    {
        foreach (VideoMediaCreator videoMediaCreator in videoMediaCreators)
        {
            if (videoMediaCreator.Name.Equals(name))
            {
                return videoMediaCreator;
            }
        }

        Console.WriteLine("Sorry the person you are looking ");
        return null;
    }

    void VideoOptions(VideoMediaEntry videoMediaEntry)
    {
        if (videoMediaEntry != null)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[1] View details");
                Console.WriteLine("[2] Add a review");
                Console.WriteLine("[3] View Reviews");
                Console.WriteLine("[0] exit");

                switch (Console.ReadLine())
                {
                    case "0":
                        repeat = false;
                        break;
                    case "1":
                        Console.WriteLine(videoMediaEntry.Video.ToString());
                        break;
                    case "2":
                        AddVideoReview(videoMediaEntry);
                        break;
                    case "3":
                        ViewVideoReviews(videoMediaEntry);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    void CreatorOptions(VideoMediaCreator videoMediaCreator)
    {
        if (videoMediaCreator != null)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[1] View details");
                Console.WriteLine("[2] View Projects they worked on");
                Console.WriteLine("[0] exit");

                switch (Console.ReadLine())
                {
                    case "0":
                        repeat = false;
                        break;
                    case "1":
                        Console.WriteLine("Decription = " + videoMediaCreator.Description);
                        break;
                    case "2":
                        ListMedia(videoMediaCreator.MediaWorkedOn);

                        Console.WriteLine("Do you want to find out more about these any of these movies? [y/n]");
                        if (Console.ReadLine().Equals("y"))
                        {
                            Console.WriteLine("Which one? [enter number code]");
                            VideoOptions(videoMediaCreator.MediaWorkedOn[int.Parse(Console.ReadLine())]);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }

    void ListMedia(List<VideoMediaEntry> videoMediaEntries)
    {
        int index = 0;
        foreach (VideoMediaEntry entry in videoMediaEntries)
        {
            Console.WriteLine("[" + index + "] " + entry.Video.Title);
            index++;
        }
    }

    void AddVideoReview(VideoMediaEntry entry)
    {
        Console.WriteLine("What rating out of ten would you give the movie?");
        int score = int.Parse(Console.ReadLine());

        Console.WriteLine("please leave a written review below:");
        string writtenReview = Console.ReadLine();

        VideoMediaReview review = new VideoMediaReview(score, writtenReview);

        entry.Reviews.Add(review);
    }

    void ViewVideoReviews(VideoMediaEntry entry)
    {
        Console.WriteLine("- - - - - - - - -");
        foreach (VideoMediaReview reviews in entry.Reviews)
        {
            Console.WriteLine(reviews.ToString());
            Console.WriteLine("- - - - - - - - -");
        }
    }

    void AddEntries()
    {
        Actor actor = new Actor("christian bale");

        VideoMediaReview testReview = new VideoMediaReview(5, "Movie Bad :(");

        Movie movie = new Movie("dark knight");
        movie.Genre = "action";
        movie.RunTime = new TimeOnly(2, 32);
        movie.synopsis = "Batman punches Joker";

        Movie movie2 = new Movie("american psysho");


        videoMediaCreators.Add(actor);

        VideoMediaEntry entry = new VideoMediaEntry(movie);
        entry.Reviews.Add(testReview);

        VideoMediaEntry entry2 = new VideoMediaEntry(movie2);

        actor.MediaWorkedOn.Add(entry);
        actor.MediaWorkedOn.Add(entry2);

        videoMediaEntries.Add(entry);
    }
}

// TODO search by actor/director/writer and genre
// TODO allow admin user to add a movie if the one they are searching for doesn't exist
// TODO Add user class and the serach class to remove complexity in this file
// TODO Validate Inputs 

