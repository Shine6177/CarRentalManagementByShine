namespace CarRentalManagementByShine.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }

        public string? LicensePlateNumber { get; set; }

        // Foreign Keys
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
    }
}
