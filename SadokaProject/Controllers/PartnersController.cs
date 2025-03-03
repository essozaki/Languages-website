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
    public class PartnersController : Controller
    {
        private readonly IPartnersRep _partners;
        private readonly IMapper mapper;
        public PartnersController(IPartnersRep partners, IMapper mapper)
        {
            this._partners = partners;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = _partners.Get();
            var result = mapper.Map<IEnumerable<PartnersVM>>(data);
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
        public IActionResult Create(PartnersVM model)
        {
            var imgUrl = UploadCv.uploadFile("Uploads/Partners", model.PartnersPhoto);
            var data = mapper.Map<Partners>(model);
            data.PartnersLogoUrl = imgUrl;

            _partners.Creat(data);
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = _partners.GetById(id);
            var result = mapper.Map<PartnersVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(PartnersVM model)

        {
            if (model.PartnersPhoto == null)
            {
                var url = model.PartnersLogoUrl;
                var data = mapper.Map<Partners>(model);
                data.PartnersLogoUrl = url;
                _partners.Edite(data);
                return RedirectToAction("Index");
            }
            else
            {
                var imgUrl = UploadCv.uploadFile("Uploads/Partners", model.PartnersPhoto);
                var data = mapper.Map<Partners>(model);
                data.PartnersLogoUrl = imgUrl;
                _partners.Edite(data);
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _partners.GetById(id);
            var result = mapper.Map<PartnersVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(PartnersVM model)
        {
            UploadCv.RemoveFile("Uploads/Partners", model.PartnersLogoUrl);
            var olddata = _partners.GetById(model.Id);
            _partners.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = _partners.GetById(id);

            var result = mapper.Map<PartnersVM>(data);

            return View(result);
        }

    }
}
