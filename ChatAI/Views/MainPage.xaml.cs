using ChatAI.Services;
using ChatAI.ViewModels;
using Microsoft.Maui.Controls;

namespace ChatAI;

public partial class MainPage : ContentPage
{
	private MainViewModel viewModel { get; }

	public MainPage(IChatService chatService)
	{
		this.BindingContext = viewModel = new MainViewModel(chatService);
        InitializeComponent();
    }

}

