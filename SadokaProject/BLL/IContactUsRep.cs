using Microsoft.EntityFrameworkCore;
using Languagy_project.Data.Entities;
using Languagy_project.Data;

namespace Languagy_project.BLL
{
    public interface IContactUsRep
    {
        IEnumerable<ContactUS> Get();
        ContactUS GetById(int id);
        void Creat(ContactUS obj);
        void Edite(ContactUS obj);
        void Delete(ContactUS obj);
    }
    public class ContactUsRep : IContactUsRep
    {
        private readonly LanguagyDbContext db;
        public ContactUsRep(LanguagyDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<ContactUS> Get()
        {
            var All = db.ContactUS.Select(a => a);
            return All;
        }
        public ContactUS GetById(int id)
        {
            var data = db.ContactUS.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public void Creat(ContactUS obj)
        {
            db.ContactUS.Add(obj);
            db.SaveChanges();

        }

        public void Delete(ContactUS obj)
        {
            var olddata = db.ContactUS.Find(obj.Id);
            db.ContactUS.Remove(olddata);
            db.SaveChanges();
        }

        public void Edite(ContactUS obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
