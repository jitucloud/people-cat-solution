using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleCAT.API.Online.Helper;

namespace PeopleCAT.API.Online.Tests
{
    [TestClass]
    public class ConfigManagerTest
    {
        [TestMethod]
        public void ConfigManager_CheckIFReturnedValue_ARE_EQUAL_TO_DEFAULT()
        {
            var defaultValueString = "defaultValue";
            var result = ConfigManager.GetItemAsString("abc", defaultValueString);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, defaultValueString);
        }
    }
}
