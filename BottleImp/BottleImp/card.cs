using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleImp
{
    class Card
    {

        public int CardNumber { get; set; }

        public Color ColorValue { get; set; }

        public int CoinValue { get; set; }


        public override string ToString()
        {
            return String.Format($"{CardNumber:00}-{ColorValue.Name.Substring(0, 3).ToUpper()}");
        }


    }
}
