namespace KinoMonster.ViewComponents;

public class NewViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var model = new New("Released the film 'The Resurrection Matrix'", DateTime.Parse("12.18.2021"));

        return View(model);
    }
}
