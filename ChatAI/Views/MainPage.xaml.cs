using ChatAI.ViewModels;

namespace ChatAI;

public partial class MainPage : ContentPage
{
	private MainViewModel viewModel { get; }

	public MainPage()
	{
		this.BindingContext = viewModel = new MainViewModel();
		InitializeComponent();
	}
}

