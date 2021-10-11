using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba
{
    public class Araba : Tasit
    {
        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int azamiHiz;

        public int AzamiHiz
        {
            get { return azamiHiz; }
            set { azamiHiz = value; }
        }
        private int arac_Motor_Gucu;

        public int Arac_Motor_Gucu
        {
            get { return arac_Motor_Gucu; }
            set { arac_Motor_Gucu = value; }
        }




    }
}
