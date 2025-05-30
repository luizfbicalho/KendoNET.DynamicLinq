﻿using System.Linq.Dynamic.Core;
using KendoNET.DynamicLinq.Test.Data;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace KendoNET.DynamicLinq.Test
{
    [TestFixture]
    public class GroupTest
    {
        private MockContext _dbContext;



        [SetUp]
        public void Setup()
        {
            _dbContext = MockContext.GetDefaultInMemoryDbContext();
        }

        [Test]
        public void DataSourceRequest_EnumField_GroupedCount()
        {
            // source string = {"take":20,"skip":0,"sort":[{"field":"Number","dir":"desc"}],"group":[{"field":"Gender"}]}


            var request = JsonConvert.DeserializeObject<DataSourceRequest>("{\"take\":20,\"skip\":0,\"sort\":[{\"field\":\"Number\",\"dir\":\"desc\"}],\"group\":[{\"field\":\"Gender\"}]}");


            var result = _dbContext.Employee.AsQueryable().ToDataSourceResult(request);
            var groupItems = result.Groups.ToDynamicList().Count;
            ClassicAssert.AreEqual(3, groupItems);
        }
    }
}