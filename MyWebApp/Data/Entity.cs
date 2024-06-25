public class Admin
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string EncryptedPassword { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class Article
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required string Category { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}

public class Subscriber
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public DateTime SubscribedAt { get; set; }
}

public class Pic
{
    public int Id { get; set; }
    public required string Path { get; set; }
    public int ArticleId { get; set; }
    public DateTime UploadedAt { get; set; }
}