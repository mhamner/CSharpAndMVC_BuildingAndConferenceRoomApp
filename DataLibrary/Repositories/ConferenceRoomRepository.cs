using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DataLibrary.DataAccessLayer;
using DataLibrary.DTOs;

namespace DataLibrary.Repositories
{
    public class ConferenceRoomRepository
    {
        public List<ConferenceRoomInformationDTO> GetAllConferenceRoomInformation()
        {
            List<ConferenceRoomInformationDTO> conferenceRooms = new List<ConferenceRoomInformationDTO>();

            DataAccess dal = new DataAccess(ConfigurationManager.ConnectionStrings["CorporateAssetsConnection"].ConnectionString);

            //Create a Dictionary (key, value pairs) of paramaters and values for our stored proc to use in our DAL 
            //It will be empty since we are getting everything in this method
            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();

            //Call our DAL method to get the conference room information    
            DataTable conferenceRoomInfoTable = dal.PopulateDataTableViaStoredProcedure("spGetAllConferenceRoomInformation", paramDictionary);

            //Loop through our data table and populate the building info DTO
            foreach (DataRow row in conferenceRoomInfoTable.Rows)
            {
                ConferenceRoomInformationDTO conferenceRoomInformationDTO = new ConferenceRoomInformationDTO();

                conferenceRoomInformationDTO.ConferenceRoomId = Convert.ToInt32(row["ConferenceRoomId"]);
                conferenceRoomInformationDTO.ConferenceRoomName = row["ConferenceRoomName"].ToString();
                conferenceRoomInformationDTO.ConferenceRoomPhoneNumber = row["ConferenceRoomPhoneNumber"].ToString();
                conferenceRoomInformationDTO.Building = row["Building"].ToString();
                conferenceRoomInformationDTO.AVCapable = Convert.ToBoolean(row["AVCapable"]);
                conferenceRoomInformationDTO.Capacity = Convert.ToInt32(row["Capacity"]);

                //Add the conference room to the conference room list
                conferenceRooms.Add(conferenceRoomInformationDTO);
            }
            return conferenceRooms;
        }
    }
}
