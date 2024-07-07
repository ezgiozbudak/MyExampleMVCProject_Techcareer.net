using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace randevuMVC.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get;set; }
        public string Email { get; set; }
        public int TelefonNo { get; set; }
    }
}