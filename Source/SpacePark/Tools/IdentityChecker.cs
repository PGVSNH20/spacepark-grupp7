using SpacePark.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Tools
{
    public static class IdentityChecker
    {
        public static bool TestIfStarWarsActor(PeopleData pd, string name)
        {
            foreach (PersonalData person in pd.results)
            {
                if (person.name.ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
