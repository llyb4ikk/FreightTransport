﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreightTransport_DAL.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public ICollection<Route> DestinationCities { get; set; }
        public ICollection<Route> StartCities { get; set; }
    }
}
