using CommunityToolkit.Mvvm.ComponentModel;

namespace ChatAI.ViewModels;

public partial class BaseViewModel : ObservableRecipient
{
    [ObservableProperty]
    bool isBusy;
}
