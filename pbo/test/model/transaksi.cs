using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.model
{
    [Table("transaksi")]
    public partial class Transaksi
    {
        [Column("id_transaksi")]
        [Key]
        public long IdTransaksi { get; set; }
        [Required]
        [Column("jumlah_pembelian", TypeName = "numeric(53,0)")]
        public string JumlahPembelian { get; set; }
        [Column("diskon", TypeName = "bigint")]
        public long? Diskon { get; set; }
        [Required]
        [Column("total_pembelian", TypeName = "numeric(53,0)")]
        public string TotalPembelian { get; set; }
        [Required]
        [Column("total_harga", TypeName = "numeric(53,0)")]
        public string TotalHarga { get; set; }
        [Required]
        [Column("tanggal_trans", TypeName = "text")]
        public string TanggalTrans { get; set; }
    }
}
