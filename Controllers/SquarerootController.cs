using Microsoft.AspNetCore.Mvc;
using System;

namespace cSharpTask4.Controllers
{


public class SquarerootController : Controller
    {
             [HttpGet]
        public ActionResult CalcSquareroot(){
                 return View();       
        }

         [HttpPost]
        public ActionResult calcSquareroot(string firstNumber, string secondNumber)
        {
            int num1 = int.Parse(firstNumber);
            int num2 = int.Parse(secondNumber);
            ViewBag.content1 = num1;
            ViewBag.content2 = num2;


            double numberOne = Math.Sqrt(Convert.ToDouble(firstNumber));
            double numberTwo = Math.Sqrt(Convert.ToDouble(secondNumber));

            ViewBag.Result1 = numberOne;
            ViewBag.Result2 = numberTwo;


            return View();
        }
    }

}

