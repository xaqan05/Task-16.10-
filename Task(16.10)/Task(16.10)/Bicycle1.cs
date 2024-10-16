using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16._10_
{

    public class Bicycle : Vehicle1
    {
        private int _wheelNum;

        public int WhellNum
        {
            get
            {
                return _wheelNum;
            }
            set
            {
                if (value > 0 && value < 5)
                {

                    _wheelNum = value;
                }
            }
        }

        public Bicycle(string brand, string model, double mile, int whellNum) : base(brand, model, mile)
        {
            WhellNum = whellNum;
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, Doors Num: {WhellNum}");
        }

    }
}
