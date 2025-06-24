using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction //Class is like a Blueprint/Template
{
    private float val;
    private DateTime date;

    public void setVal(float val) 
    { 
        if (val > 0)
        this.val = val; 
    }

    public void setDate(DateTime date) { this.date = date; }

    public float getVal() { return val; }

    public DateTime getDate() { return date; }
}