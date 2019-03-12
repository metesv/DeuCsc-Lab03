using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Dikdortgen : Sekil
    {
        /* 
         * Bu şekle özel başka özellikler varsa onlarıda implemente ediniz.
         */

        double uzun;
        double kisa;
        

        public Dikdortgen(int x, int y,double uzun,double kisa) : base(x, y)
        {
            //Eğer eklediğiniz ek özellikleri yaratıcı metota başlatmak isterseniz yaratıcı metotu günceleyebilirsiniz.
            base.X = x;
            base.Y = y;
            this.uzun = uzun;
            this.kisa = kisa;
        }
        /*
         * Abstarct metotlar burada implemente edilmeli.
         */
        public override double AlanHesapla()
        {
            return uzun * kisa;
        }

        public override double CevreHesapla()
        {
            return (uzun + kisa)*2;
        }
    }
}
