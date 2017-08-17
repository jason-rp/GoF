using System;

namespace RP.GOF.ChainOfResposibility.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public HotelType HotelType { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
