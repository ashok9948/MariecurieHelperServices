using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewTask.Models;

namespace InterviewTask.Controllers
{
    public class HelperServiceController : Controller
    {
        // GET: HelperService
       
        public ActionResult Index()
        {
            // Assuming you have a list of HelperService objects
            List<HelperServiceModel> helperServices = GetHelperServices();

            return View(helperServices);
        }
        private List<HelperServiceModel> GetHelperServices()
        {
            // Retrieve data from a database or another source
            // For simplicity, creating dummy data
            return new List<HelperServiceModel>
        {
            new HelperServiceModel
        {
            Id = Guid.NewGuid(),
            Title = "Service 1",
            Description = "Description for Service 1 - We know the little things can make a big difference when you, or someone you care about, are living with a terminal illness.",
            TelephoneNumber = "123-456-7890",
            MondayOpeningHours = new List<int> { 9, 17 }, // Opening hours for Monday, e.g., 9 AM to 5 PM
            TuesdayOpeningHours = new List<int> { 9, 17 },
            WednesdayOpeningHours = new List<int> { 9, 17 },
            ThursdayOpeningHours = new List<int> { 9, 17 },
            FridayOpeningHours = new List<int> { 9, 17 },
            SaturdayOpeningHours = new List<int> { 10, 15 }, // Adjusted hours for Saturday
            SundayOpeningHours = new List<int> { 12, 16 } // Adjusted hours for Sunday
        },
            new HelperServiceModel
        {
            Id = Guid.NewGuid(),
            Title = "Service 2",
            Description = "Description for Service 2 - We know the little things can make a big difference when you, or someone you care about, are living with a terminal illness.",
            TelephoneNumber = "123-456-7890",
            MondayOpeningHours = new List<int> { 9, 17 }, // Opening hours for Monday, e.g., 9 AM to 5 PM
            TuesdayOpeningHours = new List<int> { 9, 17 },
            WednesdayOpeningHours = new List<int> { 9, 17 },
            ThursdayOpeningHours = new List<int> { 9, 17 },
            FridayOpeningHours = new List<int> { 9, 17 },
            SaturdayOpeningHours = new List<int> { 10, 15 }, // Adjusted hours for Saturday
            SundayOpeningHours = new List<int> { 12, 16 } // Adjusted hours for Sunday
        }

        };
        }

    }
}