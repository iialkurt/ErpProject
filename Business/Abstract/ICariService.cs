using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICariService
    {

       
        List<Cari> GetAll();
        void Add(Cari cari);
        void Update(Cari cari);
        void Delete(Cari cari);
        List<CariListDto> GetCariList();

    }
}
