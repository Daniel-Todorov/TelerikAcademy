namespace CarsModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Car
    {
        public int CarId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        public int ManufacturerId { get; set; }

        [Required]
        public TransmissionType TransmissionType { get; set; }

        public int Year { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int DealerId { get; set; }

        public virtual Dealer Dealer { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
