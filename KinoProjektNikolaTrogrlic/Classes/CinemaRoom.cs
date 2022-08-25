using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Collections.Generic;

namespace KinoProjektNikolaTrogrlic
{
    public class CinemaRoom
    {

        public string Name { get; set; }

        public int SeatRows { get; set; }

        public int SeatColumns { get; set; }

        public List<MovieShowing> Showings { get; set; }

        public CinemaRoom()
        {
            Name = "CinemaRoom";
            SeatRows = 1;
            SeatColumns = 1;
            Showings = new List<MovieShowing>();
        }

        public CinemaRoom(string name,int rows,int columns)
        {
            Name = name;
            SeatRows = rows;
            SeatColumns = columns;
        }
    }
}
