namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class SendAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SendAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryMethod?>? DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience, Organization, Person>? Recipient { get; set; }
    }
}
