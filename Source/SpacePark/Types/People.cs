using System;
using System.Collections.Generic;

namespace SpacePark.Types
{
    public class PersonalData
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Skin_color { get; set; }
        public string Eye_color { get; set; }
        public string Birth_year { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public IList<string> Films { get; set; }
        public IList<string> Species { get; set; }
        public IList<string> Vehicles { get; set; }
        public IList<string> Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string URL { get; set; }
    }

    public class PeopleData
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public IList<PersonalData> Results { get; set; }
    }
}
