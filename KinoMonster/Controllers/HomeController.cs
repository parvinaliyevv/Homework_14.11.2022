namespace KinoMonster.Controllers;

public class HomeController : Controller
{
	public static List<Movie> Movies { get; set; }
	public static List<TvSeries> TvSeries { get; set; }
	public static List<Post> Posts { get; set; }


	static HomeController()
	{
		Movies = new List<Movie>()
		{
			new Movie()
			{
				Title = "Interstellar",
				Description = "When a drought leads to a food crisis, to collective and scientific meetings with the prospect of a wormhole (presumably connecting regions of space-time across a large distance) to travel, surpass the previous milestones for human space travel and relocate, possibly to another planet.",
				Producer = "Christopher Nolan",
				Rating = 8.1,
				Date = new DateTime(2014, 1, 1),
				ImageTitle = "inter.png",
                TrailerUrl = "https://www.youtube.com/embed/R5KHoE_8dgo?showinfo=0",
            },
            new Movie()
            {
                Title = "The Matrix",
                Description = "When a drought leads to a food crisis, to collective and scientific meetings with the prospect of a wormhole (presumably connecting regions of space-time across a large distance) to travel, surpass the previous milestones for human space travel and relocate, possibly to another planet.",
                Rating = 8.0,
                Date = new DateTime(1999, 1, 1),    
                ImageTitle = "matrix.png",
            },
            new Movie()
            {
                Title = "Mad Max",
                Description = "When a drought leads to a food crisis, to collective and scientific meetings with the prospect of a wormhole (presumably connecting regions of space-time across a large distance) to travel, surpass the previous milestones for human space travel and relocate, possibly to another planet.",
                Rating = 7.5,
                Date = new DateTime(2015, 1, 1),
                ImageTitle = "max.png",
            },
            new Movie()
            {
                Title = "Cloud Atlas",
                Description = "When a drought leads to a food crisis, to collective and scientific meetings with the prospect of a wormhole (presumably connecting regions of space-time across a large distance) to travel, surpass the previous milestones for human space travel and relocate, possibly to another planet.",
                Rating = 7.4,
                Date = new DateTime(2013, 1, 1),
                ImageTitle = "cloud.png",
            },
        };

		TvSeries = new List<TvSeries>()
        {
            new TvSeries("Walking Dead", 8.1, "dead.png"),
            new TvSeries("Silicon Valley", 8.0, "silicon.png"),
            new TvSeries("Breaking Bad", 7.5, "breakingbad.png"),
            new TvSeries("The X-Files", 7.4, "xfiles.png"),
        };

		Posts = new List<Post>()
        {
            new Post("How was Interstellar filmed?", "Christopher Nolan is 45 years old, he is one of the most successful directors of our time, whose work is equally loved by both discerning critics and ordinary viewers. The film was originally produced by Paramount Studios. When Christopher Nolan took over as director, Warner Bros., the studio behind his last films, got a spot on the project."),
            new Post("Actor Tom Hanks shared his impressions of the festival", "The 67th British Academy Film Awards took place on February 16 in London. Leonardo DiCaprio, Brad Pitt, Angelina Jolie, Cate Blanchett, Helen Mirren, Amy Adams, Christian Bale, Alfonso Cuaron and other guests and winners of the award - in our report.."),
        };
    }


	public IActionResult Index()
	{
		ViewData["Movies"] = Movies;
		ViewData["Series"] = TvSeries;
		ViewData["Posts"] = Posts;

		return View();
	}

	public IActionResult ShowMovie(int index)
        => RedirectToAction("Watch", "Movies", new { index = index });

	public IActionResult ShowTvSeries(int index)
        => Content("Not working yet");

	public IActionResult ShowPost(int index)
        => Content("Not working yet");
}
