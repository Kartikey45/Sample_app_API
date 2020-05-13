using SampleCL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCL.Services
{
    public class SSampleRL : ISampleRL
    {
        public string Return_Name(Sample model)
        {
            return "My name is " + model.Name;
        }
    }
}
