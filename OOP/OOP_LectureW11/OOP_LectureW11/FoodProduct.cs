using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    internal class FoodProduct : Payable
    {
        public float UnitAmount { get; set; }
        public float UnitPrice { get; set; }

        //Calculate Cost (contract fullfilled)
        public float CalcCost() 
        {
            return UnitAmount * UnitPrice;
        }
    }
}
