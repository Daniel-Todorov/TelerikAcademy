namespace CarsModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class City
    {
        public City()
        {
            Dealers = new HashSet<Dealer>();
        }

        public int CityId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Dealer> Dealers { get; set; }
    }
}
