using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Languagy_project.BLL;
using Languagy_project.Data.Entities;
using Languagy_project.Models;

namespace Languagy_project.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        private readonly ISubscriptionsRep _subscriptions;
        private readonly IMapper mapper;
        public SubscriptionsController(ISubscriptionsRep Subscriptions, IMapper mapper)
        {
            this._subscriptions = Subscriptions;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = _subscriptions.Get();
            var result = mapper.Map<IEnumerable<SubscriptionsVM>>(data);
            return View(result);


        }
        //[HttpGet]
        ////[HttpGet] means ro get data, browser would choose it first
        //public IActionResult Create()

        //{

        //    return View();
        //}
        //[HttpPost]
        //// [HttpPost] means ro post data ,browser would choose it secend ,when clicck to save
        //public IActionResult Create(SubscriptionsVM model)
        //{
        //    var data = mapper.Map<Subscriptions>(model);

        //    _subscriptions.Creat(data);
        //    return RedirectToAction("Index");

        //}


        //[HttpGet]

        //public IActionResult Edite(int id)

        //{
        //    var data = _subscriptions.GetById(id);
        //    var result = mapper.Map<SubscriptionsVM>(data);
        //    return View(result);
        //}
        //[HttpPost]
        //public IActionResult Edite(SubscriptionsVM model)

        //{


        //    var data = mapper.Map<Subscriptions>(model);
        //    _subscriptions.Edite(data);
        //    return RedirectToAction("Index");


        //}


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _subscriptions.GetById(id);
            var result = mapper.Map<SubscriptionsVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(SubscriptionsVM model)
        {
            var olddata = _subscriptions.GetById(model.Id);
            _subscriptions.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = _subscriptions.GetById(id);

            var result = mapper.Map<SubscriptionsVM>(data);

            return View(result);
        }

    }
}
