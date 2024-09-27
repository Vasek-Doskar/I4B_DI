namespace MauiApp1.Models
{
    public class Clovek
    {
        public int Id { get; set; }
        
        public string Jmeno { get; set; }

        public virtual ICollection<Auto>? Auta {  get; set; }

        public override string? ToString()
        {
            return $"{Jmeno}";
        }
    }
}
