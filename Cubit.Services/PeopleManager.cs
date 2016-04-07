using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubit.Data;
using Cubit.Data.People;
using Cubit.Data.Models;

namespace Cubit.Services
{
    public class PeopleManager
    {
        private const int InitialCount = 10000;

        private static List<Person> _People = new List<Person>(InitialCount);  // put size here to improve the performance
        
        
        public PeopleManager()
        {
            InitPeople();            
        }


        // Initiate the collection with 10,000 mixed person objects
        private void InitPeople()
        {
            if (_People.Count() == 0)
            {
                var rnd = new Random();
                for (int i = 0; i< InitialCount; i++)
                {
                    // Get random race object, restrict the number to the valid enum number
                    var race = rnd.Next(1,5);       
                    var person = PeopleFactory.GetPersonInstance( (PeopleFactory.Races)race);
                    person.Name = "Person #" + i.ToString();
                    person.Age = rnd.Next(1,99);
                    _People.Add(person);
                }
            }
        }


        // Get people collection
        public List<Person> People
        {
            get { return _People; }
        }


        // Add one year to the age for all the people in the collection
        public List<Person> AddOneYearToAge()
        {
            foreach (var person in _People)
            {
                person.Age++;
            }
            return _People;
        }


        // Get list of people for the selected race and even age
        public List<PersonModel> GetSelectedPeople(PeopleFactory.Races race, int topN)
        {
            var query = _People.Where(x => x.Race == race && x.Age % 2 == 0).OrderBy(x => x.Age)
                        .Select(s => new PersonModel()
                            {
                                Name = s.Name,
                                Age = s.Age,
                                Height = s.Height
                            }
                        );     // AutoMapper can be used in production environment
            if (topN != 0)
                return query.Take(topN).ToList();
            else
                return query.ToList();
        }
    }
}
