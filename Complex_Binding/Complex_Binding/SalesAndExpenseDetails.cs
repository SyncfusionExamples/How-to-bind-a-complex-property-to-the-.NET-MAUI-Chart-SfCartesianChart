using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Binding
{
    public class SalesAndExpenseDetails
    {
        public double ExpenseRate { get; set; }
        public double[] SalesRate { get; set; }

        public ProfitDetails ProfitDetailsObject { get; set; }
    }
}
