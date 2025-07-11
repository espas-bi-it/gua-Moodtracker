using KursApp.Models;
using System.Text.Json;

namespace KursApp;

public partial class FeedbackPage : ContentPage
{
    private Kurs? course;

    public object KursNameLabel { get; }

    public FeedbackPage(string kursName)
    {
        InitializeComponent();

        // Örnek olarak sadece kurs adını gösteriyoruz:
       
    }
 

    private async void LoadCourseData(string kursName)
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("kursdaten.json");
        using var reader = new StreamReader(stream);
        var json = await reader.ReadToEndAsync();

        var courses = JsonSerializer.Deserialize<List<Kurs>>(json);
        course = courses?.FirstOrDefault(c => c.Name == kursName);

        if (course != null)
        {
            CourseTitle.Text = course.Name;
            CourseDescription.Text = course.Description;
            QuestionLabel.Text = course.Feedback?.Hint;

            EmojiLayout.Children.Clear();

            var emojis = new[] { "⭐", "😊", "😡" };
            foreach (var emoji in emojis)
            {
                EmojiLayout.Children.Add(new Label { Text = emoji, FontSize = 30 });
            }
        }
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string feedback = FeedbackEntry.Text;
        DisplayAlert("Danke!", "Ihre Rückmeldung wurde gespeichert.", "OK");
    }

    private void OnEmojiButtonClicked(object sender, EventArgs e)
    {
        string feedback = FeedbackEntry.Text;
        DisplayAlert("Danke!", "Ihre Rückmeldung wurde gespeichert.", "OK");
    }

    private async void OnZurueckClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }




}
