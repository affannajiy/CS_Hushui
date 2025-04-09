using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    //Interface: a contract, all methods inside are 100% abstract
    //Abstract: no implementation
    public interface Payable
    {
        float CalcCost();
        //Whenever a class implements this interface, it has to provide the implementation (contract)
    }
}
