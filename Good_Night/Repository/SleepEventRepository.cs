using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Good_Night;
using Good_Night.Model;
using System.Data.Entity;

namespace Good_Night.Repository
{
    public class SleepEventRepository : ISleepEventRepository
    {
        private SleepEventContext _dbContext;

        public SleepEventRepository()
        {
            _dbContext = new SleepEventContext();
            _dbContext.SleepEvents.Load();
        }

        public SleepEventContext Context()
        {
            return _dbContext;
        }

        public DbSet<Model.SleepEvent> GetDbSet()
        {
            return _dbContext.SleepEvents;
        }

        public int GetCount()
        {
            return _dbContext.SleepEvents.Count<Model.SleepEvent>();
        }

        public void Add(SleepEvent E)
        {
            _dbContext.SleepEvents.Add(E);
            _dbContext.SaveChanges();
        }

        public void Delete(SleepEvent E)
        {
            _dbContext.SleepEvents.Remove(E);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.SleepEvents.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<SleepEvent> PastEvents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.SleepEvent> All()
        {
            var query = from SleepEvent in _dbContext.SleepEvents select SleepEvent;
            return query.ToList<Model.SleepEvent>();
        }

        public Model.SleepEvent GetById(int id)
        {
            var query = from SleepEvent in _dbContext.SleepEvents
                        where SleepEvent.SleepEventId == id
                        select SleepEvent;
            return query.First<Model.SleepEvent>();
        }

        private IEnumerable<int> query;

        public IEnumerable<int> AllHours()
        {
            query = from SleepEvent in _dbContext.SleepEvents 
                        select SleepEvent.Hours;
            return query.ToList<int>();
        }

        public int SumHours()
        {
            AllHours();
            int SumHour = query.Sum();
            return SumHour;    
        }

        public SleepEvent GetByDate(string date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SleepEvent> SearchFor(System.Linq.Expressions.Expression<Func<SleepEvent, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
