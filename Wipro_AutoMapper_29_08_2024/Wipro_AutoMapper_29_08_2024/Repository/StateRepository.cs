using Microsoft.EntityFrameworkCore;
using Wipro_AutoMapper_29_08_2024.EntityFrameWork;
using Wipro_AutoMapper_29_08_2024.Models;

namespace Wipro_AutoMapper_29_08_2024.Repository
{
    public class StateRepository : IStateRepository
    {
        private readonly WiproDfa29082024Context wiproDfa29082024Context;
        public StateRepository(WiproDfa29082024Context _wiproDfa29082024Context)
        {
            wiproDfa29082024Context = _wiproDfa29082024Context;
            
        }
        public int CreateState(State state)
        {
            wiproDfa29082024Context.States.Add(state);
            return wiproDfa29082024Context.SaveChanges();
        }

        public int DeleteState(State state)
        {
            wiproDfa29082024Context.States.Remove(state);
            return wiproDfa29082024Context.SaveChanges();
        }

        public IEnumerable<State> GetStates()
        {
            return wiproDfa29082024Context.States.ToList();
        }

        public State SearchState(int id)
        {
            return wiproDfa29082024Context.States.Where(s=>s.StateId==id).FirstOrDefault();
        }

        public int UpdateState(State state)
        {
            wiproDfa29082024Context.States.Update(state);
            return wiproDfa29082024Context.SaveChanges();
        }
    }
}
