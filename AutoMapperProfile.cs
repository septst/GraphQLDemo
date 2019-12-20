using GraphQLDemo.Entities;
using GraphQLDemo.Models;
using AutoMapper;

namespace GraphQLDemo
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Guest, GuestViewModel>().ReverseMap();
            CreateMap<Room, RoomViewModel>().ReverseMap();
            CreateMap<Reservation, ReservationViewModel>().ReverseMap();

        }
    }
}
