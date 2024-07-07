using randevuMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace randevuMVC.Veriler
{
    public class MusteriVerileri
    {
        public static List<Musteri> musteriler = new List<Musteri>
        {
            new Musteri
            {
                Id = 1,
                Ad="Gunes",
                Soyad="Aydın",
                Email="gunes@hotmail.com",
                TelefonNo=1234422

            },
            new Musteri
            {
                Id = 2,
                Ad="Ayça",
                Soyad="Bal",
                Email="ayca@hotmail.com",
                TelefonNo=2345678

            },
            new Musteri
            {
                Id = 3,
                Ad="Ata",
                Soyad="Çelik",
                Email="ata@hotmail.com",
                TelefonNo=5436576

            }
        };
    }
}