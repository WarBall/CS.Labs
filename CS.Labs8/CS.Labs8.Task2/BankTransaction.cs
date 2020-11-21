using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BankTransaction
{
    private decimal anount;
    private DateTime when;

    public decimal Amount()
    {
        return anount;
    }

    public DateTime When()
    {
        return when;
    }

    public BankTransaction (decimal tranAmount)
    {
        anount = tranAmount;
        when = DateTime.Now;
    }
}

