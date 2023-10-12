namespace MauiApp4;

public partial class Page2 : ContentPage
{
    public Page2()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Page1?from=page2");
    }
}