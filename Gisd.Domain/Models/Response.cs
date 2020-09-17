using System;
using System.Runtime.Serialization;

namespace Gisd.Domain.Models
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "bmx")]
        public SeriesResponse seriesResponse { get; set; }
    }
}
