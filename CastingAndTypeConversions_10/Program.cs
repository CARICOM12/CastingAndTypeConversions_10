using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingAndTypeConversions_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int ruPerAnnum2014;
            int ruPerAnnum2015;
            int ruPerAnnum2016;
            int ruPerAnnum2017;

            ruPerAnnum2014 = 69614;
            ruPerAnnum2015 = 72436;
            ruPerAnnum2016 = 75444;
            ruPerAnnum2017 = 77177;

            int resultFrom14To17;
            int resultPerAnnum;


            double r2014, r2017, resultF14To17, result, res1;

            r2014 = ruPerAnnum2014;
            r2017 = ruPerAnnum2017;
            resultF14To17 = r2017 - r2014;
            res1 = resultF14To17 / r2014;
            result = res1 * 100;
            Console.WriteLine("Residents of Finland by native language growth in percentage points (in this case (Russian)):  " + result);
        }
    }
}
