namespace ChatAI.Services;

public interface IChatService 
{
    Task<string> Get(string text);
}
