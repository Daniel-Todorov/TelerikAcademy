using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string firstNumber, string secondNumber)
        {
            if (Request.HttpMethod.ToLower() == "post")
            {
                try
                {
                    double parsedFirstNumber = double.Parse(firstNumber);
                    double parsedSecondNumber = double.Parse(secondNumber);
                    ViewBag.TotalSum = (parsedFirstNumber + parsedSecondNumber).ToString();
                }
                catch (Exception)
                {
                    ViewBag.TotalSum = "Invalid numbers!";
                }
            }
            
            return View();
        }
    }
}