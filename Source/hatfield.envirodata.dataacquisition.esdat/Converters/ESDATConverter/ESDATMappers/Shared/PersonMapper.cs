﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hatfield.EnviroData.Core;
using Hatfield.EnviroData.WQDataProfile;

namespace Hatfield.EnviroData.DataAcquisition.ESDAT.Converters
{
    public class PersonMapper : PersonMapperBase, IESDATSharedMapper<Person>
    {
        public PersonMapper(ESDATDuplicateChecker duplicateChecker, IWQDefaultValueProvider WQDefaultValueProvider, WayToHandleNewData wayToHandleNewData) : base(duplicateChecker, WQDefaultValueProvider, wayToHandleNewData)
        {
        }

        public Person Map(ESDATModel esdatModel)
        {
            var entity = Scaffold(esdatModel);
            entity = GetDuplicate(_duplicateChecker, _wayToHandleNewData, entity);

            return entity;
        }

        public Person Scaffold(ESDATModel esdatModel)
        {
            Person person = new Person();

            person.PersonFirstName = _WQDefaultValueProvider.DefaultPersonFirstName;
            person.PersonMiddleName = _WQDefaultValueProvider.DefaultPersonMiddleName;
            person.PersonLastName = _WQDefaultValueProvider.DefaultPersonLastName;

            return person;
        }
    }
}
