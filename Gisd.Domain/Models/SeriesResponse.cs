using System;
using System.Runtime.Serialization;


namespace Gisd.Domain.Models
{
    [DataContract]
    public class SeriesResponse
    {
        [DataMember(Name = "series")]
        public Serie[] series { get; set; }
    }
}
