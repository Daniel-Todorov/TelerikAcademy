namespace CarsModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Cars = new HashSet<Car>();
        }

        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
