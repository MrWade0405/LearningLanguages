using System;
using System.Collections.Generic;
using DAL.Models;

namespace DAL.Repositories
{
    public class WordsRepository : IRepository<Words>
    {
        private LearningLanguagesContext db;

        public WordsRepository()
        {
            this.db = new LearningLanguagesContext(ConfigurateOptions.GetOptions());
        }

        public void Create(Words item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Words GetItem(int id)
        {
            return db.Words.Find(id);
        }

        public IEnumerable<Words> GetList()
        {
            return db.Words;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Words item)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
