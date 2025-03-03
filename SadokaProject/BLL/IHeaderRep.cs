using Microsoft.EntityFrameworkCore;
using Languagy_project.Data;
using Languagy_project.Data.Entities;

namespace Languagy_project.BLL
{
    public interface IHeaderRep
    {
        IEnumerable<Header> Get();
        Header GetById(int id);
        Header GetHeader(int id);
        void Creat(Header obj);
        void Edite(Header obj);
        void Delete(Header obj);
    }
    public class HeaderRep : IHeaderRep
    {
        private readonly LanguagyDbContext db;
        public HeaderRep(LanguagyDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Header> Get()
        {
            var All = db.Header.Select(a => a);
            return All;
        }
        public Header GetById(int id)
        {
            var data = db.Header.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public Header GetHeader(int id)
        {
            var data = db.Header.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public void Creat(Header obj)
        {
            db.Header.Add(obj);
            db.SaveChanges();

        }

        public void Delete(Header obj)
        {
            var olddata = db.Header.Find(obj.Id);
            db.Header.Remove(olddata);
            db.SaveChanges();
        }

        public void Edite(Header obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
