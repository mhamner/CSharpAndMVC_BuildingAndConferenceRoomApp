using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.ViewModels
{
    public class ViewBuildingInformationViewModel
    {
        [Display(Name = "Building ID")]
        public string BuildingId { get; set; }
        [Display(Name = "Building Name")]
        public string BuildingName { get; set; }
        [Display(Name = "Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        [Display(Name = "Phone Number")]
        public string MainBuildingPhoneNumber { get; set; }
        [Display(Name = "Floors")]
        public string NumberOfFloors { get; set; }
        [Display(Name = "Conference Rooms")]
        public string NumberOfConferenceRooms { get; set; }
    }
}