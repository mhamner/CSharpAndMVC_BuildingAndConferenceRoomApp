using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.Models
{
    public class ConferenceRoomInformationModel
    {      
        public string RoomId { get; set; }       
        public string RoomName { get; set; }       
        public string RoomBuilding { get; set; }       
        public string RoomPhoneNumber { get; set; }       
        public bool RoomIsAVCapable { get; set; }       
        public string RoomCapacity { get; set; }
    }
}