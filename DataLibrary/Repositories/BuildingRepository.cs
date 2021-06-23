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
    public class BuildingRepository
    {
        public List<BuildingInformationDTO> GetAllBuildingInformation()
        {
            List<BuildingInformationDTO> buildings = new List<BuildingInformationDTO>();

            DataAccess dal = new DataAccess(ConfigurationManager.ConnectionStrings["CorporateAssetsConnection"].ConnectionString);

            //Create a Dictionary (key, value pairs) of paramaters and values for our stored proc to use in our DAL 
            //It will be empty since we are getting everything in this method
            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();

            //Call our DAL method to get the building infomration    
            DataTable buildingInfoTable = dal.PopulateDataTableViaStoredProcedure("spGetAllBuildingInformation", paramDictionary);

            //Loop through our data table and populate the building info DTO
            foreach (DataRow row in buildingInfoTable.Rows)
            {
                BuildingInformationDTO buildingInformationDTO = new BuildingInformationDTO();

                buildingInformationDTO.BuildingId = Convert.ToInt32(row["BuildingId"]);
                buildingInformationDTO.BuildingName = row["BuildingName"].ToString();
                buildingInformationDTO.StreetAddress = row["StreetAddress"].ToString();
                buildingInformationDTO.City = row["City"].ToString();
                buildingInformationDTO.State = row["State"].ToString();
                buildingInformationDTO.Zip = row["Zip"].ToString();
                buildingInformationDTO.Country = row["Country"].ToString();
                buildingInformationDTO.BuildingPhoneNumber = row["BuildingPhoneNumber"].ToString();
                buildingInformationDTO.NumberOfFloors = Convert.ToInt32(row["NumberOfFloors"]);
                buildingInformationDTO.NumberOfConferenceRooms = Convert.ToInt32(row["NumberOfConferenceRooms"]);

                //Add the building to the building list
                buildings.Add(buildingInformationDTO);
            }
            return buildings;
        }
    }
}
