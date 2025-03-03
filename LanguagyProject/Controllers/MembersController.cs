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
    public class MembersController : Controller
    {
        private readonly IMembersRep _members;
        private readonly IMapper mapper;
        public MembersController(IMembersRep members, IMapper mapper)
        {
            this._members = members;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = _members.Get();
            var result = mapper.Map<IEnumerable<MembersVM>>(data);
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
        public IActionResult Create(MembersVM model)
        {
            var imgUrl = UploadCv.uploadFile("Uploads/Members", model.MemberPhoto);
            var data = mapper.Map<Members>(model);
            data.MemberImgUrl = imgUrl;

            _members.Creat(data);
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult Edite(int id)

        {
            var data = _members.GetById(id);
            var result = mapper.Map<MembersVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edite(MembersVM model)

        {
            if (model.MemberPhoto == null)
            {
                var url = model.MemberImgUrl;
                var data = mapper.Map<Members>(model);
                data.MemberImgUrl = url;
                _members.Edite(data);
                return RedirectToAction("Index");
            }
            else
            {
                var imgUrl = UploadCv.uploadFile("Uploads/Members", model.MemberPhoto);
                var data = mapper.Map<Members>(model);
                data.MemberImgUrl = imgUrl;
                _members.Edite(data);
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _members.GetById(id);
            var result = mapper.Map<MembersVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(MembersVM model)
        {
            UploadCv.RemoveFile("Uploads/Members", model.MemberImgUrl);
            var olddata = _members.GetById(model.Id);
            _members.Delete(olddata);
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)

        {

            var data = _members.GetById(id);

            var result = mapper.Map<MembersVM>(data);

            return View(result);
        }

    }
}
