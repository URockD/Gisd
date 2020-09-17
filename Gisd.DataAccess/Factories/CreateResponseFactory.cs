using System;
using System.Net;
using System.Runtime.Serialization.Json;
using Gisd.Domain.Models;

namespace Gisd.DataAccess.Factories
{
    internal class CreateResponseFactory
    {
        internal static T Create<T>(HttpWebResponse response)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
            var objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
            T jsonResponse = (T)objResponse;
            return jsonResponse;
        }
    }
}
