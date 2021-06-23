using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.ViewModels
{
    public class ViewConferenceRoomInformationViewModel
    {
        [Display(Name = "Room ID")]
        public string RoomId { get; set; }
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Display(Name = "Building")]
        public string RoomBuilding { get; set; }
        [Display(Name = "Phone Number")]
        public string RoomPhoneNumber { get; set; }
        [Display(Name = "A/V Capable?")]
        public bool RoomIsAVCapable { get; set; }
        [Display(Name = "Capacity")]
        public string RoomCapacity { get; set; }
    }
}