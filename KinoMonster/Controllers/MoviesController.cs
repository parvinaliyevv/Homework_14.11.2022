namespace KinoMonster.Controllers;

public class MoviesController : Controller
{
	public IActionResult Index()
	{
        ViewData["Movies"] = HomeController.Movies;

        return View();
    }

    public IActionResult Watch(int index)
    {
        var movie = HomeController.Movies[index];

        SetReviews();

        return View(movie);
    }

    [NonAction]
    public void SetReviews()
    {
        var reviews = new List<Review>()
        {
            new Review("Albahari", "Great movie, 3 hours just flew by."),
            new Review("John Doe", "After movie 'Start', I was looking forward to new work from Christopher Nolan. Interstellar impressed me."),
        };

        ViewData["Reviews"] = reviews;
    }
}
