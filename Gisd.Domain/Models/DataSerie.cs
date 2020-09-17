using System;
using System.Runtime.Serialization;

namespace Gisd.Domain.Models
{
    [DataContract]
    public class DataSerie
    {
        [DataMember(Name = "fecha")]
        public string Date { get; set; }

        [DataMember(Name = "dato")]
        public string Data { get; set; }
    }
}
