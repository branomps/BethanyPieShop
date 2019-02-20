using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        //Get
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //Post
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedBack(feedback);
                return RedirectToAction("FeedbackComplete");
            }

            return View(feedback);
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}