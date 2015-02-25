using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Good_Night.Model;

namespace Good_Night.Repository
{
    public interface ISleepEventRepository
    {
        int GetCount(); //
        void Add(SleepEvent E); //
        void Delete(SleepEvent E); //
        void Clear(); //
        IEnumerable<SleepEvent> PastEvents(); //
        IEnumerable<SleepEvent> All(); //
        SleepEvent GetById(int id); //
        SleepEvent GetByDate(string date); //
        IQueryable<SleepEvent> SearchFor(Expression<Func<SleepEvent, bool>> predicate);
        IEnumerable<int> AllHours();
    }
}
