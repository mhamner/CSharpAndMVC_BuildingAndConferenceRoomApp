using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTOs
{
    public class ConferenceRoomInformationDTO
    {
        public int ConferenceRoomId { get; set; }
        public string ConferenceRoomName { get; set; }
        public string Building { get; set; }
        public string ConferenceRoomPhoneNumber { get; set; }
        public bool AVCapable { get; set; }
        public int Capacity { get; set; }
    }
}
