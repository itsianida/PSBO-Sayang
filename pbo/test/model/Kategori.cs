using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.model
{
    [Table("kategori")]
    public partial class Kategori
    {
        public long Id { get; set; }
        [Required]
        [Column("kategori_barang", TypeName = "text")]
        public string KategoriBarang { get; set; }
    }
}
