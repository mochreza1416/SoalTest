using Microsoft.EntityFrameworkCore;
using SoalA.Context;
using SoalA.Models;

namespace SoalA.Service
{
    public class ProdukService : IProdukService
    {
        DatabaseContext _dbContext = null;

        public ProdukService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int produkId)
        {
            _dbContext.Database.ExecuteSqlRaw($"SP_Delete_Product {produkId}");
        }

        public void Save(Produk produk)
        {
            var tanggal = produk.tanggal.ToString("yyyy-MM-dd");
            _dbContext.Database.ExecuteSqlRaw($"SP_Insert_Product '{produk.nama_barang}', '{produk.kode_barang}', {produk.jumlah_barang}, '{tanggal}' ");
        }

        public List<Produk> Search(string name)
        {
            var produks = _dbContext.Produks.FromSqlRaw($"SP_Search_Product {name}").ToList();
            return produks;
        }

        public void Update(Produk produk)
        {
            var tanggal = produk.tanggal.ToString("yyyy-MM-dd");
            _dbContext.Database.ExecuteSqlRaw($"SP_Update_Product {produk.id}, '{produk.nama_barang}', '{produk.kode_barang}', {produk.jumlah_barang}, '{tanggal}'");
        }
    }
}
