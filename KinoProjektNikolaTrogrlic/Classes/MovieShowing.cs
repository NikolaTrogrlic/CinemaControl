using Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjektNikolaTrogrlic.Classes
{
    public class MovieShowing
    {
        public double TicketPrice { get; set; }
        public Movie MovieShown { get; set; }

        public DateTime StartTime { get; set; }

        public List<Seat> Seats { get; set; }

        public MovieShowing()
        {
            Seats = new List<Seat>();
        }

        public MovieShowing(Movie movie,DateTime start,int seats,double ticketprice)
        {
            MovieShown = movie;
            StartTime = start;
            Seats = new List<Seat>();
            for (int i = 0; i < seats; i++)
            {
                Seat seat = new Seat
                {
                    SeatStatus = SeatStatus.Free,
                    SeatNumber = i + 1
                };
                Seats.Add(seat);
            }
            TicketPrice = ticketprice;
        }

        public DateTime MovieEnding()
        {
            DateTime end = StartTime.Add(MovieShown.MovieDuration());
            return end;
        }

        public void RemoveIfEnd()
        {
            if (DateTime.Now - MovieEnding() > TimeSpan.Zero)
            {
                this.MovieShown = null;
            }
        }
    }
}
