using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.ViewModels
{
    public class EnterBuildingInformationViewModel
    {
        [Required]
        [Display(Name = "Building ID")]
        public string BuildingId { get; set; }

        [Required]
        [Display(Name = "Building Name")]
        public string BuildingName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string MainBuildingPhoneNumber { get; set; }
        [Required]
        [Display(Name = "Floors")]
        public string NumberOfFloors { get; set; }
        [Required]
        [Display(Name = "Conference Rooms")]
        public string NumberOfConferenceRooms { get; set; }
        public bool EntrySuccessful { get; set; }
        public string Message { get; set; }
        public string Classification { get; set; }
        public string Type { get; set; }
    }
}