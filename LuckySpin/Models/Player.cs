namespace LuckySpin.Models
{
    public class Player
    {
        public long PlayerId { get; set; }
        public string Name { get; set; }

        public int Luck { get; set; }

        public decimal Balance { get; set; }

    }
}