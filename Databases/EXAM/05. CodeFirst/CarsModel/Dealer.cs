namespace CarsModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Dealer
    {
        public Dealer()
        {
            Cars = new HashSet<Car>();
            Cities = new HashSet<City>();
        }

        public int DealerId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
