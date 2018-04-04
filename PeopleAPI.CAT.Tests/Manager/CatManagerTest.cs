using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleCAT.API.Online.Interface;
using PeopleCAT.API.Online.Manager;

namespace PeopleCAT.API.Online.Tests.Manager
{
    [TestClass]
    public class CatManagerTest
    {
        [TestMethod]
        public void CatManager_CallingThirdPartyAPI_IS_NOT_NULL()
        {
            ICatManager cm = new CatManager();
            var result = cm.GetCatNameListByOwnerGender();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Result);
        }
    }
}
