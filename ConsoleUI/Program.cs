// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CariManager cariManager = new CariManager(new EfCariDal());
foreach (var item in cariManager.GetAll())
{
    Console.WriteLine(item.Firma_Adi);
}