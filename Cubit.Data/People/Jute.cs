using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubit.Data.People
{
    public class Jute:Person
    {

        public override double Height
        {
            get
            {
                // Formula to calculate height for Jutes
                var height = (Age * 1.6)/2;        
                return Math.Round(height, 2);
            }
        }

    }
}
