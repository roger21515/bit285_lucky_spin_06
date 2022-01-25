using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;
using LuckySpin.ViewModels;
using LuckySpin.Services;
using System.Globalization;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        private RepositoryService repoService;

        /***
         *  Constructor -  with RepositoryService DIJ
         **/
        public SpinnerController(RepositoryService repoService)
        {
            this.repoService = repoService;
        }

        /***
         * Index Action
         **/
        [HttpGet]
        public IActionResult Index()
        {
                return View(); //Sends the empty Index form
        }
        
        [HttpPost]
        public IActionResult Index(Player player, IndexViewModel indexVM) // Update Index() to receive form data as IndexViewModel
        {
            if (!ModelState.IsValid) { return View(); } //Check for missing data

            // Complete adding Player data to store in the repoService
            repoService.Player = new Player
            {
                Name = indexVM.FirstName,
            };

            return RedirectToAction("Spin");
        }

        /***
         * Spin Action
         **/  
               
        public IActionResult Spin(RepositoryService player) //Start a Spin WITHOUT data
        {
            //CHARGE 
            // Load Player balance from the repoService
            decimal balance = player.Player.Balance;
            balance = balance - .50M;
            //: Charge $0.50 to spin


         //SPIN
            //TODO: Complete adding data to a new SpinViewModel to gather items for the View
            SpinViewModel spinVM = new SpinViewModel
            {
               //  CurrentBalance = string.Format(new CultureInfo("en-SG", false), "{0:C2}", balance),
            };

            //GAMEPLAY
            //TODO: Check the Balance to see if the game is over
            balance == 0 ? "Sorry, the game is over" : Redirect(Spin());
            //TODO: Pay $1.00 if Winning


         //UPDATE DATA STORE
            //TODO: Save balance to repoService


            //TODO: Use the repoService to add a spin to the repository


            return View("Spin", spinVM);
        }

        //TODO: BONUS:  the LuckList
        /***
         * LuckList Action
         **/
        [HttpGet]
        public IActionResult LuckList()
        {
            return new ContentResult { Content = "<h1>Luck's Run Out</h1>", ContentType = "text/html" };
        }

    }
}

