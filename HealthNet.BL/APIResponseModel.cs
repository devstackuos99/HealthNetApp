﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNet.BL
{
    public class APIResponseModel<T>
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public List<T> Data { get; set; }
    }
}
