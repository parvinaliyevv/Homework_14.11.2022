namespace KinoMonster.Models;

public class New
{
	public string Title { get; set; }

	public DateTime Date { get; set; }


    public New(string title, DateTime date)
    {
        Title = title;
        Date = date;
    }
}
