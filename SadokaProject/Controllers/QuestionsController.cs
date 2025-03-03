using AutoMapper;
using Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Languagy_project.BLL;
using Languagy_project.Controllers;
using Languagy_project.Data.Entities;
using Languagy_project.Models;

namespace Languagy_project.Controllers
{
    [Authorize]
    public class QuestionsController : Controller
    {
 
        private readonly IQuestionsRep _Questions;
        private readonly IMapper mapper;
        public QuestionsController(IQuestionsRep questions, IMapper mapper)
        {
            this._Questions = questions;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = _Questions.Get();
            var result = mapper.Map<IEnumerable<QuestionsVM>>(data);
            return View(result);


        }
        [HttpGet]
        //[HttpGet] means ro get data, browser would choose it first
        public IActionResult Create()

        {

            return View();
        }
        [HttpPost]
        // [HttpPost] means ro post data ,browser would choose it secend ,when clicck to save
        public IActionResult Create(QuestionsVM model)
        {
            var data = mapper.Map<Questions>(model);

            _Questions.Creat(data);
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = _Questions.GetById(id);
            var result = mapper.Map<QuestionsVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(QuestionsVM model)

        {
    
    
                var data = mapper.Map<Questions>(model);
                _Questions.Edite(data);
                return RedirectToAction("Index");
    

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _Questions.GetById(id);
            var result = mapper.Map<QuestionsVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(QuestionsVM model)
        {
            var olddata = _Questions.GetById(model.Id);
            _Questions.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = _Questions.GetById(id);

            var result = mapper.Map<QuestionsVM>(data);

            return View(result);
        }

            }
        }
