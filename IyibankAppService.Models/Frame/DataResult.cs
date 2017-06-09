using System;
using System.Collections.Generic;
using System.Text;

namespace IyibankAppService.Models.Frame
{
    public class DataResult
    {
        public int Success { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
