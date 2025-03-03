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
    public class FeaturesController : Controller
    {
        private readonly IFeaturesRep _features;
        private readonly IMapper mapper;
        public FeaturesController(IFeaturesRep features, IMapper mapper)
        {
            this._features = features;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = _features.Get();
            var result = mapper.Map<IEnumerable<FeaturesVM>>(data);
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
        public IActionResult Create(FeaturesVM model)
        {
            //var imgUrl = UploadCv.uploadFile("Uploads/Features", model.FeaturesPhoto);
            var data = mapper.Map<Features>(model);
            //data.FeaturesImgUrl = imgUrl;

            _features.Creat(data);
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = _features.GetById(id);
            var result = mapper.Map<FeaturesVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(FeaturesVM model)

        {
            //if (model.FeaturesPhoto == null)
            //{
            //    var url = model.FeaturesImgUrl;
            //    var data = mapper.Map<Features>(model);
            //    data.FeaturesImgUrl = url;
            //    _features.Edite(data);
            //    return RedirectToAction("Index");
            //}
            //else
            //{
                //var imgUrl = UploadCv.uploadFile("Uploads/Features", model.FeaturesPhoto);
                var data = mapper.Map<Features>(model);
                //data.FeaturesImgUrl = imgUrl;
                _features.Edite(data);
                return RedirectToAction("Index");
            //}

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _features.GetById(id);
            var result = mapper.Map<FeaturesVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(FeaturesVM model)
        {
            //UploadCv.RemoveFile("Uploads/Features", model.FeaturesImgUrl);
            var olddata = _features.GetById(model.Id);
            _features.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = _features.GetById(id);

            var result = mapper.Map<FeaturesVM>(data);

            return View(result);
        }

    }
}
