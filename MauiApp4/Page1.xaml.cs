namespace MauiApp4;

public partial class Page1 : ContentPage, IQueryAttributable
{
    public Page1()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("from", out var parameter))
        {
            Label2.Text = $"From {parameter}";
        }
        else
        {
            Label2.Text = string.Empty;
        }
    }
}