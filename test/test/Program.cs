using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var db = new OOPCSEntities();
            var List = db.Expenditures.ToArray();
            //foreach (var expenditure in expenditures)
                //sum = sum + expenditure.Price;
            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine("Order: {0}, Time: {1}, Price: {2} VND, Meal: {3}", List[i].id, List[i].Date, List[i].Price, List[i].Note);
                sum += List[i].Price;
            }
            Console.WriteLine("Sum of meals: " + sum + " VND");
        }
    }
}
