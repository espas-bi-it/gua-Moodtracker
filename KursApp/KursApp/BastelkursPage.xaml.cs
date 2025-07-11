namespace KursApp;

public partial class BastelkursPage : ContentPage
{
    public BastelkursPage()
    {
        InitializeComponent();
    }

    private async void OnZurueck2Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }


}