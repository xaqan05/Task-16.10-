using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16._10_
{
    public class Vehicle1
    {
        private string _brand;
        private string _model;
        private double _mile;



        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _brand = value;
                }
            }
        }
        public string Model
        {
            get
            {

                return _model;
            }
            set
            {

                if (value.Length > 3 && value.Length < 30)
                {
                    _model = value;
                }


            }
        }
        public double Mile
        {
            get
            {
                return _mile;
            }
            set
            {
                if (value > 0)
                {
                    _mile = value;
                }
            }
        }

        public Vehicle1(string brand,string model,double mile)
        {
            Brand = brand;
            Model = model;
            Mile = mile;
        }




    }
}
