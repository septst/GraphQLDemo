using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Models
{
    public enum RoomStatus
    {
        Unavailable = 0,
        Available = 1,
    }

    public class RoomViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public int Status { get; set; }

        public bool AllowedSmoking { get; set; }

        public RoomViewModel()
        {

        }
        public RoomViewModel(int number, string name, int status, bool allowedSmoking)
        {
            Number = number;
            Name = name;
            Status = status;
            AllowedSmoking = allowedSmoking;
        }
    }
}

