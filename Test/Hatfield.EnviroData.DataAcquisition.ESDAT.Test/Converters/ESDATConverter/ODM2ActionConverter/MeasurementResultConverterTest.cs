﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;
using Hatfield.EnviroData.Core;
using Hatfield.EnviroData.DataAcquisition.ESDAT.Converters;

namespace Hatfield.EnviroData.DataAcquisition.ESDAT.Test.Converters
{
    [TestFixture]
    class MeasurementResultConverterTest : ODM2ActionConverterTest
    {
        [Test]
        public void SampleCollectionTest()
        {
            var sample = new SampleFileData();
            var unit = new Unit();
            var measurementResult = measurementResultConverter.Convert(sample, measurementResultValueConverter, unit);

            Assert.AreEqual(0, measurementResult.ResultID);
            Assert.AreEqual(null, measurementResult.XLocation);
            Assert.AreEqual(null, measurementResult.XLocationUnitsID);
            Assert.AreEqual(null, measurementResult.YLocation);
            Assert.AreEqual(null, measurementResult.YLocationUnitsID);
            Assert.AreEqual(null, measurementResult.ZLocation);
            Assert.AreEqual(null, measurementResult.ZLocationUnitsID);
            Assert.AreEqual(null, measurementResult.SpatialReferenceID);
            Assert.AreEqual("notCensored", measurementResult.CensorCodeCV);
            Assert.AreEqual("unknown", measurementResult.QualityCodeCV);
            Assert.AreEqual("unknown", measurementResult.AggregationStatisticCV);
            Assert.AreEqual(0, measurementResult.TimeAggregationInterval);
            Assert.AreEqual(0, measurementResult.TimeAggregationIntervalUnitsID);
        }

        [Test]
        public void ChemistryTest()
        {
            var chemistry = new ChemistryFileData();
            var unit = new Unit();
            var measurementResult = measurementResultConverter.Convert(chemistry, measurementResultValueConverter, unit);

            Assert.AreEqual(0, measurementResult.ResultID);
            Assert.AreEqual(null, measurementResult.XLocation);
            Assert.AreEqual(null, measurementResult.XLocationUnitsID);
            Assert.AreEqual(null, measurementResult.YLocation);
            Assert.AreEqual(null, measurementResult.YLocationUnitsID);
            Assert.AreEqual(null, measurementResult.ZLocation);
            Assert.AreEqual(null, measurementResult.ZLocationUnitsID);
            Assert.AreEqual(null, measurementResult.SpatialReferenceID);
            Assert.AreEqual("notCensored", measurementResult.CensorCodeCV);
            Assert.AreEqual("unknown", measurementResult.QualityCodeCV);
            Assert.AreEqual("unknown", measurementResult.AggregationStatisticCV);
            Assert.AreEqual(0, measurementResult.TimeAggregationInterval);
            Assert.AreEqual(0, measurementResult.TimeAggregationIntervalUnitsID);
        }
    }
}
