namespace LuckySpin.Models
{
    public class Spin
    {
        public long SpinId { get; set; }

        public bool IsWinning { get; set; }

        public Player Player { get; set; }

        public decimal CurrentBalance { get; set; }

        public int[] Numbers { get; set; }


    }

}
