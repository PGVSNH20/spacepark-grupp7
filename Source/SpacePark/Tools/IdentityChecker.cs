using SpacePark.Types;
using System.Collections.Generic;

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
