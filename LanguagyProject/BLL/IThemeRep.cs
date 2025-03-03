using Microsoft.EntityFrameworkCore;
using Languagy_project.Data.Entities;
using Languagy_project.Data;

namespace Languagy_project.BLL
{
    public interface IThemeRep
    {
        IEnumerable<Theme> Get();
        Theme GetById(int id);
        void Creat(Theme obj);
        void Edite(Theme obj);
        void Delete(Theme obj);
    }
    public class ThemeRep : IThemeRep
    {
        private readonly LanguagyDbContext db;
        public ThemeRep(LanguagyDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Theme> Get()
        {
            var All = db.Theme.Select(a => a);
            return All;
        }
        public Theme GetById(int id)
        {
            var data = db.Theme.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public void Creat(Theme obj)
        {
            db.Theme.Add(obj);
            db.SaveChanges();

        }

        public void Delete(Theme obj)
        {
            var olddata = db.Theme.Find(obj.Id);
            db.Theme.Remove(olddata);
            db.SaveChanges();
        }

        public void Edite(Theme obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
