using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Languagy_project.BLL;
using Languagy_project.Data.Entities;
using Languagy_project.Models;

namespace Languagy_project.Controllers
{
    public class LanguagyController : Controller
    {
        private readonly IContactUsRep _ContactUs;
        private readonly ISubscriptionsRep _subscriptions;
        private readonly IMapper mapper;
        public LanguagyController(ISubscriptionsRep subscriptions,IContactUsRep ContactUS, IMapper mapper)
        {
            this._ContactUs = ContactUS;
            this._subscriptions = subscriptions;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet] means ro get data, browser would choose it first
       
        [HttpPost]
        // [HttpPost] means ro post data ,browser would choose it secend ,when clicck to save
        public IActionResult Contact(LanguagyVM model)
        {
            var data = mapper.Map<ContactUS>(model.ContactUSVM);
            _ContactUs.Creat(data);
            return RedirectToAction("Index", "Sadoka");

        }
    
        [HttpPost]
        // [HttpPost] means ro post data ,browser would choose it secend ,when clicck to save
        public IActionResult Subscribe(LanguagyVM model)
        {
            var data = mapper.Map<Subscriptions>(model.SubscriptionsVM);

            _subscriptions.Creat(data);
            return RedirectToAction("Index","Sadoka");

        }
    }
}
