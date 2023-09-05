using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCariDal : EfEntityRepositoryBase<Cari, ErpContext>, ICariDal
    {
        public List<CariListDto> GetCariList()
        {
            using (ErpContext erpContext = new ErpContext())
            {
                var result = from c in erpContext.Cariler
                             select new CariListDto
                             {
                                 Firma_Adi = c.Firma_Adi,
                                 Yetkili_Ad_Soyad = c.Yetkili_Ad_Soyad,
                                 Adres = c.Adres,
                                 Vergi_Dairesi = c.Vergi_Dairesi,
                                 Vergi_No = c.Vergi_No
                                
                             };
                
                return result.ToList(); 
                            
            }
        }
    }
    }
