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
        public static bool TestIfStarWarsActor(List<PersonalData> personDataFromSWAPI, string userNameInput)
        {
            foreach (PersonalData personFromSWAPIList in personDataFromSWAPI)
            {
                if (personFromSWAPIList.Name.ToLower() == userNameInput.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
