using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpMVC_BuildingAndConferenceRoomAppAssignment.Models;
using CSharpMVC_BuildingAndConferenceRoomAppAssignment.ViewModels;
using CSharpMVC_BuildingAndConferenceRoomAppAssignment.BusinessLogic;

namespace CSharpMVC_BuildingAndConferenceRoomAppAssignment.Controllers
{
    public class ConferenceRoomInformationController : Controller
    {
        // GET: ConferenceRoomInformation
        public ActionResult ViewConferenceRoomInformation()
        {
            ConferenceRoomBL conferenceRoomBL = new ConferenceRoomBL();
            List<ViewConferenceRoomInformationViewModel> conferenceRooms = conferenceRoomBL.GetAllConferenceRooms();

            //Uncomment the line below to load dummy data
            //List<ViewConferenceRoomInformationViewModel> conferenceRooms = conferenceRoomBL.LoadConferenceRoomData();

            return View(conferenceRooms);
        }

        public ActionResult EnterConferenceRoomInformation()
        {        
            return View();
        }

        [HttpPost]
        public ActionResult EnterConferenceRoomInformation(EnterConferenceRoomInformationViewModel conferenceRoom)
        {
            if (ModelState.IsValid)
            {
                //Determine building size based on capacity
                ConferenceRoomBL conferenceRoomBL = new ConferenceRoomBL();
                conferenceRoom.Size = conferenceRoomBL.DetermineSize(conferenceRoom);
               
                ModelState.Clear();
                EnterConferenceRoomInformationViewModel conferenceRoomNew = new EnterConferenceRoomInformationViewModel();
                conferenceRoomNew.EntrySuccessful = true;
                conferenceRoomNew.Message = $"Entry accepted for {conferenceRoom.RoomName} located in building {conferenceRoom.RoomBuilding}.  " +
                    $"Conference room size is classifed as {conferenceRoom.Size}.";
                return View(conferenceRoomNew);
            }

            //Return the model as there's an error and the user needs to see
            // what has been entered.
            return View(conferenceRoom);
        }

        public ActionResult SaveConferenceRoomDetail(EnterConferenceRoomInformationViewModel conferenceRoom)
        {
            //Return the new conference room view model instance in the View - This is how you'd go to a new page after adding
            /////return View(conferenceRoom);
            ///
            //Write to the DB here

            EnterConferenceRoomInformationViewModel conferenceRoomNew = new EnterConferenceRoomInformationViewModel();
            conferenceRoomNew.EntrySuccessful = true;
            conferenceRoomNew.Message = $"Entry accepted for {conferenceRoom.RoomName} located in building {conferenceRoom.RoomBuilding}.";

            //Return to the Enter Conference Room Info View, passing the View Model
            return View("EnterConferenceRoomInformation", conferenceRoomNew);
        }
    }
}