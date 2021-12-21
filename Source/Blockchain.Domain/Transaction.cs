using System;
using System.Runtime.Serialization;

namespace Blockchain.Domain
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public string Sender { get; set; }

        [DataMember]
        public string Recipient { get; set; }

        [DataMember]
        public Decimal Amount { get; set; }

        [DataMember]
        public Decimal Fee { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}