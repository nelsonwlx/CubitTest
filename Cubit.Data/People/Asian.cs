using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubit.Data.People
{
    public class Asian:Person
    {
        public override double Height
        {
            get
            {
                // Formula to calculate height for Asians
                var height = (1.7 + (Age + 2)*0.23);
                return Math.Round(height, 2);
            }
        }
    }
}
