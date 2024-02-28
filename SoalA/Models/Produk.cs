using System.ComponentModel.DataAnnotations;

namespace SoalA.Models
{
    public class Produk
    {
        [Key]
        public int id { get; set; }
        public string nama_barang { get; set; }
        public string kode_barang { get; set; }
        public int jumlah_barang { get; set; }
        public DateTime tanggal { get; set; }
    }
}
