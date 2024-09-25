using Wipro_AutoMapper_29_08_2024.Models;

namespace Wipro_AutoMapper_29_08_2024.Repository
{
    public interface IStateRepository
    {
        IEnumerable<State> GetStates();
        State SearchState(int id);
        int UpdateState(State state);
        int CreateState(State state);
        int DeleteState(State state);
    }
}
