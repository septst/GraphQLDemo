using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Models
{
    public class GuestViewModel
    {
		
			[Key]
			public int Id { get; set; }

			[Required]
			[StringLength(300)]
			public string Name { get; set; }

			public DateTime RegisterDate { get; set; }

			public GuestViewModel()
			{

			}

			public GuestViewModel(string name, DateTime registerDate)
			{
				Name = name;
				RegisterDate = registerDate;
			}
	}
}
