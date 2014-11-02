namespace _03.CableTVCompany
{
    using System.Collections.Generic;

    public class House
    {
        public House()
        {
            this.Paths = new List<Path>();
        }

        public int Id { get; set; }

        public List<Path> Paths { get; set; }
    }
}
