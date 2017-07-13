using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.model
{
    [Table("detail_transaksi")]
    public partial class DetailTransaksi
    {
        [Column("id_transaksi", TypeName = "bigint")]
        public long IdTransaksi { get; set; }
        [Column("id_barang", TypeName = "bigint")]
        public long IdBarang { get; set; }
        [Column("jumlah_barang", TypeName = "bigint")]
        public long JumlahBarang { get; set; }
        [Required]
        [Column("harga_barang", TypeName = "numeric(53,0)")]
        public string HargaBarang { get; set; }
    }
}
