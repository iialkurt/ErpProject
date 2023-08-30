using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cari:IEntity
    {

        public int Id { get; set; }
        public string? Firma_Adi { get; set; }
        public string? Yetkili_Ad_Soyad { get; set; }
        public string? Vergi_No { get; set; }
        public string? Vergi_Dairesi { get; set; }
        public string? Adres { get; set; }
        public string? Ulke { get; set; }
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public string? Semt { get; set; }
        public string? Telefon { get; set; }
        public  string? Mail { get; set; }
    }
}
