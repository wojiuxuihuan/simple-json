namespace SimpleJsonTests.PocoJsonSerializerTests
{
#if NUNIT
    using TestClass = NUnit.Framework.TestFixtureAttribute;
    using TestMethod = NUnit.Framework.TestAttribute;
    using TestCleanup = NUnit.Framework.TearDownAttribute;
    using TestInitialize = NUnit.Framework.SetUpAttribute;
    using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
    using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;
    using NUnit.Framework;
#else
#endif

    using SimpleJson;
    using SimpleJsonTests.DataContractTests;

    public class PublicGetterSettersSerializeTests
    {
        private DataContractPublicGetterSetters _dataContractPublicGetterSetters;

        public PublicGetterSettersSerializeTests()
        {
            _dataContractPublicGetterSetters = new DataContractPublicGetterSetters();
        }

        [Test]
        public void SerializesCorrectly()
        {
            var result = SimpleJson.SerializeObject(_dataContractPublicGetterSetters,
                                                    SimpleJson.PocoJsonSerializerStrategy);

            Assert.AreEqual("{\"DataMemberWithoutName\":\"dmv\",\"DatMemberWithName\":\"dmnv\",\"IgnoreDataMember\":\"idm\",\"NoDataMember\":\"ndm\"}", result);
        }
    }
}