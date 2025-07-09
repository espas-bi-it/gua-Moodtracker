using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KursApp.Models
{
    public class KursDaten
    {
        public List<Kurs>? Courses { get; set; }
    }

    public class Kurs
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Location { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public int Age { get; set; }
        public string? Materials { get; set; }
        public Feedback? Feedback { get; set; }
        public int? Rating { get; set; }
        public string? Rating_Timestamp { get; set; }
        public string? Comment { get; set; }
    }

    public class Feedback
    {
        public bool Enabled { get; set; }
        public string? Type { get; set; }
        public string? Hint { get; set; }
    }

    public class KursDatenn
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public FeedbackInfo? Feedback { get; set; }
    }

    public class FeedbackInfo
    {
        public string? Question { get; set; }
        public List<string>? Emojis { get; set; }
    }

}
