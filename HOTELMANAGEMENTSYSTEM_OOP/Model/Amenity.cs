using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELMANAGEMENTSYSTEM_OOP.Model
{
    public class Amenity
    {
        public int AmenityID { get; private set; }
        public string AmenityName { get; set; }
        public decimal AmenityPrice { get; set; }
        public string Description { get; set; }

        public Amenity(int amenityID, string amenityName, decimal amenityPrice, string description)
        {
            AmenityID = amenityID;
            AmenityName = amenityName;
            AmenityPrice = amenityPrice;
            Description = description;
        }
    }
}
