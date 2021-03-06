﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace AirExchangerMobile.Entities
{
    [JsonObject(IsReference = true)]
    public class Plane
    {
        public int PlaneId { get; set; }

        public int CompanyId { get; set; }

        public int PlaneModelId { get; set; }

        public double CostPerFlight { get; set; }

        public virtual PlaneModel PlaneModel { get; set; }

        public virtual Company Company { get; set; }

        public ICollection<RentPlane> Rents { get; set; }
    }
}
