namespace KinoMonster.ViewComponents;

public class RatingViewComponent : ViewComponent
{
    public IViewComponentResult Invoke() => View(HomeController.Movies);
}
