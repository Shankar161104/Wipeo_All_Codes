using DBA_29th_August.Models;

namespace DBA_29th_August.Repository
{
    public interface IDurgaRepository
    {
        Durga CreateDurga(Durga durga);
        Durga UpdateDurga(Durga durga);
        IEnumerable<Durga> GetDurga();
    }
}
