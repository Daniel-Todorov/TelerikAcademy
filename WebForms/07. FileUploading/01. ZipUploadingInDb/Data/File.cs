namespace _01.ZipUploadingInDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class File
    {
        public int Id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string FileContent { get; set; }

        [StringLength(50)]
        [Required]
        public string FileName { get; set; }
    }
}
