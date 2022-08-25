namespace KinoProjektNikolaTrogrlic
{
    public class Seat
    {

        public int SeatNumber { get; set; }

        public SeatStatus SeatStatus { get; set; }
    }

    public enum SeatStatus
    {
        Free,
        Taken,
        VIP,
        VIP_Taken,
        Broken
    }
}
