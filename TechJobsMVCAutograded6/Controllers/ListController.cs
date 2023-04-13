using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVCAutograded6.Data;
using TechJobsMVCAutograded6.Models;

namespace TechJobsMVCAutograded6.Controllers
{
    public class ListController : Controller
    {
        internal static Dictionary<string, string> ColumnChoices = new Dictionary<string, string>()
        {
            {"all", "All"},
            {"employer", "Employer"},
            {"location", "Location"},
            {"positionType", "Position Type"},
            {"coreCompetency", "Skill"}
        };

        internal static Dictionary<string, List<JobField>> TableChoices = new Dictionary<string, List<JobField>>()
        {
            {"all", new List<JobField>()},
            {"employer", JobData.GetAllEmployers()},
            {"location", JobData.GetAllLocations()},
            {"positionType", JobData.GetAllPositionTypes()},
            {"coreCompetency", JobData.GetAllCoreCompetencies()}
        };

        public IActionResult Index()
        {
            ViewBag.columns = ColumnChoices;
            ViewBag.tableChoices = TableChoices;
            ViewBag.employers = JobData.GetAllEmployers();
            ViewBag.locations = JobData.GetAllLocations();
            ViewBag.positionTypes = JobData.GetAllPositionTypes();
            ViewBag.skills = JobData.GetAllCoreCompetencies();

            return View();
        }

        public IActionResult Jobs(string column, string value)
        {
           /* if (!ColumnChoices.ContainsKey(column))
            {
                ViewBag.title = "All Jobs";
                ViewBag.jobs = JobData.FindAll();
            }*/
            
                ColumnChoices["Jobs"] = "Jobs";
                if (column == "View All" || value == "View All")
                {
                    ViewBag.title = "All Jobs";
                    ViewBag.jobs = JobData.FindAll();
                }
                else
                {
                    ViewBag.title = "Jobs with " + ColumnChoices[column] + ": " + value;
                    ViewBag.jobs = JobData.FindByColumnAndValue(column, value);
                }
            
            return View();
        }
    }
}
