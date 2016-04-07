using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubit.Data.People
{
    public class PeopleFactory
    {
        // This enum is also used to populate drowdown, so it can be in line when filtering the result by races
        public enum Races
        {
            Angle = 1,      // This number is used in initiating collection with random races
            Saxon = 2,
            Jute = 3,
            Asian = 4
        }

        // Create insteace of person
        public static Person GetPersonInstance(Races race)
        {
            switch (race)
            {
                case Races.Angle:
                    return new Angle();
                case Races.Saxon:
                    return new Saxon();
                case Races.Jute:
                    return new Jute();
                case Races.Asian:
                    return new Asian();
                default:
                    return null;
            }
        }

    }
}
