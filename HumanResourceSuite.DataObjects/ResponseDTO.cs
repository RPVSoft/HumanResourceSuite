using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataObjects
{
    public class MultiResponseDTO<T>
    {
        public List<T> Data { get; set; }
        public Exception ErrorMessage { get; set; }        
    }

    public class SingleResponseDTO<T>
    {
        public T Result { get; set; }
        public Exception ErrorMessage { get; set; }
    }
}
