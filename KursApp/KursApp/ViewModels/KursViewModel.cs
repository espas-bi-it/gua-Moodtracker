using System.Collections.ObjectModel;
using System.Text.Json;
using KursApp.Models;

namespace KursApp.ViewModels
{
    public class KursViewModel
    {
        public ObservableCollection<Kurs> Kurse { get; set; } = new();

        public KursViewModel()
        {
            // Test veri
            // Kurse.Add(new Kurs
            // {
            // Name = "Testkurs",
            // Description = "Nur zum Testen",
            //Date = "2025-08-01",
            //Location = "Irgendwo"
            //});

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Console.WriteLine(">>> LoadData() gestartet");

                using var stream = FileSystem.OpenAppPackageFileAsync("kursdaten.json").Result;
                using var reader = new StreamReader(stream);
                var jsonString = reader.ReadToEnd();

                Console.WriteLine(">>> Inhalt aus Datei:");
                Console.WriteLine(jsonString);

                var daten = JsonSerializer.Deserialize<KursDaten>(jsonString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (daten != null && daten.Courses != null)
                {
                    foreach (var kurs in daten.Courses)
                    {
                        Console.WriteLine(">>> GEFUNDEN: " + kurs.Name);
                        Kurse.Add(kurs);
                    }
                }
                else
                {
                    Console.WriteLine(">>> Daten = NULL");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>> FEHLER beim Lesen: " + ex.Message);
            }
        }

       
        }



    
}



