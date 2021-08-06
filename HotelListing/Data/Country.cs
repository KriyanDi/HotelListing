using HotelListing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShorName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}
