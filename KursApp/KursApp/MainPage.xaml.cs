namespace KursApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSportkursButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FeedbackPage("sportkurs"));
    }



};