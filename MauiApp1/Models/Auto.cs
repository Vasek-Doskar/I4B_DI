using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Models
{
    public class Auto
    {
        public int Id { get; set; }

        [Display(Name = "Značka")]
        public string Znacka { get; set; }
        public string Model { get; set; }
        public Palivo Palivo { get; set; }

        // Navigační vlastnosti pro EF
        public int? ClovekId { get; set; }
        public Clovek? Ridic {  get; set; }
        
    }
}
