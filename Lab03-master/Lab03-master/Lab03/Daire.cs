using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Daire : Sekil
    {
        /* 
         * Bu şekle özel başka özellikler varsa onlarıda implemente ediniz.
         */

        double r;

        public Daire(int x, int y, double r) : base(x, y)
        {
            //Eğer eklediğiniz ek özellikleri yaratıcı metota başlatmak isterseniz yaratıcı metotu günceleyebilirsiniz.
            base.X = x;
            base.Y = y;
            this.r = r;
        }
        /*
         * Abstarct metotlar burada implemente edilmeli.
         */
        public override double AlanHesapla()
        {
            return Math.PI * this.r * this.r;
        }
        public override double CevreHesapla()
        {
            return 2 * Math.PI * this.r;
        }

    }
}
