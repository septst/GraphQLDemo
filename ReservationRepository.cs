using AutoMapper;
using AutoMapper.QueryableExtensions;
using GraphQLDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo
{
    public class ReservationRepository
    {
        private readonly MyHotelDbContext _myHotelDbContext;
        private readonly IMapper _mapper;
        public ReservationRepository(MyHotelDbContext myHotelDbContext, IMapper mapper)
        {
            _myHotelDbContext = myHotelDbContext;
            _mapper = mapper;
        }

        public async Task<List<T>> GetAll<T>()
        {
            return await _myHotelDbContext
                .Reservations
                .Include(x => x.Room)
                .Include(x => x.Guest)
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetAll()
        {
            return await _myHotelDbContext
                .Reservations
                .Include(x => x.Room)
                .Include(x => x.Guest)
                .ToListAsync();
        }
    }
}
