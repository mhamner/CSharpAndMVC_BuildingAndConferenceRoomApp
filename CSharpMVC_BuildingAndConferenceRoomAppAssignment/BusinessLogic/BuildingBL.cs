using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSharpMVC_BuildingAndConferenceRoomAppAssignment.Models;
using CSharpMVC_BuildingAndConferenceRoomAppAssignment.ViewModels;
using DataLibrary.DTOs;
using DataLibrary.Repositories;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.BusinessLogic
{
    public class BuildingBL
    {
        public List<ViewBuildingInformationViewModel> LoadBuildingData()
        {
            List<BuildingInformationModel> buildings = new List<BuildingInformationModel>();
            buildings.Add(new BuildingInformationModel
            {
                BuildingId = "1",
                BuildingName = "Waystar Main Campus",
                StreetAddress = "888 West Market Street",
                City = "Louisville",
                State = "KY",
                Zip = "40224",
                MainBuildingPhoneNumber = "1-800-111-2222",
                NumberOfFloors = "12",
                NumberOfConferenceRooms = "20"
            });
            buildings.Add(new BuildingInformationModel
            {
                BuildingId = "2",
                BuildingName = "Waystar Duluth Office",
                StreetAddress = "2055 Sugarloaf Circle #600",
                City = "Duluth",
                State = "GA",
                Zip = "31875",
                MainBuildingPhoneNumber = "1-800-222-3333",
                NumberOfFloors = "8",
                NumberOfConferenceRooms = "12"
            });
            buildings.Add(new BuildingInformationModel
            {
                BuildingId = "3",
                BuildingName = "Waystar Chicago Office",
                StreetAddress = "1330 W Fulton Market #300",
                City = "Chicago",
                State = "IL",
                Zip = "67890",
                MainBuildingPhoneNumber = "1-800-333-4444",
                NumberOfFloors = "5",
                NumberOfConferenceRooms = "10"
            });
            buildings.Add(new BuildingInformationModel
            {
                BuildingId = "4",
                BuildingName = "Waystar Denver Office",
                StreetAddress = "7900 E Union Avenue #400",
                City = "Denver",
                State = "CO",
                Zip = "77889",
                MainBuildingPhoneNumber = "1-800-444-5555",
                NumberOfFloors = "7",
                NumberOfConferenceRooms = "11"
            });
            buildings.Add(new BuildingInformationModel
            {
                BuildingId = "5",
                BuildingName = "Waystar Utah Office",
                StreetAddress = "1650 Digital Drive",
                City = "Lehi",
                State = "UT",
                Zip = "88662",
                MainBuildingPhoneNumber = "1-800-777-8888",
                NumberOfFloors = "3",
                NumberOfConferenceRooms = "5"
            });

            //Now convert the domain model to the view model
            List<ViewBuildingInformationViewModel> buildingViewModels = ConvertBuildingModelToViewModel(buildings);

            return buildingViewModels;
        }

        public string DetermineBuildingClassification(EnterBuildingInformationViewModel enterBuildingInformationViewModel)
        {            
            if(enterBuildingInformationViewModel.City.ToLower() == "louisville")
            {
                return "campus";
            }
            return "satellite";
        }

        public string DetermineBuildingType(EnterBuildingInformationViewModel enterBuildingInformationViewModel)
        {
            if (Convert.ToInt32(enterBuildingInformationViewModel.NumberOfFloors) >= 5)
            {
                return "tower";
            }
            return "standard";
        }

        private List<ViewBuildingInformationViewModel> ConvertBuildingModelToViewModel(List<BuildingInformationModel> buildingInformationModels)
        {
            List<ViewBuildingInformationViewModel> viewBuildingInformationViewModels = new List<ViewBuildingInformationViewModel>();

            foreach(BuildingInformationModel buildingInformationModel in buildingInformationModels)
            {
                //Map the domain model to the view model
                ViewBuildingInformationViewModel vm = new ViewBuildingInformationViewModel();
                vm.BuildingId = buildingInformationModel.BuildingId;
                vm.BuildingName = buildingInformationModel.BuildingName;
                vm.StreetAddress = buildingInformationModel.StreetAddress;
                vm.City = buildingInformationModel.City;
                vm.State = buildingInformationModel.State;
                vm.Zip = buildingInformationModel.Zip;
                vm.Country = buildingInformationModel.Country;
                vm.MainBuildingPhoneNumber = buildingInformationModel.MainBuildingPhoneNumber;
                vm.NumberOfFloors = buildingInformationModel.NumberOfFloors;
                vm.NumberOfConferenceRooms = buildingInformationModel.NumberOfConferenceRooms;

                //Add this view model to the list of view models
                viewBuildingInformationViewModels.Add(vm);
            }

            return viewBuildingInformationViewModels;
        }

        public List<ViewBuildingInformationViewModel> GetAllBuildings()
        {
            //Call the repository to get the info. from the DB
            BuildingRepository buildingRepository = new BuildingRepository();
            List<BuildingInformationDTO> buildingDTOs = buildingRepository.GetAllBuildingInformation();

            //Convert the DTOs to the models
            List<BuildingInformationModel> buildingInformationModels = ConvertBuildingDTOsToBuildingModels(buildingDTOs);

            //Convert the models to the ViewModels
            List<ViewBuildingInformationViewModel> viewBuildingInformationViewModels = ConvertBuildingModelToViewModel(buildingInformationModels);
            
            //Return the models
            return viewBuildingInformationViewModels;
        }

        private List<BuildingInformationModel> ConvertBuildingDTOsToBuildingModels(List<BuildingInformationDTO> buildingInformationDTOs)
        {
            List<BuildingInformationModel> buildingInformationModels = new List<BuildingInformationModel>();

            foreach(BuildingInformationDTO buildingDTO in buildingInformationDTOs)
            {
                //Map the DTO the the domain model
                BuildingInformationModel bm = new BuildingInformationModel();
                bm.BuildingId = buildingDTO.BuildingId.ToString();
                bm.BuildingName = buildingDTO.BuildingName;
                bm.MainBuildingPhoneNumber = buildingDTO.BuildingPhoneNumber;
                bm.StreetAddress = buildingDTO.StreetAddress;
                bm.City = buildingDTO.City;
                bm.State = buildingDTO.State;
                bm.Zip = buildingDTO.Zip;
                bm.Country = buildingDTO.Country;
                bm.NumberOfFloors = buildingDTO.NumberOfFloors.ToString();
                bm.NumberOfConferenceRooms = buildingDTO.NumberOfConferenceRooms.ToString();

                //Add the new model to the list
                buildingInformationModels.Add(bm);
            }

            return buildingInformationModels;
        }
    }
}