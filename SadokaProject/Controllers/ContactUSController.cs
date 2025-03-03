using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Languagy_project.BLL;
using Languagy_project.Data.Entities;
using Languagy_project.Models;

namespace Languagy_project.Controllers
{
    public class ContactUSController : Controller
    {
        private readonly IContactUsRep _ContactUs;
        private readonly IMapper mapper;
        public ContactUSController(IContactUsRep ContactUS, IMapper mapper)
        {
            this._ContactUs = ContactUS;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = _ContactUs.Get();
            var result = mapper.Map<IEnumerable<ContactUSVM>>(data);
            return View(result);


        }
        [HttpGet]
        //[HttpGet] means ro get data, browser would choose it first
        //public IActionResult Create()

        //{

        //    return View();
        //}
        //[HttpPost]
        //// [HttpPost] means ro post data ,browser would choose it secend ,when clicck to save
        //public IActionResult Create(ContactUSVM model)
        //{
        //    var data = mapper.Map<ContactUS>(model);
        //    _ContactUs.Creat(data);
        //    return RedirectToAction("Index");

        //}


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = _ContactUs.GetById(id);
            var result = mapper.Map<ContactUSVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(ContactUSVM model)

        {


            var data = mapper.Map<ContactUS>(model);
            _ContactUs.Edite(data);
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _ContactUs.GetById(id);
            var result = mapper.Map<ContactUSVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(ContactUSVM model)
        {
            var olddata = _ContactUs.GetById(model.Id);
            _ContactUs.Delete(olddata);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)

        {

            var data = _ContactUs.GetById(id);

            var result = mapper.Map<ContactUSVM>(data);

            return View(result);
        }

    }
}
