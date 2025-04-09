using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    //contains list of payables
    public class Account
    {
        List<Payable> payables = new List<Payable>();

        //Add Payable
        public void AddPayable(Payable payable)
        {
            payables.Add(payable);
        }

        //Total
        public float Total()
        {
            float total = 0;
            foreach (Payable p in payables)
            {
                total += p.CalcCost();
            }
            return total;
        }
    }
}
