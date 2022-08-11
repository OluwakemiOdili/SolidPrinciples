using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public abstract class Sales
    {
        public double CostOfGoods { get; set; }
        public double TransportFare { get; set; }   
        public double CostOfData { get; set; }
        public abstract double PriceOfGoods();
    }

    public class TotalPrice
    {
        public double TotalPriceExpected(List<Sales> sales)
        {
            double amount=0;
            try
            {
                foreach (var price in sales)
                {
                    amount += price.PriceOfGoods();
                }
                return amount;
            }
            catch (Exception err)
            {

                return 0;
            }
        }
    }

    public class NormalPrice:Sales
    {
        public double rate { get; set; }
        public override double PriceOfGoods ()

        {// this is the cost of sales
            double price = ((CostOfGoods + TransportFare + CostOfData) * rate) + (CostOfGoods + TransportFare + CostOfData);
            return price;
           
        } 
     }

    public class BlackFriday: Sales
    {
        // actual cost of goods/product to prevent funds loss after a long period of time 
        public override double PriceOfGoods ()
        {
            double price = CostOfGoods + TransportFare + CostOfData;
            return price;
        }
    }    

}
