using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.ViewModels
{
    public class EnterConferenceRoomInformationViewModel
    {
        [Required]
        [Display(Name = "Room ID")]
        public string RoomId { get; set; }
        [Required]
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Required]
        [Display(Name = "Building")]
        public string RoomBuilding { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string RoomPhoneNumber { get; set; }       
        [Display(Name = "A/V Capable?")]
        public bool RoomIsAVCapable { get; set; }
        [Required]
        [Display(Name = "Capacity")]
        public string RoomCapacity { get; set; }
        public bool EntrySuccessful { get; set; }
        public string Message { get; set; }
        public string Size { get; set; }

    }
}