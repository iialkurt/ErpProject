using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CariListDto:IDto
    {
        public string Firma_Adi { get; set; }
        public string Yetkili_Ad_Soyad { get; set; }
        public string Vergi_No { get; set; }
        public string Vergi_Dairesi { get; set; }
        public string Adres { get; set; }
    }
}
