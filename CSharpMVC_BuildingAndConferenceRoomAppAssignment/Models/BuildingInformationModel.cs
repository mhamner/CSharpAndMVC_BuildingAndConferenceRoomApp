using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.Models
{
    public class BuildingInformationModel
    {        
        public string BuildingId { get; set; }       
        public string BuildingName { get; set; }      
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }       
        public string MainBuildingPhoneNumber { get; set; }       
        public string NumberOfFloors { get; set; }       
        public string NumberOfConferenceRooms { get; set; }
    }
}