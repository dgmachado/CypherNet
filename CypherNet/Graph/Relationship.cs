﻿namespace CypherNet.Graph
{
    using System.Collections.Generic;
    using Serialization;

    public class Relationship : GraphEntity<Relationship>
    {
        internal Relationship(long id, object properties, string type)
            : base(id, properties)
        {
            Type = type;
        }

        [DeserializeUsing]
        internal Relationship(long id, IDictionary<string, object> properties,  string type)
            : base(id, properties)
        {
            Type = type;
        }

        public string Type { get; internal set; }
    }
}