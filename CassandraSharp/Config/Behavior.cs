﻿// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
// limitations under the License.
namespace CassandraSharp.Config
{
    using System.Xml.Serialization;
    using Apache.Cassandra;

    public class BehaviorConfig
    {
        [XmlAttribute("maxRetries")]
        public int MaxRetries;

        [XmlAttribute("poolSize")]
        public int PoolSize;

        [XmlAttribute("retryOnTimeout")]
        public bool RetryOnTimeout;

        [XmlAttribute("retryOnUnavailable")]
        public bool RetryOnUnavailable;

        [XmlAttribute("retryOnNotFound")]
        public bool RetryOnNotFound;

        [XmlAttribute("defaultReadConsistencyLevel")]
        public ConsistencyLevel DefaultReadConsistencyLevel;

        [XmlAttribute("defaultWriteConsistencyLevel")]
        public ConsistencyLevel DefaultWriteConsistencyLevel;

        [XmlAttribute("defaultTTL")]
        public int DefaultTTL;

        [XmlAttribute("defaultKeyspace")]
        public string DefaultKeyspace;
    }
}