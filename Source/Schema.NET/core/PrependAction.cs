namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// </summary>
    [DataContract]
    public partial class PrependAction : InsertAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PrependAction";
    }
}
