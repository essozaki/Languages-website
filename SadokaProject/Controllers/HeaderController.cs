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
    public class HeaderController : Controller
    {
        private readonly IHeaderRep header;
        private readonly IMapper mapper;
        public HeaderController(IHeaderRep header, IMapper mapper)
        {
            this.header = header;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            
                var data = header.Get();
                var result = mapper.Map<IEnumerable<HeaderVM>>(data);
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
        public IActionResult Create(HeaderVM model)
        {
            //try
            //{

            //    if (ModelState.IsValid)
            //    {
                    var imgUrl = UploadCv.uploadFile("Uploads/Header", model.HeaderPhoto);
                    var data = mapper.Map<Header>(model);
                    data.HeaderImgUrl = imgUrl;

                    header.Creat(data);
                    return RedirectToAction("Index");
            //    }

            //    return View();
            //}
            //catch (Exception ex)
            //{
            //    return View();
            //}
        }


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = header.GetById(id);
            var result = mapper.Map<HeaderVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(HeaderVM model)

        {
            if (model.HeaderPhoto == null)
            {
                var url = model.HeaderImgUrl;
                var data = mapper.Map<Header>(model);
                data.HeaderImgUrl = url;
                header.Edite(data);
                return RedirectToAction("Index");
            }
            else
            {
                var imgUrl = UploadCv.uploadFile("Uploads/Header", model.HeaderPhoto);
                var data = mapper.Map<Header>(model);
                data.HeaderImgUrl = imgUrl;
                header.Edite(data);
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = header.GetById(id);
            var result = mapper.Map<HeaderVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(HeaderVM model)
        {
            UploadCv.RemoveFile("Uploads/Header", model.HeaderImgUrl);
            var olddata = header.GetById(model.Id);
            header.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = header.GetById(id);

            var result = mapper.Map<HeaderVM>(data);

            return View(result);
        }

    }
}
