namespace KursApp;

public partial class SportkursPage : ContentPage
{
    public SportkursPage()
    {
        InitializeComponent();
    }

    private async void OnZurueck2Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }


}
