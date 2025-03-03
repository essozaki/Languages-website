using Microsoft.EntityFrameworkCore;
using Languagy_project.Data;
using Languagy_project.Data.Entities;

namespace Languagy_project.BLL
{
    public interface IPartnersRep
    {
        IEnumerable<Partners> Get();
        Partners GetById(int id);
        void Creat(Partners obj);
        void Edite(Partners obj);
        void Delete(Partners obj);
    }
    public class PartnersRep : IPartnersRep
    {
        private readonly LanguagyDbContext db;
        public PartnersRep(LanguagyDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Partners> Get()
        {
            var All = db.Partners.Select(a => a);
            return All;
        }
        public Partners GetById(int id)
        {
            var data = db.Partners.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public void Creat(Partners obj)
        {
            db.Partners.Add(obj);
            db.SaveChanges();

        }

        public void Delete(Partners obj)
        {
            var olddata = db.Partners.Find(obj.Id);
            db.Partners.Remove(olddata);
            db.SaveChanges();
        }

        public void Edite(Partners obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
