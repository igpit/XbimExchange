﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Xbim.COBieLite.CollectionTypes;

// ReSharper disable once CheckNamespace
namespace Xbim.COBieLiteUK
{
    [JsonObject]
    public partial class FloorCollectionType : ICollectionType<FloorType>, IEnumerable<FloorType>
    {
        public IEnumerator<FloorType> GetEnumerator()
        {
            return  Floor.OfType<FloorType>().GetEnumerator();
        }

        [XmlIgnore][JsonIgnore]
        public List<FloorType> InnerList
        {
            get { return Floor; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Floor.OfType<FloorType>().GetEnumerator();
        }
    }
}
