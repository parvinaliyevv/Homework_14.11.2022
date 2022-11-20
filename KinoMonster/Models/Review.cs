namespace KinoMonster.Models;

public class Review
{
    public string UserName { get; set; }
    public string Content { get; set; }


    public Review(string userName, string content)
    {
        UserName = userName;
        Content = content;
    }
}
