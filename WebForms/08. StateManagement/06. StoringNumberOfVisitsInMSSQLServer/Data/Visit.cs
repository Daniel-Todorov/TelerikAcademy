namespace _06.StoringNumberOfVisitsInMSSQLServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visit
    {
        public int Id { get; set; }

        public int NumberOfVisits { get; set; }
    }
}
