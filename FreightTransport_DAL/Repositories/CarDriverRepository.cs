﻿using FreightTransport_DAL.DBContext;
using FreightTransport_DAL.Entities;
using FreightTransport_DAL.Interfaces.IRepositories;

namespace FreightTransport_DAL.Repositories
{
    public class CarDriverRepository : GenericRepository<CarDriver>, ICarDriverRepository
    {
        public CarDriverRepository(FreightTransportDBContext context) : base(context)
        {

        }
    }
}