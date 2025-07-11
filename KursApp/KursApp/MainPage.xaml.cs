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

    private async void OnSportkursButton2Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SportkursPage());
    }

    private async void OnBastelkursButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BastelkursPage());
    }


};