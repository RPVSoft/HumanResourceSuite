using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
    public class ResponseDTO<T>
    {
        public List<T> Data { get; set; }
        public Exception ErrorMessage { get; set; }
    }
}
