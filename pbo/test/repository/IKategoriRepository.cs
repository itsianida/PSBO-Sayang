using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.model;

namespace test.repository
{
    public interface IKategoriRepository
    {
        List<Kategori> Get();
    }
}
