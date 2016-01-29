using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class DemoInputModel
    {
        public string InputString { get; set; }
        public int Count { get; set; }
    }

    public class DemoOutputModel
    {
        public string Message { get; set; }
        public int Count { get; set; }
    }
}