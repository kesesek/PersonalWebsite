public class Admin
{
    public int id { get; set; }
    public required string username { get; set; }
    public required string encryptedpassword { get; set; }
    public DateTime createdat { get; set; }
    public DateTime updatedat { get; set; }
}

public class Article
{
    public int id { get; set; }
    public required string title { get; set; }
    public required string content { get; set; }
    public required bool category { get; set; }
    public DateTime createat { get; set; }
    public DateTime updateat { get; set; }
}

public class Subscriber
{
    public int id { get; set; }
    public required string email { get; set; }
    public DateTime subscribedat { get; set; }
}

public class Pic
{
    public int id { get; set; }
    public required string path { get; set; }
    public int articleid { get; set; }
    public DateTime uploadedat { get; set; }
}