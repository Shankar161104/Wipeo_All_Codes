using DBA_29th_August.EntityFrameWork;
using DBA_29th_August.Models;

namespace DBA_29th_August.Repository
{
    public class DurgaRepository : IDurgaRepository
    {
        private readonly Dfa29082024Context dfa29082024Context;
        public DurgaRepository(Dfa29082024Context _dfa29082024Context)
        {
            dfa29082024Context = _dfa29082024Context;
        }
        public Durga CreateDurga(Durga durga)
        {
           dfa29082024Context.Durgas.Add(durga);
           dfa29082024Context.SaveChanges();
           return durga;
             
        }

        public Durga UpdateDurga(Durga durga)
        {
            if (durga == null)
            {
                throw new ArgumentException("Entity is missing");
            }
            var filteredDurga = dfa29082024Context.Durgas.Update(durga);
            dfa29082024Context.SaveChanges();
            return filteredDurga.Entity;

        }

       public IEnumerable<Durga> GetDurga()
        {
            return dfa29082024Context.Durgas.ToList();
        }
    }
}
