namespace CarRentalManagementByShine.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Foreign Keys
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
    }
}
