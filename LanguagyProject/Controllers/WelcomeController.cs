using AutoMapper;
using Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Languagy_project.BLL;
using Languagy_project.Data.Entities;
using Languagy_project.Models;

namespace Languagy_project.Controllers
{
    [Authorize]
    public class WelcomeController : Controller
    {
        private readonly IWelcomeRep _welcome;
        private readonly IMapper mapper;
        public WelcomeController(IWelcomeRep welcome, IMapper mapper)
        {
            this._welcome = welcome;
            this.mapper = mapper;
        }
        public IActionResult Index(string searchValue = null)
        {

            var data = _welcome.Get();
            var result = mapper.Map<IEnumerable<WelcomeVM>>(data);
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
        public IActionResult Create(WelcomeVM model)
        {
            var imgUrl = UploadCv.uploadFile("Uploads/Welcome", model.WelcomePhoto);

            var data = mapper.Map<Welcome>(model);
            data.WelcomeIImgUrl = imgUrl;
            _welcome.Creat(data);
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = _welcome.GetById(id);
            var result = mapper.Map<WelcomeVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(WelcomeVM model)

        {
            if (model.WelcomePhoto == null)
            {
                var url = model.WelcomeIImgUrl;
                var data = mapper.Map<Welcome>(model);
                data.WelcomeIImgUrl = url;
                _welcome.Edite(data);
                return RedirectToAction("Index");
            }
            else
            {
                var imgUrl = UploadCv.uploadFile("Uploads/Welcome", model.WelcomePhoto);
                var data = mapper.Map<Welcome>(model);
                data.WelcomeIImgUrl = imgUrl;
                _welcome.Edite(data);
                return RedirectToAction("Index");

        }
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _welcome.GetById(id);
            var result = mapper.Map<WelcomeVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(WelcomeVM model)
        {
            UploadCv.RemoveFile("Uploads/Welcome", model.WelcomeIImgUrl);

            var olddata = _welcome.GetById(model.Id);
            _welcome.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = _welcome.GetById(id);

            var result = mapper.Map<WelcomeVM>(data);

            return View(result);
        }

    }
}
