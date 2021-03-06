﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;
using Hatfield.EnviroData.Core;
using Hatfield.EnviroData.DataAcquisition.ESDAT.Converters;
using System.Data.Entity;
using Hatfield.EnviroData.WQDataProfile;

namespace Hatfield.EnviroData.DataAcquisition.ESDAT.Test.Converters
{
    [TestFixture]
    class SampleCollectionActionMapperTest
    {
        [Test]
        public void ScaffoldTest()
        {
            var esdatModel = new ESDATModel();
            esdatModel.DateReported = DateTime.Now;

            var mockDb = new Mock<IDbContext>();
            var mockDbContext = mockDb.Object;
            var duplicateChecker = new ESDATDuplicateChecker(mockDbContext);
            var defaultValueProvider = new StaticWQDefaultValueProvider();
            var wayToHandleNewData = WayToHandleNewData.ThrowExceptionForNewData;
            var SampleCollectionFactory = new ESDATSampleCollectionMapperFactory(duplicateChecker, defaultValueProvider, wayToHandleNewData);
            var chemistryFactory = new ESDATChemistryMapperFactory(duplicateChecker, defaultValueProvider, wayToHandleNewData);
            var mapper = new SampleCollectionActionMapper(duplicateChecker, SampleCollectionFactory, defaultValueProvider, chemistryFactory, wayToHandleNewData);

            var action = mapper.Scaffold(esdatModel);

            Assert.AreEqual(0, action.ActionID);
            Assert.AreEqual("Specimen collection", action.ActionTypeCV);
            Assert.AreEqual(0, action.MethodID);
            Assert.AreEqual(esdatModel.DateReported, action.BeginDateTime);
            Assert.AreEqual(0, action.BeginDateTimeUTCOffset);
            Assert.AreEqual(null, action.EndDateTime);
            Assert.AreEqual(null, action.EndDateTimeUTCOffset);
            Assert.AreEqual(null, action.ActionDescription);
            Assert.AreEqual(null, action.ActionFileLink);
        }
    }
}
