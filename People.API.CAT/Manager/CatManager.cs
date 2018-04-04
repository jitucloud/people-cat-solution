using System.Threading.Tasks;
using PeopleCAT.API.Online.Interface;
using PeopleCAT.API.Online.DataLayer;
using System.Linq;
using PeopleCAT.API.Online.Model;
using PeopleCAT.API.Online.Helper;
using System;
using System.Collections.Generic;

namespace PeopleCAT.API.Online.Manager
{
    /// <summary>
    /// Cat Manager class
    /// </summary>
    public class CatManager : ICatManager
    {
        public async Task<object> GetCatNameListByOwnerGender()
        {
            var peopleURI = new Uri(ConfigManager.GetItemAsString("PeopleJsonLocation", "http://agl-developer-test.azurewebsites.net/people.json"));

            if (peopleURI != null && !string.IsNullOrEmpty(peopleURI.AbsolutePath))
            {
                var peopleCatInfo = await PeopleCatAPIDAL.GetDataAsyncFromThirdParty<List<People>>(peopleURI);

                if (peopleCatInfo != null && peopleCatInfo.Count > 0)
                {
                    return new
                    {
                        Male = peopleCatInfo.Where(p => p.Gender == Gender.Male && p.Pets != null && p.Pets.Count() > 0)
                                            .SelectMany(c => c.Pets).Where(a => a.Type == AnimalType.Cat)
                                            .OrderBy(a => a.Name).Select(n => n.Name).ToList(),

                        Female = peopleCatInfo.Where(p => p.Gender == Gender.Female && p.Pets != null && p.Pets.Count() > 0)
                                              .SelectMany(c => c.Pets).Where(a => a.Type == AnimalType.Cat)
                                              .OrderBy(a => a.Name).Select(n => n.Name).ToList()
                    };
                }
                else return null;
            }
            else return null;
        }
    }
}