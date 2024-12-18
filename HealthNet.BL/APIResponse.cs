using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNet.BL
{
    public class APIResponse <T>
    {
        public bool isError {  get; set; }
        public string Message { get; set; }
        public List<T> data { get; set; }
    }
}
