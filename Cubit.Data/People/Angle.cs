using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubit.Data.People
{
    public class Angle:Person
    {

        public override double Height
        {
            get 
            {
                // Formula to calculate height for Angles
                var height = 1.5 + Age*0.45;        
                return Math.Round(height, 2);
            }
        }
    }
}
