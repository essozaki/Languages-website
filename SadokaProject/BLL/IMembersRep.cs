using Microsoft.EntityFrameworkCore;
using Languagy_project.Data.Entities;
using Languagy_project.Data;

namespace Languagy_project.BLL
{
    public interface IMembersRep
    {
        IEnumerable<Members> Get();
        Members GetById(int id);
        void Creat(Members obj);
        void Edite(Members obj);
        void Delete(Members obj);
    }
    public class MembersRep : IMembersRep
    {
        private readonly LanguagyDbContext db;
        public MembersRep(LanguagyDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Members> Get()
        {
            var All = db.Members.Select(a => a);
            return All;
        }
        public Members GetById(int id)
        {
            var data = db.Members.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
        public void Creat(Members obj)
        {
            db.Members.Add(obj);
            db.SaveChanges();

        }

        public void Delete(Members obj)
        {
            var olddata = db.Members.Find(obj.Id);
            db.Members.Remove(olddata);
            db.SaveChanges();
        }

        public void Edite(Members obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
