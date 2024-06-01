namespace TodoApi.Models;

public class Movie
{

    public long Id { get; set; }
    public string? title { get; set; }
    public string? generos { get; set; }
    public string? url { get; set; }
    public int views { get; set; }
}