using Microsoft.EntityFrameworkCore;
using Languagy_project.Data.Entities;
using Languagy_project.Data;

namespace Languagy_project.BLL
{
    public interface IFeaturesRep
    {
        IEnumerable<Features> Get();
        Features GetById(int id);
        void Creat(Features obj);
        void Edite(Features obj);
        void Delete(Features obj);
    }
    public class FeaturesRep : IFeaturesRep
    {
        private readonly LanguagyDbContext db;
        public FeaturesRep(LanguagyDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Features> Get()
        {
            var All = db.Features.Select(a => a);
            return All;
        }
        public Features GetById(int id)
        {
            var data = db.Features.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public void Creat(Features obj)
        {
            db.Features.Add(obj);
            db.SaveChanges();

        }

        public void Delete(Features obj)
        {
            var olddata = db.Features.Find(obj.Id);
            db.Features.Remove(olddata);
            db.SaveChanges();
        }

        public void Edite(Features obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
