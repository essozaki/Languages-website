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
    public class ThemeController : Controller
    {
        private readonly IThemeRep _theme;
        private readonly IMapper mapper;
        public ThemeController(IThemeRep Theme, IMapper mapper)
        {
            this._theme = Theme;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = _theme.Get();
            var result = mapper.Map<IEnumerable<ThemeVM>>(data);
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
        public IActionResult Create(ThemeVM model)
        {
            var imgUrl = UploadCv.uploadFile("Uploads/Theme", model.ThemePhoto);
            var data = mapper.Map<Theme>(model);
            data.ThemeImgUrl = imgUrl;

            _theme.Creat(data);
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = _theme.GetById(id);
            var result = mapper.Map<ThemeVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(ThemeVM model)

        {
            if (model.ThemePhoto == null)
            {
                var url = model.ThemeImgUrl;
                var data = mapper.Map<Theme>(model);
                data.ThemeImgUrl = url;
                _theme.Edite(data);
                return RedirectToAction("Index");
            }
            else
            {
                var imgUrl = UploadCv.uploadFile("Uploads/Theme", model.ThemePhoto);
                var data = mapper.Map<Theme>(model);
                data.ThemeImgUrl = imgUrl;
                _theme.Edite(data);
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _theme.GetById(id);
            var result = mapper.Map<ThemeVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(ThemeVM model)
        {
            UploadCv.RemoveFile("Uploads/Theme", model.ThemeImgUrl);
            var olddata = _theme.GetById(model.Id);
            _theme.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = _theme.GetById(id);

            var result = mapper.Map<ThemeVM>(data);

            return View(result);
        }

    }
}
