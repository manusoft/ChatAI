namespace ChatAI.Models;

public class Chat
{
    public string Id { get; set; }
    public string User { get; set; }
    public string Message { get; set; }
    public bool IsIncoming { get; set; }
    public DateTime Date { get; set; }
}
