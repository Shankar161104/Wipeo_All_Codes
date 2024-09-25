using Wipro_API_CodeFirstApproach.Entity_Framework;
using Wipro_API_CodeFirstApproach.Model;

namespace Wipro_API_CodeFirstApproach.Repository
{
    
    public class VehicleService : IVehicleService
    {

        private readonly ApplicationDbContext applicationDbContext;

        public VehicleService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public Vehicle CreateVehicle(Vehicle vehicle)
        {
            var result=applicationDbContext.Add(vehicle);
             applicationDbContext.SaveChanges();
            return result.Entity;
        }

        

        public IEnumerable<Vehicle> GetVehicle()
        {
            return applicationDbContext.Vehicles.ToList();
        }

        public Vehicle SearchVehicle(int id)
        {
            return applicationDbContext.Vehicles.Where(x=>x.VehicleID==id).FirstOrDefault();

        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            var result = applicationDbContext.Update(vehicle);
            applicationDbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteVehicle(int vehicleID)
        {
            var filteredData = applicationDbContext.Vehicles.Where(x => x.VehicleID==vehicleID).FirstOrDefault();
            var result = applicationDbContext.Vehicles.Remove(filteredData);
            applicationDbContext.SaveChanges();
            return result != null ? true : false;


        }  
       
    }
}
