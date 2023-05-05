using ChatAI.Models;
using ChatAI.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChatAI.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private readonly IChatService chatService;

    [ObservableProperty]
    string chatText;
    public ObservableCollection<Chat> ChatList { get; set; } = new();

    public MainViewModel(IChatService _chatService)
    {
        chatService = _chatService;
        ChatList.Clear();
    }

    [RelayCommand]
    async void Send()
    {
        if (string.IsNullOrEmpty(ChatText)) return;
        if (IsBusy) return;

        try
        {
            IsBusy = true;

            ChatList.Add(new Chat() { Id = Guid.NewGuid().ToString(), User = "Me", Message = ChatText, IsIncoming = false, Date = DateTime.Now });

            string response = await chatService.Get(ChatText);

            ChatText = string.Empty;

            if (!string.IsNullOrEmpty(response))
            {
                ChatList.Add(new Chat() { Id = Guid.NewGuid().ToString(), User = "AI", Message = response, IsIncoming = true, Date = DateTime.Now });
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            IsBusy = false;
        }
    }
}
