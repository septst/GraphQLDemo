using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQLDemo.Entities
{
       public class Room
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

        public Room()
        {

        }
        public Room(int number, string name, int status, bool allowedSmoking)
        {
            Number = number;
            Name = name;
            Status = status;
            AllowedSmoking = allowedSmoking;
        }
    }
}