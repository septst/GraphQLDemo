using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Models
{
    public class ReservationViewModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RoomId")]
        public RoomViewModel Room { get; set; }
        public int RoomId { get; set; }

        [ForeignKey("GuestId")]
        public GuestViewModel Guest { get; set; }
        public int GuestId { get; set; }

        [Required]
        public DateTime CheckinDate { get; set; }

        public DateTime CheckoutDate { get; set; }

        public ReservationViewModel()
        {

        }

        public ReservationViewModel(DateTime checkinDate, DateTime checkoutDate, int roomId, int guestId)
        {
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            RoomId = roomId;
            GuestId = guestId;
        }
    }
}

