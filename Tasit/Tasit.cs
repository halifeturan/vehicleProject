using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasit
{
    public class Tasit
    {
        private string tasitTipi;

        public string TasitTipi
        {
            get { return tasitTipi; }
            set { tasitTipi = value.ToUpper(); }
        }

        private int fiyati;

        public int Fiyati
        {
            get { return fiyati; }
            set { fiyati = value = Math.Abs(value); }
        }
        public virtual string TasitBilgiYazdir()
        {
            return $"Taşıt Tipi: {this.tasitTipi} \nTaşıt Fiyatı: {this.fiyati}\n";
        }
        



    }
}
