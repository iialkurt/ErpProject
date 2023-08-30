using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CariManager : ICariService
    {
        ICariDal _cariDal;

        public CariManager(ICariDal cariDal)
        {
            _cariDal = cariDal;
        }

        public void Add(Cari cari)
        {
            _cariDal.Add(cari); 
            
        }

        public void Delete(Cari cari)
        {
            throw new NotImplementedException();
        }

        public List<Cari> GetAll()
        {
           return _cariDal.GetAll();
        }

        public List<CariListDto> GetCariList()
        {
            return _cariDal.GetCariList();
        }

        public void Update(Cari cari)
        {
            throw new NotImplementedException();
        }
    }
}
