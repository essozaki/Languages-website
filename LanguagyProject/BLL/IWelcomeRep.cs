using Microsoft.EntityFrameworkCore;
using Languagy_project.Data.Entities;
using Languagy_project.Data;

namespace Languagy_project.BLL
{
    public interface IWelcomeRep
    {
        IEnumerable<Welcome> Get();
        Welcome GetById(int id);
        void Creat(Welcome obj);
        void Edite(Welcome obj);
        void Delete(Welcome obj);
    }
    public class WelcomeRep : IWelcomeRep
    {
        private readonly LanguagyDbContext db;
        public WelcomeRep(LanguagyDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Welcome> Get()
        {
            var All = db.Welcome.Select(a => a);
            return All;
        }
        public Welcome GetById(int id)
        {
            var data = db.Welcome.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public void Creat(Welcome obj)
        {
            db.Welcome.Add(obj);
            db.SaveChanges();

        }

        public void Delete(Welcome obj)
        {
            var olddata = db.Welcome.Find(obj.Id);
            db.Welcome.Remove(olddata);
            db.SaveChanges();
        }

        public void Edite(Welcome obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
