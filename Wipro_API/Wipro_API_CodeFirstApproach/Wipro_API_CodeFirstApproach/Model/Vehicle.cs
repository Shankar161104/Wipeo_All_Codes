using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;


namespace Wipro_API_CodeFirstApproach.Model
{
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }
        public string VehicleRegistNumber { get; set; }
        public string VehicleBrandName { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleManufactureYear { get; set; }
        public int VehiclePrice { get; set; }
        public string VehicleColor { get; set; }
        public int VehicleMileage { get; set; }
        public DateTime VehicleDate { get; set; }
    }
}
