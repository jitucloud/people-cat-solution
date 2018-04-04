using Newtonsoft.Json;
using PeopleCAT.API.Online.Helper;
using PeopleCAT.API.Online.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PeopleCAT.API.Online.DataLayer
{
    /// <summary>
    /// Data Layer for calling third party API
    /// </summary>
    public static class PeopleCatAPIDAL
    {
        /// <summary>
        /// Get Data from Third Party URL Async
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="thirdPartyURI">Uri</param>
        /// <returns>Task<T></returns>
        public async static Task<T> GetDataAsyncFromThirdParty<T>(Uri thirdPartyURI)
        {
            using (HttpClient wc = new HttpClient())
            {
                var response = await wc.GetAsync(thirdPartyURI);
                if (response.IsSuccessStatusCode)
                {
                    var formattedResponse = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(formattedResponse);
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}