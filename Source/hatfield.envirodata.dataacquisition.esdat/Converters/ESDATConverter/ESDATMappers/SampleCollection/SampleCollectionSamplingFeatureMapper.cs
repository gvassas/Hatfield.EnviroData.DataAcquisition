﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hatfield.EnviroData.Core;
using Hatfield.EnviroData.WQDataProfile;

namespace Hatfield.EnviroData.DataAcquisition.ESDAT.Converters
{
    public class SampleCollectionSamplingFeatureMapper : SamplingFeatureMapperBase, IESDATSampleCollectionMapper<SamplingFeature>
    {
        // Sample Collection Constants
        private const string SamplingFeatureTypeCVSampleCollection = "Site";

        public SampleCollectionSamplingFeatureMapper(ESDATDuplicateChecker duplicateChecker, IWQDefaultValueProvider WQDefaultValueProvider, WayToHandleNewData wayToHandleNewData) : base(duplicateChecker, WQDefaultValueProvider, wayToHandleNewData)
        {
        }

        public SamplingFeature Map(ESDATModel esdatModel)
        {
            var entity = Scaffold(esdatModel);
            entity = GetDuplicate(_duplicateChecker, _wayToHandleNewData, entity);

            return entity;
        }

        public SamplingFeature Scaffold(ESDATModel esdatModel)
        {
            SamplingFeature samplingFeature = new SamplingFeature();

            samplingFeature.SamplingFeatureTypeCV = SamplingFeatureTypeCVSampleCollection;
            samplingFeature.SamplingFeatureCode = _WQDefaultValueProvider.DefaultSamplingFeatureCode;
            samplingFeature.SamplingFeatureUUID = new Guid();

            return samplingFeature;
        }
    }
}
