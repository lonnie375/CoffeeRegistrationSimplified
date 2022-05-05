using Microsoft.AspNetCore.Mvc;
using CoffeeRegistrationSimplified.Models;


namespace CoffeeRegistrationSimplified.Controllers
{
    public class RegistrationController : Controller
    {
        //IActionResult is an interface 
        //IactionResult allows you to return both data and HTTP codes 
        //It acts as a container for other action results in that interface. 
        //Instructs the server on how to respond to the request. 
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Summary(Register customer)
        {
            return View(customer); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Registration([Bind("FirstName, LastName, EmailAddress, Password, ConfirmPassword")] Register customer)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction(nameof(Summary), customer);
            }
            return View(customer);
        }
    }
}
