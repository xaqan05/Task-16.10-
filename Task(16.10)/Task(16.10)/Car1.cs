using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16._10_
{
    public class Car1 : Vehicle1
    {
        private int _doorsNum;

        public int DoorsNum
        {
            get
            {
                return _doorsNum;
            }
            set
            {
                if (value > 0 && value < 5)
                {

                    _doorsNum = value;
                }
            }
        }

        public Car1(string brand,string model,double mile,int doorsNum):base(brand,model,mile)
        {
            DoorsNum = doorsNum;
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, Doors Num: {DoorsNum}");
        }
    }
}
