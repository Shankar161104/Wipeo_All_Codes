using Wipro_API_CodeFirstApproach.Model;

namespace Wipro_API_CodeFirstApproach.Repository
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetVehicle();
        Vehicle SearchVehicle(int id);
        Vehicle UpdateVehicle(Vehicle vehicle);
        Vehicle CreateVehicle(Vehicle vehicle);
        bool DeleteVehicle(int vehicleID);
      
    }
}
