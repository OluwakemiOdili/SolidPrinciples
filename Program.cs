namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            var jewelryPriceList = new List<Sales>()
            {
                new NormalPrice(){CostOfData=100,CostOfGoods=100,TransportFare=2000,rate=0.2d},
                new NormalPrice(){CostOfData=100,CostOfGoods=100,TransportFare=2000,rate=0.2d},
                new NormalPrice(){CostOfData=100,CostOfGoods=100,TransportFare=2000,rate=0.2d},
            };
            var clothings = new List<Sales>
            {
                new BlackFriday(){CostOfGoods=2000,CostOfData=4000, TransportFare=2000, },
                new BlackFriday(){CostOfGoods=2000,CostOfData=4000, TransportFare=2000, },
                new BlackFriday(){CostOfGoods=2000,CostOfData=4000, TransportFare=2000, },
            };
            var tot = new TotalPrice();
            Console.WriteLine(tot.TotalPriceExpected(jewelryPriceList));
            Console.WriteLine(tot.TotalPriceExpected(clothings));
            
        }
    }
} 