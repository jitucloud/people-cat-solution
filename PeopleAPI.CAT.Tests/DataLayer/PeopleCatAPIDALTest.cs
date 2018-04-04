using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleCAT.API.Online.Helper;
using PeopleCAT.API.Online.DataLayer;
using System.Collections.Generic;
using PeopleCAT.API.Online.Model;

namespace PeopleCAT.API.Online.Tests.DataLayer
{
    [TestClass]
    public class PeopleCatAPIDALTest
    {
        [TestMethod]
        public void PeopleCatAPIDAL_GetDataAsyncFromThirdParty_IS_NULL()
        {
            //Arrange
            var peopleURI = new Uri(ConfigManager.GetItemAsString("PeopleJsonLocation", "http://agl-developer-test.azurewebsites.net/fake-url.json"));
           
            //Act
            var peopleCatInfo = PeopleCatAPIDAL.GetDataAsyncFromThirdParty<List<People>>(peopleURI);
            peopleCatInfo.Wait();
            var results = peopleCatInfo.Result;

            //Assert
            Assert.IsNull(results);
        }

        [TestMethod]
        public void PeopleCatAPIDAL_GetDataAsyncFromThirdParty_IS_NOT_NULL()
        {
            //Arrange
            var peopleURI = new Uri(ConfigManager.GetItemAsString("PeopleJsonLocation", "http://agl-developer-test.azurewebsites.net/people.json"));

            //Act
            var peopleCatInfo = PeopleCatAPIDAL.GetDataAsyncFromThirdParty<List<People>>(peopleURI);
            peopleCatInfo.Wait();
            var results = peopleCatInfo.Result;

            //Assert
            Assert.IsNotNull(results);
        }
    }
}
