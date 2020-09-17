using System;
using System.Collections;
using System.Collections.Generic;
using Gisd.Domain.Models;
using Gisd.AppService.Models;

namespace Gisd.AppService.Models
{
    public class DashboardResponse
    {
        public string Title { get; set; }
  
        public IEnumerable<string> Labels { get; set; }

        public IEnumerable<string> Data { get; set; }
    }
}
