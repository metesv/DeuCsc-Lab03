using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Dikucgen : Sekil
    {
        /* 
         * Bu şekle özel başka özellikler varsa onlarıda implemente ediniz.
         */

        double h;
        double f;

        

        public Dikucgen(int x, int y,double f, double h) : base(x, y)
        {
            base.X = x;
            base.Y = y;
            this.h = h;
            this.f = f;
            //Eğer eklediğiniz ek özellikleri yaratıcı metota başlatmak isterseniz yaratıcı metotu günceleyebilirsiniz.
        }

        /*
         * Abstarct metotlar burada implemente edilmeli.
         */
        public override double AlanHesapla()
        {
            return (h * f) / 2;
        }

        public override double CevreHesapla()
        {
            return Math.Sqrt((Math.Pow(f,2)+Math.Pow(h,2))) + h + f;
        }
    }
}
