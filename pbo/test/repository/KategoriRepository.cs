using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.model;
using System.Data.SQLite;

namespace test.repository
{
    class KategoriRepository : IKategoriRepository
    {
        public List<Kategori> Get()
        {
            using (var context = new PsboContext())
            {
                var kategori = context.Kategori.ToList();
                return kategori;
            }

        }
    }
}
