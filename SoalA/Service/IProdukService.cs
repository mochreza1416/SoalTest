using SoalA.Models;

namespace SoalA.Service
{
    public interface IProdukService
    {
        List<Produk> Search(string name);
        void Save(Produk produk);
        void Update(Produk produk);
        void Delete(int produkId);
    }
}
