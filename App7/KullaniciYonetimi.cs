using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    //Solid=> Single Responsibility Prencisible
    public class KullaniciYonetimi
    {
        public bool Login(Kullanici k)
        {
            if (k.KullaniciAdi == "admin" && k.Sifre == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Register(Kullanici k)
        {

            return true;
        }
    }
}
