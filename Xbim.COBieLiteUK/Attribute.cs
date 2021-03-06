﻿using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Xbim.CobieLiteUk
{
    public partial class Attribute
    {
        /// <summary>
        /// PropertySetName is a proxy property for ExternalEntity. It is not a part of the schema but it is part of the API to make sure the
        /// data schema is used in an uniform way.
        /// </summary>
        [XmlIgnore][JsonIgnore]
        public string PropertySetName { get { return ExternalEntity; } set { ExternalEntity = value; } }
    }
}
