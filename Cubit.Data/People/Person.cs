using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubit.Data.People
{
    public abstract class Person
    {

        public string Name { get; set; }

        private int _Age;
        public int Age 
        {
            get { return _Age; }
            set 
            {
                // Safe guard
                if (value < 0)
                    throw new Exception("Age must be great than 0.");
                else
                    _Age = value;

            }
        }

        // Read only property implemented in derived classes, pull from age instead of calculating in property Age to gain a bit performance.
        public abstract double Height {get;}

        // Read only property to get race of each intance
        public PeopleFactory.Races Race
        {
            get
            {
                var type = this.GetType();
                if (type == typeof(Angle))
                    return PeopleFactory.Races.Angle;
                else if (type == typeof(Saxon))
                    return PeopleFactory.Races.Saxon;
                else if (type == typeof(Jute))
                    return PeopleFactory.Races.Jute;
                else if (type == typeof(Asian))
                    return PeopleFactory.Races.Asian;
                else
                    throw new Exception("Unknown person types");
            }
        }

        public override string ToString()
        {
            return string.Format("My name is '{0}' and I am {1} years old.", Name, Age);
        }
    }
}
