namespace SwordAPP.Domain1
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Sword> Swords { get; set; } = new List<Sword>();
    }
}