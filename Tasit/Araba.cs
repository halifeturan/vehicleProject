using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tasit
{
    public class Araba : Tasit
    {
        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value.ToUpper(); }
        }
        public override string TasitBilgiYazdir() {
            return $"{base.TasitBilgiYazdir()}Araba Markası: {this.marka}\nAraba Modeli: {this.model}";
        }


    }
}
