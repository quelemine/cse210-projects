class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }
        Console.WriteLine();
    }
}