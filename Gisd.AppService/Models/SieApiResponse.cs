using System;
using System.Collections;
using System.Collections.Generic;

namespace Gisd.AppService.Models
{
    public class SieApiResponse
    {
        public string Title { get; set; }

        public IEnumerable<Values> DataValues { get; set; }
    }
}
