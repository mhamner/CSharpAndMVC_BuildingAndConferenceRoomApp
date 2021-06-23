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
    public class ConferenceRoomBL
    {
        public List<ViewConferenceRoomInformationViewModel> LoadConferenceRoomData()
        {
            List<ConferenceRoomInformationModel> conferenceRooms = new List<ConferenceRoomInformationModel>();
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "1",
                RoomName = "Awesome Room",
                RoomBuilding = "Waystar Main Campus",
                RoomPhoneNumber = "1-502-111-2222",
                RoomCapacity = "15",
                RoomIsAVCapable = true                
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "2",
                RoomName = "Uber Room",
                RoomBuilding = "Waystar Main Campus",
                RoomPhoneNumber = "1-502-222-3333",
                RoomCapacity = "10",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "3",
                RoomName = "Terrific Room",
                RoomBuilding = "Waystar Denver Office",
                RoomPhoneNumber = "1-303-111-2222",
                RoomCapacity = "15",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "4",
                RoomName = "Pretty Freaking Good Room",
                RoomBuilding = "Waystar Denver Office",
                RoomPhoneNumber = "1-303-222-3333",
                RoomCapacity = "20",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "5",
                RoomName = "Great Room",
                RoomBuilding = "Waystar Utah Office",
                RoomPhoneNumber = "1-801-111-2222",
                RoomCapacity = "15",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "6",
                RoomName = "Nice Room",
                RoomBuilding = "Waystar Utah Office",
                RoomPhoneNumber = "1-801-777-9999",
                RoomCapacity = "10",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "7",
                RoomName = "Good Room",
                RoomBuilding = "Waystar Duluth Office",
                RoomPhoneNumber = "1-404-111-2222",
                RoomCapacity = "8",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "8",
                RoomName = "Better than Okay Room",
                RoomBuilding = "Waystar Duluth Office",
                RoomPhoneNumber = "1-404-999-3322",
                RoomCapacity = "20",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "9",
                RoomName = "Okay Room",
                RoomBuilding = "Waystar Duluth Office",
                RoomPhoneNumber = "1-404-988-2233",
                RoomCapacity = "5",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "10",
                RoomName = "Meh Room",
                RoomBuilding = "Waystar Main Campus",
                RoomPhoneNumber = "1-502-775-5543",
                RoomCapacity = "3",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "11",
                RoomName = "Neato Cheato Room",
                RoomBuilding = "Waystar Denver Office",
                RoomPhoneNumber = "1-303-444-5554",
                RoomCapacity = "20",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "12",
                RoomName = "Neato Room",
                RoomBuilding = "Waystar Denver Office",
                RoomPhoneNumber = "1-303-222-1212",
                RoomCapacity = "10",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "13",
                RoomName = "Room 13",
                RoomBuilding = "Waystar Chicago Office",
                RoomPhoneNumber = "1-224-111-2222",
                RoomCapacity = "13",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "14",
                RoomName = "Windy City Room",
                RoomBuilding = "Waystar Chicago Office",
                RoomPhoneNumber = "1-224-343-2211",
                RoomCapacity = "20",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "15",
                RoomName = "Breezy Room",
                RoomBuilding = "Waystar Chicago Office",
                RoomPhoneNumber = "1-224-333-4445",
                RoomCapacity = "10",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "16",
                RoomName = "Drafty Room",
                RoomBuilding = "Waystar Chicago Office",
                RoomPhoneNumber = "1-224-555-6693",
                RoomCapacity = "15",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "17",
                RoomName = "Mountain View Room",
                RoomBuilding = "Waystar Lehi Office",
                RoomPhoneNumber = "1-801-444-4442",
                RoomCapacity = "20",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "18",
                RoomName = "bit502 Training Room (Room 105)",
                RoomBuilding = "Waystar Main Campus",
                RoomPhoneNumber = "1-502-123-4567",
                RoomCapacity = "10",
                RoomIsAVCapable = true
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "19",
                RoomName = "Groovy Room",
                RoomBuilding = "Waystar Main Campus",
                RoomPhoneNumber = "1-502-331-1237",
                RoomCapacity = "5",
                RoomIsAVCapable = false
            });
            conferenceRooms.Add(new ConferenceRoomInformationModel
            {
                RoomId = "20",
                RoomName = "Fantastic Room",
                RoomBuilding = "Waystar Main Campus",
                RoomPhoneNumber = "1-502-777-9999",
                RoomCapacity = "20",
                RoomIsAVCapable = true
            });

            //Now convert the domain models to view models
            List<ViewConferenceRoomInformationViewModel> vms = ConvertConferenceRoomModelsToViewModels(conferenceRooms);

            return vms;
        }

        public string DetermineSize(EnterConferenceRoomInformationViewModel enterConferenceRoomInformationViewModel)
        {
            int capacity = Convert.ToInt32(enterConferenceRoomInformationViewModel.RoomCapacity);
            if(capacity <= 10)
            {
                return "small";
            }
            else if (capacity <=20)
            {
                return "medium";
            }
            else
            {
                return "large";
            }
        }

        private List<ViewConferenceRoomInformationViewModel> ConvertConferenceRoomModelsToViewModels(List<ConferenceRoomInformationModel> conferenceRoomInformationModels)
        {
            List<ViewConferenceRoomInformationViewModel> viewConferenceRoomInformationViewModels = new List<ViewConferenceRoomInformationViewModel>();

            foreach(ConferenceRoomInformationModel dm in conferenceRoomInformationModels)
            {
                //Convert each domain model to a View Model
                ViewConferenceRoomInformationViewModel vm = new ViewConferenceRoomInformationViewModel();
                vm.RoomId = dm.RoomId;
                vm.RoomName = dm.RoomName;
                vm.RoomBuilding = dm.RoomBuilding;
                vm.RoomPhoneNumber = dm.RoomPhoneNumber;
                vm.RoomCapacity = dm.RoomCapacity;
                vm.RoomIsAVCapable = dm.RoomIsAVCapable;

                //Add it to the list of View Models
                viewConferenceRoomInformationViewModels.Add(vm);
            }

            return viewConferenceRoomInformationViewModels;
        }

        public List<ViewConferenceRoomInformationViewModel> GetAllConferenceRooms()
        {
            //Call the repository to get the info. from the DB
            ConferenceRoomRepository conferenceRoomRepository = new ConferenceRoomRepository();
            List <ConferenceRoomInformationDTO> conferenceRoomDTOs = conferenceRoomRepository.GetAllConferenceRoomInformation();

            //Convert the DTOs to the models
            List<ConferenceRoomInformationModel> conferenceRoomInformationModels = ConvertConferenceRoomDTOsToConferenceRoomModels(conferenceRoomDTOs);

            //Convert the models to the ViewModels
            List<ViewConferenceRoomInformationViewModel> viewConferenceRoomInformationViewModels = ConvertConferenceRoomModelsToViewModels(conferenceRoomInformationModels);

            //Return the models
            return viewConferenceRoomInformationViewModels;
        }

        private List<ConferenceRoomInformationModel> ConvertConferenceRoomDTOsToConferenceRoomModels(List<ConferenceRoomInformationDTO> conferenceRoomInformationDTOs)
        {
            List<ConferenceRoomInformationModel> conferenceRoomInformationModels = new List<ConferenceRoomInformationModel>();

            foreach (ConferenceRoomInformationDTO conferenceRoomDTO in conferenceRoomInformationDTOs)
            {
                //Map the DTO the the domain model
                ConferenceRoomInformationModel cm = new ConferenceRoomInformationModel();
                cm.RoomId = conferenceRoomDTO.ConferenceRoomId.ToString();
                cm.RoomName = conferenceRoomDTO.ConferenceRoomName;
                cm.RoomPhoneNumber = conferenceRoomDTO.ConferenceRoomPhoneNumber;
                cm.RoomBuilding = conferenceRoomDTO.Building;
                cm.RoomIsAVCapable = conferenceRoomDTO.AVCapable;
                cm.RoomCapacity = conferenceRoomDTO.Capacity.ToString();

                //Add the new model to the list
                conferenceRoomInformationModels.Add(cm);
            }

            return conferenceRoomInformationModels;
        }
    }
}