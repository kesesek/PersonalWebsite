namespace MyWebApp.Models;

public class ArticleViewModel
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public bool Category { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
