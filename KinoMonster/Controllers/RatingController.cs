namespace KinoMonster.Controllers;

public class RatingController : Controller
{
	public IActionResult Index()
	{
        ViewData["Movies"] = HomeController.Movies;

        return View();
    }

    public IActionResult ShowMovie(int index)
        => RedirectToAction("Watch", "Movies", new { index = index });
}
