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
    public class BuildingInformationController : Controller
    {
        // GET: BuildingInformation
        public ActionResult ViewBuildingInformation()
        {
            //Load the building information from the database
            BuildingBL buildingBL = new BuildingBL();
            List<ViewBuildingInformationViewModel> buildingViewModels = buildingBL.GetAllBuildings();

            //Uncomment the line below to load dummy data
            //List<ViewBuildingInformationViewModel> buildingViewModels = buildingBL.LoadBuildingData();

            return View(buildingViewModels);
        }
        public ActionResult EnterBuildingInformation()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult EnterBuildingInformation(EnterBuildingInformationViewModel building)
        {
            if (ModelState.IsValid)
            {
                //Determine building classification
                BuildingBL buildingBL = new BuildingBL();
                building.Classification = buildingBL.DetermineBuildingClassification(building);

                //Determine building type (tower or standard)
                building.Type = buildingBL.DetermineBuildingType(building);

                ModelState.Clear();
                EnterBuildingInformationViewModel buildingNew = new EnterBuildingInformationViewModel();
                buildingNew.EntrySuccessful = true;
                buildingNew.Message = $"Entry accepted for {building.BuildingName} located in city {building.City}.  " +
                    $"Building is classified as a {building.Classification}.  Building type is {building.Type}.";
                return View(buildingNew);
            }

            //Return the model as there's an error and the user needs to see
            // what has been entered.
            return View(building);
        }

        public ActionResult SaveBuildingDetail(EnterBuildingInformationViewModel building)
        {
            //Return the new building model instance in the View - This is how you'd go to a new page after adding (uncomment to just go to a new page after adding)
            /////return View(building);

            //Call Business Logic -> Repository -> etc. to save the data here

            //Add a success messsage to the ViewModel.
            building.EntrySuccessful = true;

            //Return to the EnterBuildingInformation View, passing the View Model
            return View("EnterBuildingInformation", building);
        }
    }
}