using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTOs
{
    public class BuildingInformationDTO
    {
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string BuildingPhoneNumber { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfConferenceRooms { get; set; }
    }
}
