using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wipro_API_CodeFirstApproach.Model
{
    public class VehicleMap
    {
        public VehicleMap(EntityTypeBuilder<Vehicle> entityTypeBuilderVehicle)
        {
            entityTypeBuilderVehicle.HasKey(veh => veh.VehicleID);
            entityTypeBuilderVehicle.Property(veh=>veh.VehicleID).IsRequired();
            entityTypeBuilderVehicle.Property(veh=>veh.VehicleBrandName).IsRequired();
            entityTypeBuilderVehicle.Property(veh=>veh.VehicleBrandName).HasMaxLength(50);
            entityTypeBuilderVehicle.Property(veh => veh.VehicleManufactureYear).IsRequired();
            entityTypeBuilderVehicle.Property(veh => veh.VehicleManufactureYear).HasMaxLength(4);
            entityTypeBuilderVehicle.Property(veh=>veh.VehiclePrice).IsRequired();
            entityTypeBuilderVehicle.Property(veh=>veh.VehicleRegistNumber).IsRequired();
            entityTypeBuilderVehicle.Property(veh=>veh.VehicleColor).IsRequired();
            entityTypeBuilderVehicle.Property(veh=>veh.VehicleMileage).IsRequired();
            entityTypeBuilderVehicle.Property(veh=>veh.VehicleModel).IsRequired();



        }
    }
}
