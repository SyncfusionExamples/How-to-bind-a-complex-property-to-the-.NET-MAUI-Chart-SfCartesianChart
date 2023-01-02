using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Binding
{
    public class ViewModel
    {
       
        public List<ChartDataModel> Data { get; set; }
        public List<ProfitDetails> ProfitData { get; set; }
        public ViewModel()
        {
            Data = new List<ChartDataModel>()
        {
            new ChartDataModel { Month = "January", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{80,67 }, ExpenseRate=60, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 20 } }, },
            new ChartDataModel { Month = "February", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate= new double[]{82,78},ExpenseRate=54, ProfitDetailsObject = new ProfitDetails(){ ProfitPercentage = 28 } }, },
            new ChartDataModel { Month = "March", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{67,55}, ExpenseRate=50, ProfitDetailsObject = new ProfitDetails(){ ProfitPercentage = 17 } }, },
            new ChartDataModel { Month = "April", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{86,72} , ExpenseRate=65, ProfitDetailsObject = new ProfitDetails(){ ProfitPercentage = 31 } }, },
            new ChartDataModel { Month = "May", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{65,89}, ExpenseRate=44, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 21 } }, },
            new ChartDataModel { Month = "June", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{64,67}, ExpenseRate=39, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 25 } }, },
            new ChartDataModel { Month = "July", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate= new double[]{82,78}, ExpenseRate=60, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 22 } }, },
            new ChartDataModel { Month = "August", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{77,55}, ExpenseRate=58, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 19 } }, },
            new ChartDataModel { Month = "September", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{86,72}, ExpenseRate=67, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 19 } }, },
            new ChartDataModel { Month = "October", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{65,89}, ExpenseRate=55 , ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 10 } }, },
            new ChartDataModel { Month = "November", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate = new double[]{74,67}, ExpenseRate=62, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 12 } }, },
            new ChartDataModel { Month = "December", SalesAndExpenseObject = new SalesAndExpenseDetails(){ SalesRate= new double[]{82,78}, ExpenseRate=62, ProfitDetailsObject = new ProfitDetails(){ProfitPercentage = 20 } }, },

        };
           
        }
    }
}
