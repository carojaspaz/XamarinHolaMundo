namespace HolaMundo.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ShieldUrl { get; set; }
        public int BornYear { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Location}";
        }
    }
}
